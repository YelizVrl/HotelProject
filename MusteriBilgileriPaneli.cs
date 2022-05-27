using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelRezervasyonOtomasyonu
{
    public partial class uCtrlMusteriBilgileri : UserControl
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter data;

        public uCtrlMusteriBilgileri()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        void VeriGetir()
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            data = new SqlDataAdapter("SELECT *FROM Musteriler", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGVMusteriler.DataSource = tablo;
            baglanti.Close();
        }

        void Temizle()
        {
            txtMusteriAdSoyad.Text = "";
            txtMusteriTC.Text = "";
            cboxMusteriCinsiyet.SelectedIndex = -1;
            txtMusteriTel.Text = "";
            txtMusteriOdaNo.Text = "";
        }

        private void dataGVMusteriler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMusteriAdSoyad.Text = dataGVMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtMusteriTC.Text = dataGVMusteriler.CurrentRow.Cells[2].Value.ToString();
            cboxMusteriCinsiyet.Text = dataGVMusteriler.CurrentRow.Cells[3].Value.ToString();
            txtMusteriTel.Text = dataGVMusteriler.CurrentRow.Cells[4].Value.ToString();
            txtMusteriOdaNo.Text = dataGVMusteriler.CurrentRow.Cells[5].Value.ToString();
        }

        private void uCtrlMusteriBilgileri_VisibleChanged(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdSoyad.Text != "" && txtMusteriTC.Text != "" && cboxMusteriCinsiyet.Text != "" && txtMusteriTel.Text != "" && txtMusteriOdaNo.Text != "")
            {
                string sorgu = "INSERT INTO Musteriler(MusteriAdSoyad,MusteriTC,MusteriCinsiyet,MusteriTel,MusteriOdaNo) VALUES (@MusteriAdSoyad,@MusteriTC,@MusteriCinsiyet,@MusteriTel,@MusteriOdaNo)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@MusteriAdSoyad", txtMusteriAdSoyad.Text);
                komut.Parameters.AddWithValue("@MusteriTC", txtMusteriTC.Text);
                komut.Parameters.AddWithValue("@MusteriCinsiyet", cboxMusteriCinsiyet.Text);
                komut.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut.Parameters.AddWithValue("@MusteriOdaNo", txtMusteriOdaNo.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriGetir();
                MessageBox.Show("Kayıt başarılı bir şekilde oluşturuldu.");
                Temizle();
            }
            else
                MessageBox.Show("Kayıt oluşturulamadı. Lütfen istenilen bilgileri eksiksiz giriniz.");
        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            if (txtOdaAra.Text != "")
            {
                string sorgu = "SELECT *FROM Musteriler WHERE MusteriOdaNo = @MusteriOdaNo";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@MusteriOdaNo", txtOdaAra.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    dataGVMusteriler.DataSource = tablo;
                    baglanti.Close();
                }

                else
                {
                    MessageBox.Show("Aradığınız oda bulunamamaktadır. Lütfen istenilen bilgiyi eksiksiz ve doğru giriniz.");
                    txtOdaAra.Text = "";
                }
            }
        }

        private void txtOdaAra_TextChanged(object sender, EventArgs e)
        {
            if (txtOdaAra.Text == "")
                VeriGetir();
        }

        private void uCtrlMusteriBilgileri_Leave(object sender, EventArgs e)
        {
            Temizle();
            txtOdaAra.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdSoyad.Text != "" && txtMusteriTC.Text != "" && cboxMusteriCinsiyet.Text != "" && txtMusteriTel.Text != "" && txtMusteriOdaNo.Text != "")
            {
                baglanti = new SqlConnection(bgl.Adres);
                string sorgu = "SELECT MusteriAdSoyad,MusteriTC,MusteriCinsiyet,MusteriTel,MusteriOdaNo FROM Musteriler WHERE  MusteriAdSoyad=@MusteriAdSoyad AND MusteriTC=@MusteriTC AND MusteriCinsiyet=@MusteriCinsiyet AND MusteriTel=@MusteriTel AND MusteriOdaNo=@MusteriOdaNo";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@MusteriAdSoyad", txtMusteriAdSoyad.Text);
                komut.Parameters.AddWithValue("@MusteriTC", txtMusteriTC.Text);
                komut.Parameters.AddWithValue("@MusteriCinsiyet", cboxMusteriCinsiyet.Text);
                komut.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut.Parameters.AddWithValue("@MusteriOdaNo", txtMusteriOdaNo.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    string sorgu2 = "DELETE FROM Musteriler WHERE Musteriid = @Musteriid";
                    komut = new SqlCommand(sorgu2, baglanti);
                    int silinecekId = Convert.ToInt32(dataGVMusteriler.CurrentRow.Cells[0].Value);
                    komut.Parameters.AddWithValue("@Musteriid", silinecekId);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    VeriGetir();
                    MessageBox.Show("Kayıt başarılı bir şekilde silindi.");
                    Temizle();
                }
                else
                    MessageBox.Show("Böyle bir müşteri kaydı bulunamamıştır. Lütfen silinecek müşteri kaydını seçiniz.");
            }
            else
                MessageBox.Show("Böyle bir müşteri kaydı bulunamamıştır. Lütfen silinecek müşteri kaydını seçiniz.");
        }
    }
}
