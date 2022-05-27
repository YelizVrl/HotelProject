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
    public partial class frmGiris : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter data;

        public frmGiris()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();


        void Temizle() // Textboxların text'tinin boş kalmasını sağlar.
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnGirisYap_Click(object sender, EventArgs e) // Veritabanındaki kayıtlı veriler kontrol edilerek giriş sağlanır.
        {
            baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            string sorgu = "SELECT *FROM Personeller WHERE PersonelKullaniciAd = @PersonelKullaniciAd COLLATE SQL_Latin1_General_CP1_CS_AS AND PersonelSifre = @PersonelSifre COLLATE SQL_Latin1_General_CP1_CS_AS ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@PersonelKullaniciAd", txtKullaniciAdi.Text.Trim());
            komut.Parameters.AddWithValue("@PersonelSifre", txtSifre.Text.Trim());
            DataTable tablo = new DataTable();
            data = new SqlDataAdapter(komut);
            data.Fill(tablo);

            if (tablo.Rows.Count > 0) 
            {
                this.Hide();
                string user = txtKullaniciAdi.Text;
                frmAnasayfa obj = new frmAnasayfa(char.ToUpper(user[0]) + user.Substring(1));  //Kullanıcı adını anasayfanın üstüne yazdırır.
                obj.Show();
            }

            else
            {
                baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyin.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureSifre_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
        }

        private void pictureSifre_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }


        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.BackColor = System.Drawing.ColorTranslator.FromHtml("#C0C9DB");
            pnlSifre.BackColor = System.Drawing.ColorTranslator.FromHtml("#C0C9DB");
            pnlAd.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            txtKullaniciAdi.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.BackColor = System.Drawing.ColorTranslator.FromHtml("#C0C9DB");
            pnlAd.BackColor = System.Drawing.ColorTranslator.FromHtml("#C0C9DB");
            txtSifre.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            pnlSifre.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
        }

        private void linklblSifreYenileme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Temizle();
            frmSifreYenileme frm = new frmSifreYenileme();
            frm.ShowDialog();
        }
    }
}
