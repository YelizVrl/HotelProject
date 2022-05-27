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
    public partial class frmSifreYenileme : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter data;

        public frmSifreYenileme()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();


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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e) 
        {
            // Girilen bilgilerin doğruluğunu kontrol ederek şifre güncellemesi yapılması sağlanır.
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                baglanti = new SqlConnection(bgl.Adres);
                string sorgu = "SELECT PersonelAdSoyad,PersonelTC,PersonelCinsiyet,PersonelTel,PersonelKullaniciAd FROM Personeller WHERE PersonelAdSoyad=@PersonelAdSoyad AND PersonelTC=@PersonelTC AND PersonelCinsiyet=@PersonelCinsiyet AND PersonelTel=@PersonelTel AND PersonelKullaniciAd=@PersonelKullaniciAd";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@PersonelAdSoyad", txtPersonelAdSoyad.Text);
                komut.Parameters.AddWithValue("@PersonelTC", txtPersonelTC.Text);
                komut.Parameters.AddWithValue("@PersonelCinsiyet", cboxPersonelCinsiyet.Text);
                komut.Parameters.AddWithValue("@PersonelTel", txtPersonelTel.Text);
                komut.Parameters.AddWithValue("@PersonelKullaniciAd", txtKullaniciAd.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    string sorgu2 = "UPDATE Personeller SET PersonelSifre=@PersonelSifre WHERE PersonelTC = @PersonelTC";
                    SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
                    komut2.Parameters.AddWithValue("@PersonelTc", txtPersonelTC.Text);
                    komut2.Parameters.AddWithValue("@PersonelSifre", txtSifre.Text);
                    baglanti.Open();
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifre başarılı bir şekilde değiştirildi.");
                    Temizle();
                }
                else
                    MessageBox.Show("Böyle bir personel kaydı bulunamamıştır. Lütfen bilgileri doğru ve eksiksiz giriniz.");
            }
            else
                MessageBox.Show("Hatalı şifre girdiniz. Lütfen tekrar deneyin.");

        }
    }
}
