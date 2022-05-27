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
    public partial class uCtrlOdaRezervasyon : UserControl
    {

        SqlConnection baglanti;
        SqlDataAdapter data;

        public uCtrlOdaRezervasyon()
        {
            InitializeComponent();
        }


        BaglantiSinif bgl = new BaglantiSinif();


        void VeriGetir()
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            data = new SqlDataAdapter("SELECT Odaid,OdaNumara,OdaTip,YatakTip,OdaUcret,OdaDurum FROM Odalar WHERE OdaDurum='Boş'", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGVOdalar.DataSource = tablo;
            baglanti.Close();
        }


        void Temizle()
        {
            txtMusteriAdSoyad.Text = "";
            txtMusteriTC.Text = "";
            cboxMusteriCinsiyet.SelectedIndex = -1;
            txtMusteriTel.Text = "";
            txtOdaNumarasi.Text = "";
            txtOdaUcreti.Text = "0";
            dtpGirisTarihi.ResetText();
            dtpCikisTarihi.ResetText();
        }



        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdSoyad.Text != "" && txtMusteriTC.Text != "" && cboxMusteriCinsiyet.Text != "" && txtMusteriTel.Text != "" && txtOdaNumarasi.Text != "")
            {
                baglanti.Open();    //Rezerve tablosuna veri kaydetme işlemi
                string sorgu = "INSERT INTO RezerveOdalar(MusteriAdSoyad,MusteriTC,MusteriCinsiyet,MusteriTel,OdaNumara,OdaUcret,GirisTarih,CikisTarih) VALUES (@MusteriAdSoyad,@MusteriTC,@MusteriCinsiyet,@MusteriTel,@OdaNumara,@OdaUcret,@GirisTarih,@CikisTarih)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@MusteriAdSoyad", txtMusteriAdSoyad.Text);
                komut.Parameters.AddWithValue("@MusteriTC", txtMusteriTC.Text);
                komut.Parameters.AddWithValue("@MusteriCinsiyet", cboxMusteriCinsiyet.Text);
                komut.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut.Parameters.AddWithValue("@OdaNumara", txtOdaNumarasi.Text);
                komut.Parameters.AddWithValue("@OdaUcret", txtOdaUcreti.Text);
                komut.Parameters.AddWithValue("@GirisTarih", dtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@CikisTarih", dtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Rezervasyon işlemi başarılı bir şekilde gerçekleştirildi.");
                
                baglanti.Open();   //Rezerve yapılan odanın oda durumunun dolu duruma getirilmesi ve datagriedview'in güncellenmesi işlemi
                string sorgu2 = "UPDATE Odalar SET OdaDurum = @OdaDurum WHERE Odaid = @Odaid";
                SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
                int guncellenecekid = Convert.ToInt32(dataGVOdalar.CurrentRow.Cells[0].Value);
                komut2.Parameters.AddWithValue("@Odaid", guncellenecekid);
                komut2.Parameters.AddWithValue("@OdaDurum", "Dolu");
                komut2.ExecuteNonQuery();
                baglanti.Close();
                VeriGetir();

                baglanti.Open();   //Müşteri bilgilerinin ve oda numarasının müşteriler tablosuna kayıt edilmesi işlemi
                string sorgu3 = "INSERT INTO Musteriler(MusteriAdSoyad,MusteriTC,MusteriCinsiyet,MusteriTel,MusteriOdaNo) VALUES (@MusteriAdSoyad,@MusteriTC,@MusteriCinsiyet,@MusteriTel,@MusteriOdaNo)";
                SqlCommand komut3 = new SqlCommand(sorgu3, baglanti);
                komut3.Parameters.AddWithValue("@MusteriAdSoyad", txtMusteriAdSoyad.Text);
                komut3.Parameters.AddWithValue("@MusteriTC", txtMusteriTC.Text);
                komut3.Parameters.AddWithValue("@MusteriCinsiyet", cboxMusteriCinsiyet.Text);
                komut3.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut3.Parameters.AddWithValue("@MusteriOdaNo", txtOdaNumarasi.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                Temizle();

            }
            else
                MessageBox.Show("İşlem gerçekleştirilemedi. Lütfen rezervasyon yapılacak oda kaydını seçiniz ve bilgileri eksiksiz giriniz.");
        }

        private void dataGVOdalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOdaNumarasi.Text = dataGVOdalar.CurrentRow.Cells[1].Value.ToString();
            txtOdaUcreti.Text = dataGVOdalar.CurrentRow.Cells[4].Value.ToString();
        }

        private void uCtrlOdaRezervasyon_VisibleChanged(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void btnOdaTipAra_Click(object sender, EventArgs e)
        {
            if (txtOdaTipAra.Text != "")
            {
                string sorgu = "SELECT Odaid,OdaNumara,OdaTip,YatakTip,OdaUcret,OdaDurum FROM Odalar WHERE OdaTip = @OdaTip AND OdaDurum='Boş'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@OdaTip", txtOdaTipAra.Text);

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
                    txtOdaTipAra.Text = "";
                }
            }
        }

        private void txtOdaTipAra_TextChanged(object sender, EventArgs e)
        {
            if (txtOdaTipAra.Text == "")
                VeriGetir();
        }

        private void uCtrlOdaRezervasyon_Leave(object sender, EventArgs e)
        {
            Temizle();
            txtOdaTipAra.Text = "";
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
           int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan sonuc = BuyukTarih - KucukTarih;
            lblsonuc.Text = sonuc.TotalDays.ToString();

            int tekucret = Convert.ToInt32(txtOdaUcreti.Text);
            Ucret = Convert.ToInt32(lblsonuc.Text) * tekucret ;
            txtOdaUcreti.Text = Ucret.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
