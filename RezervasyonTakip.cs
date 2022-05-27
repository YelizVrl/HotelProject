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
    public partial class uCtrlRezervasyonTakip : UserControl
    {

        SqlConnection baglanti;
        SqlDataAdapter data;

        public uCtrlRezervasyonTakip()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();


        void VeriGetir()
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            data = new SqlDataAdapter("SELECT *FROM RezerveOdalar", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGVRezerveOdalar.DataSource = tablo;
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


        void TekUcret()
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText ="SELECT OdaUcret FROM Odalar WHERE OdaNumara='"+txtOdaNumarasi.Text+"'";
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                lblUcret.Text = dr[0].ToString();
            }
            baglanti.Close();

        }

        private void uCtrlRezervasyonTakip_VisibleChanged(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void btnCikisVer_Click(object sender, EventArgs e)
        {
            if (txtOdaNumarasi.Text != "")
            {
                string sorgu = "SELECT MusteriAdSoyad,MusteriTC,MusteriCinsiyet,MusteriTel,OdaNumara,OdaUcret,GirisTarih,CikisTarih FROM RezerveOdalar WHERE  MusteriAdSoyad=@MusteriAdSoyad AND MusteriTC=@MusteriTC AND MusteriCinsiyet=@MusteriCinsiyet AND MusteriTel=@MusteriTel AND OdaNumara=@OdaNumara AND OdaUcret=@OdaUcret AND GirisTarih=@GirisTarih AND CikisTarih =@CikisTarih";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@MusteriAdSoyad", txtMusteriAdSoyad.Text);
                komut.Parameters.AddWithValue("@MusteriTC", txtMusteriTC.Text);
                komut.Parameters.AddWithValue("@MusteriCinsiyet", cboxMusteriCinsiyet.Text);
                komut.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut.Parameters.AddWithValue("@OdaNumara", txtOdaNumarasi.Text);
                komut.Parameters.AddWithValue("@OdaUcret", txtOdaUcreti.Text);
                komut.Parameters.AddWithValue("@GirisTarih", dtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@CikisTarih", dtpCikisTarihi.Value.ToString("yyyy-MM-dd"));

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    baglanti.Open();
                    string sorgu2 = "DELETE FROM RezerveOdalar WHERE Rezerveid = @Rezerveid";
                    komut = new SqlCommand(sorgu2, baglanti);
                    int silinecekId = Convert.ToInt32(dataGVRezerveOdalar.CurrentRow.Cells[0].Value);
                    komut.Parameters.AddWithValue("@Rezerveid", silinecekId);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Çıkış verme işlemi başarılı bir şekilde gerçekleştirildi.");


                    baglanti.Open(); // müşteri tablosundaki kaydı silinen rezerve odada kalan müşterilerin kaydı da silindi
                    string sorgu4 = "DELETE FROM Musteriler WHERE MusteriOdaNo = @MusteriOdaNo";
                    SqlCommand komut3 = new SqlCommand(sorgu4, baglanti);
                    int silinecekNo = Convert.ToInt32(txtOdaNumarasi.Text);
                    komut3.Parameters.AddWithValue("@MusteriOdaNo", silinecekNo);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();


                    baglanti.Open();   //Rezerve yapılan odanın oda durumunun dolu duruma getirilmesi ve datagriedview'in güncellenmesi işlemi
                    string sorgu3 = "UPDATE Odalar SET OdaDurum = @OdaDurum WHERE OdaNumara = @OdaNumara";
                    SqlCommand komut2 = new SqlCommand(sorgu3, baglanti);
                    int guncellenecekno = Convert.ToInt32(txtOdaNumarasi.Text);
                    komut2.Parameters.AddWithValue("@OdaNumara", guncellenecekno);
                    komut2.Parameters.AddWithValue("@OdaDurum", "Boş");
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    VeriGetir();
                    Temizle();
                }
                else
                    MessageBox.Show("Böyle bir rezerve oda kaydı bulunamamıştır. Lütfen çıkışı verilecek rezerve oda kaydını seçiniz.");
            }
            else
                MessageBox.Show("Böyle bir rezerve oda kaydı bulunamamıştır. Lütfen çıkışı verilecek rezerve oda kaydını seçiniz.");
        }

        private void dataGVRezerveOdalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMusteriAdSoyad.Text = dataGVRezerveOdalar.CurrentRow.Cells[1].Value.ToString();
            txtMusteriTC.Text = dataGVRezerveOdalar.CurrentRow.Cells[2].Value.ToString();
            cboxMusteriCinsiyet.Text = dataGVRezerveOdalar.CurrentRow.Cells[3].Value.ToString();
            txtMusteriTel.Text = dataGVRezerveOdalar.CurrentRow.Cells[4].Value.ToString();
            txtOdaNumarasi.Text = dataGVRezerveOdalar.CurrentRow.Cells[5].Value.ToString();
            txtOdaUcreti.Text = dataGVRezerveOdalar.CurrentRow.Cells[6].Value.ToString();
            dtpGirisTarihi.Text = dataGVRezerveOdalar.CurrentRow.Cells[7].Value.ToString();
            dtpCikisTarihi.Text = dataGVRezerveOdalar.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {

            if (txtOdaNumarasi.Text != "")
            {
                baglanti.Open();
                string sorgu = "UPDATE RezerveOdalar SET OdaUcret=@OdaUcret, CikisTarih=@CikisTarih WHERE Rezerveid = @Rezerveid";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                int guncellenecekId = Convert.ToInt32(dataGVRezerveOdalar.CurrentRow.Cells[0].Value);
                komut.Parameters.AddWithValue("@Rezerveid", guncellenecekId);
                komut.Parameters.AddWithValue("@OdaUcret", txtOdaUcreti.Text);
                komut.Parameters.AddWithValue("@CikisTarih", dtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriGetir();
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleştirildi.");
                Temizle();
                lblDeneme.Text = "0";
            }
            else
                MessageBox.Show("İşlem gerçekleştirilemedi. Lütfen değişiklik yapılacak kaydı seçiniz.");

        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            if (txtOdaAra.Text != "")
            {
                string sorgu = "SELECT *FROM RezerveOdalar WHERE OdaNumara = @OdaNumara";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@OdaNumara", txtOdaAra.Text);

                data = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                data.Fill(tablo);


                if (tablo.Rows.Count > 0)
                {
                    dataGVRezerveOdalar.DataSource = tablo;
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

        private void uCtrlRezervasyonTakip_Leave(object sender, EventArgs e)
        {
            Temizle();
            txtOdaAra.Text = "";
            dtpCikisTarihAra.ResetText();
        }

        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT *FROM RezerveOdalar WHERE CikisTarih = @CikisTarih";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@CikisTarih", dtpCikisTarihAra.Value.ToString("yyyy-MM-dd"));

            data = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            data.Fill(tablo);


            if (tablo.Rows.Count > 0)
            {
                dataGVRezerveOdalar.DataSource = tablo;
                baglanti.Close();
            }

            else
            {
                MessageBox.Show("Aradığınız tarih bulunamamaktadır. Lütfen istenilen bilgiyi eksiksiz ve doğru giriniz.");
            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VeriGetir();
            dtpCikisTarihAra.ResetText();
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            TekUcret();

            int Ucret;
            int Ucre2;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan sonuc = BuyukTarih - KucukTarih;
            lblSonuc.Text = sonuc.TotalDays.ToString();

            int tekucret = Convert.ToInt32(lblUcret.Text);
            Ucret = Convert.ToInt32(lblSonuc.Text) * tekucret;
            string deneme = dataGVRezerveOdalar.CurrentRow.Cells[6].Value.ToString();
            Ucre2 = Ucret - Convert.ToInt32(deneme);
            txtOdaUcreti.Text = Ucret.ToString();
            lblDeneme.Text = Ucre2.ToString();
        }
    }
}
