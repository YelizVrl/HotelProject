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
    public partial class uCtrlPersonelIslemleri : UserControl
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter data;

        public uCtrlPersonelIslemleri()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        void VeriGetir()
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            data = new SqlDataAdapter("SELECT Personelid,PersonelAdSoyad,PersonelTC,PersonelCinsiyet,PersonelTel FROM Personeller", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGVPersoneller.DataSource = tablo;
            baglanti.Close();
        }

        void Temizle()
        {
            txtPersonelAdSoyad.Text = "";
            txtPersonelTC.Text = "";
            cboxPersonelCinsiyet.SelectedIndex = -1;
            txtPersonelTel.Text = "";
            txtKullaniciAd.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
        }

        private void uCtrlPersonelIslemleri_VisibleChanged(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGVPersoneller_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPersonelAdSoyad.Text = dataGVPersoneller.CurrentRow.Cells[1].Value.ToString();
            txtPersonelTC.Text = dataGVPersoneller.CurrentRow.Cells[2].Value.ToString();
            cboxPersonelCinsiyet.Text = dataGVPersoneller.CurrentRow.Cells[3].Value.ToString();
            txtPersonelTel.Text = dataGVPersoneller.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Personeller(PersonelAdSoyad,PersonelTC,PersonelCinsiyet,PersonelTel,PersonelKullaniciAd,PersonelSifre) VALUES (@PersonelAdSoyad,@PersonelTC,@PersonelCinsiyet,@PersonelTel,@PersonelKullaniciAd,@PersonelSifre)";
            komut = new SqlCommand(sorgu, baglanti);

            if (txtPersonelAdSoyad.Text != "" && txtPersonelTC.Text != "" && cboxPersonelCinsiyet.Text != "" && txtPersonelTel.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != "" && txtSifre.Text == txtSifreTekrar.Text)
            {
                komut.Parameters.AddWithValue("@PersonelAdSoyad", txtPersonelAdSoyad.Text);
                komut.Parameters.AddWithValue("@PersonelTC", txtPersonelTC.Text);
                komut.Parameters.AddWithValue("@PersonelCinsiyet", cboxPersonelCinsiyet.Text);
                komut.Parameters.AddWithValue("@PersonelTel", txtPersonelTel.Text);
                komut.Parameters.AddWithValue("@PersonelKullaniciAd", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@PersonelSifre", txtSifre.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriGetir();
                MessageBox.Show("Personel Kaydı başarılı bir şekilde oluşturuldu.");
                Temizle();
            }
            else
                MessageBox.Show("Bilgileri eksik veya hatalı girdiniz. Tekrar deneyin.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelAdSoyad.Text != "" && txtPersonelTC.Text != "" && cboxPersonelCinsiyet.Text != "" && txtPersonelTel.Text != "")
            {
                baglanti = new SqlConnection(bgl.Adres);
                string sorgu = "SELECT PersonelAdSoyad,PersonelTC,PersonelCinsiyet,PersonelTel FROM Personeller WHERE PersonelAdSoyad=@PersonelAdSoyad AND PersonelTC=@PersonelTC AND PersonelCinsiyet=@PersonelCinsiyet AND PersonelTel=@PersonelTel";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@PersonelAdSoyad", txtPersonelAdSoyad.Text);
                komut.Parameters.AddWithValue("@PersonelTC", txtPersonelTC.Text);
                komut.Parameters.AddWithValue("@PersonelCinsiyet", cboxPersonelCinsiyet.Text);
                komut.Parameters.AddWithValue("@PersonelTel", txtPersonelTel.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    string sorgu2 = "DELETE FROM Personeller WHERE Personelid = @Personelid";
                    komut = new SqlCommand(sorgu2, baglanti);
                    int silinecekId = Convert.ToInt32(dataGVPersoneller.CurrentRow.Cells[0].Value);
                    komut.Parameters.AddWithValue("@Personelid", silinecekId);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    VeriGetir();
                    MessageBox.Show("Personel Kaydı başarılı bir şekilde silindi.");
                    Temizle();
                }
                else
                    MessageBox.Show("Böyle bir personel kaydı bulunamamıştır. Lütfen silinecek personel kaydını seçiniz.");


            }
            else
                MessageBox.Show("Silinecek personeli seçmediniz. Tekrar deneyin");
        }

        private void btnTCPersonelAra_Click(object sender, EventArgs e)
        {
            if (txtTCPersonelAra.Text != "")
            {
                string sorgu = "SELECT Personelid,PersonelAdSoyad,PersonelTC,PersonelCinsiyet,PersonelTel FROM Personeller " +
                    "WHERE PersonelTC = @PersonelTC";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@PersonelTC", txtTCPersonelAra.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);


                if (tablo.Rows.Count > 0)
                {
                    dataGVPersoneller.DataSource = tablo;
                    baglanti.Close();
                }

                else
                {
                    MessageBox.Show("Aradığınız personel bulunamamaktadır. Lütfen istenilen bilgiyi eksiksiz ve doğru giriniz.");
                    txtTCPersonelAra.Text = "";
                }
            }
        }

        private void txtTCPersonelAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTCPersonelAra.Text == "")
                VeriGetir();
        }

        private void uCtrlPersonelIslemleri_Leave(object sender, EventArgs e)
        {
            Temizle();
            txtTCPersonelAra.Text = "";
        }
    }
}
