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
    public partial class uCtrlOdaİslemleri : UserControl
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter data;

        public uCtrlOdaİslemleri()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();


        void VeriGetir()
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            data = new SqlDataAdapter("SELECT *FROM Odalar", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGVOdalar.DataSource = tablo;
            baglanti.Close();
        }


        void Temizle()
        {
            txtOdaNumarasi.Text = "";
            cboxOdaTipi.SelectedIndex = -1;
            cboxYatakTipi.SelectedIndex = -1;
            txtOdaTel.Text = "";
            txtOdaUcreti.Text = "";
            txtDurumu.Text = "Boş";
        }



        private void dataGVOdalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOdaNumarasi.Text = dataGVOdalar.CurrentRow.Cells[1].Value.ToString();
            cboxOdaTipi.Text = dataGVOdalar.CurrentRow.Cells[2].Value.ToString();
            cboxYatakTipi.Text = dataGVOdalar.CurrentRow.Cells[3].Value.ToString();
            txtOdaTel.Text = dataGVOdalar.CurrentRow.Cells[4].Value.ToString();
            txtOdaUcreti.Text = dataGVOdalar.CurrentRow.Cells[5].Value.ToString();
            txtDurumu.Text = dataGVOdalar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtOdaNumarasi.Text != "" && cboxOdaTipi.Text != "" && cboxYatakTipi.Text != "" && txtOdaTel.Text != "" && txtOdaUcreti.Text != "")
            {
                string sorgu = "INSERT INTO Odalar(OdaNumara,OdaTip,YatakTip,OdaTel,OdaUcret,OdaDurum) VALUES (@OdaNumara,@OdaTip,@YatakTip,@OdaTel,@OdaUcret,@OdaDurum)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OdaNumara", txtOdaNumarasi.Text);
                komut.Parameters.AddWithValue("@OdaTip", cboxOdaTipi.Text);
                komut.Parameters.AddWithValue("@YatakTip", cboxYatakTipi.Text);
                komut.Parameters.AddWithValue("@OdaTel", txtOdaTel.Text);
                komut.Parameters.AddWithValue("@OdaUcret", txtOdaUcreti.Text);
                komut.Parameters.AddWithValue("@OdaDurum", txtDurumu.Text);

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtOdaNumarasi.Text != "" && cboxOdaTipi.Text != "" && cboxYatakTipi.Text != "" && txtOdaTel.Text != "" && txtOdaUcreti.Text != "")
            {
                string sorgu = "UPDATE Odalar SET OdaNumara = @OdaNumara, OdaTip = @OdaTip, YatakTip = @YatakTip, OdaTel = @OdaTel, OdaUcret = @OdaUcret, OdaDurum = @OdaDurum WHERE Odaid = @Odaid";
                komut = new SqlCommand(sorgu, baglanti);
                int guncellenecekId = Convert.ToInt32(dataGVOdalar.CurrentRow.Cells[0].Value);
                komut.Parameters.AddWithValue("@Odaid", guncellenecekId);
                komut.Parameters.AddWithValue("@OdaNumara", txtOdaNumarasi.Text);
                komut.Parameters.AddWithValue("@OdaTip", cboxOdaTipi.Text);
                komut.Parameters.AddWithValue("@YatakTip", cboxYatakTipi.Text);
                komut.Parameters.AddWithValue("@OdaTel", txtOdaTel.Text);
                komut.Parameters.AddWithValue("@OdaUcret", txtOdaUcreti.Text);
                komut.Parameters.AddWithValue("@OdaDurum", txtDurumu.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriGetir();
                MessageBox.Show("Kayıt başarılı bir şekilde güncelleştirildi.");
                Temizle();
            }
            else
                MessageBox.Show("Güncelleme yapılamadı. Lütfen güncelleme yapılacak oda kaydını seçiniz.");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOdaNumarasi.Text != "" && cboxOdaTipi.Text != "" && cboxYatakTipi.Text != "" && txtOdaTel.Text != "" && txtOdaUcreti.Text != "")
            {
                baglanti = new SqlConnection(bgl.Adres);
                string sorgu = "SELECT OdaNumara,OdaTip,YatakTip,OdaTel,OdaUcret,OdaDurum FROM Odalar WHERE  OdaNumara=@OdaNumara AND OdaTip=@OdaTip AND YatakTip=@YatakTip AND OdaTel=@OdaTel AND OdaUcret=@OdaUcret AND OdaDurum=@OdaDurum";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@OdaNumara", txtOdaNumarasi.Text);
                komut.Parameters.AddWithValue("@OdaTip", cboxOdaTipi.Text);
                komut.Parameters.AddWithValue("@YatakTip", cboxYatakTipi.Text);
                komut.Parameters.AddWithValue("@OdaTel", txtOdaTel.Text);
                komut.Parameters.AddWithValue("@OdaUcret", txtOdaUcreti.Text);
                komut.Parameters.AddWithValue("@OdaDurum", txtDurumu.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    string sorgu2 = "DELETE FROM Odalar WHERE Odaid = @Odaid";
                    komut = new SqlCommand(sorgu2, baglanti);
                    int silinecekId = Convert.ToInt32(dataGVOdalar.CurrentRow.Cells[0].Value);
                    komut.Parameters.AddWithValue("@Odaid", silinecekId);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    VeriGetir();
                    MessageBox.Show("Kayıt başarılı bir şekilde silindi.");
                    Temizle();
                }
                else
                    MessageBox.Show("Böyle bir oda kaydı bulunamamıştır. Lütfen silinecek oda kaydını seçiniz.");
            }
            else
                MessageBox.Show("Böyle bir oda kaydı bulunamamıştır. Lütfen silinecek oda kaydını seçiniz.");

        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            if (txtOdaAra.Text != "")
            {
                string sorgu = "SELECT *FROM Odalar WHERE OdaNumara = @OdaNumara";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@OdaNumara", txtOdaAra.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);


                if (tablo.Rows.Count > 0)
                {
                    dataGVOdalar.DataSource = tablo;
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

        private void uCtrlOdaİslemleri_Leave(object sender, EventArgs e)
        {
            Temizle();
            txtOdaAra.Text = "";
        }

        private void uCtrlOdaİslemleri_VisibleChanged(object sender, EventArgs e)
        {
            VeriGetir();
        }
    }
}
