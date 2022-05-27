using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonOtomasyonu
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa(string name)
        {
            InitializeComponent();
            lblKullaniciAd.Text = name;
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris obj = new frmGiris();
            obj.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            pnlGosterge.Visible = true;
            pnlGosterge.Width = btnOdalar.Width;
            pnlGosterge.Left = btnOdalar.Left;
            btnOdalar.BackColor = System.Drawing.ColorTranslator.FromHtml("#8196C0");
            btnOdaRezerve.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnMusteri.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnRezerveTakip.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            uCtrlOdaİslemleri1.Visible = true;
            uCtrlOdaRezervasyon1.Visible = false;
            uCtrlMusteriBilgileri1.Visible = false;
            uCtrlRezervasyonTakip1.Visible = false;
            uCtrlPersonelIslemleri1.Visible = false;
            uCtrlOdaİslemleri1.BringToFront();
        }

        private void btnOdaRezerve_Click(object sender, EventArgs e)
        {
            pnlGosterge.Visible = true;
            pnlGosterge.Width = btnOdaRezerve.Width;
            pnlGosterge.Left = btnOdaRezerve.Left;
            btnOdaRezerve.BackColor = System.Drawing.ColorTranslator.FromHtml("#8196C0");
            btnOdalar.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnMusteri.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnRezerveTakip.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            uCtrlOdaRezervasyon1.Visible = true;
            uCtrlOdaİslemleri1.Visible = false;
            uCtrlMusteriBilgileri1.Visible = false;
            uCtrlRezervasyonTakip1.Visible = false;
            uCtrlPersonelIslemleri1.Visible = false;
            uCtrlOdaRezervasyon1.BringToFront();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            pnlGosterge.Visible = false;
            uCtrlOdaİslemleri1.Visible = false;
            uCtrlOdaRezervasyon1.Visible = false;
            uCtrlMusteriBilgileri1.Visible = false;
            uCtrlRezervasyonTakip1.Visible = false;
            uCtrlPersonelIslemleri1.Visible = false;

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            pnlGosterge.Visible = true;
            pnlGosterge.Width = btnMusteri.Width;
            pnlGosterge.Left = btnMusteri.Left;
            btnMusteri.BackColor = System.Drawing.ColorTranslator.FromHtml("#8196C0");
            btnOdalar.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnOdaRezerve.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnRezerveTakip.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            uCtrlMusteriBilgileri1.Visible = true;
            uCtrlOdaİslemleri1.Visible = false;
            uCtrlOdaRezervasyon1.Visible = false;
            uCtrlRezervasyonTakip1.Visible = false;
            uCtrlPersonelIslemleri1.Visible = false;
            uCtrlMusteriBilgileri1.BringToFront();
        }


        private void btnPersonel_Click(object sender, EventArgs e)
        {
            pnlGosterge.Visible = true;
            pnlGosterge.Width = btnPersonel.Width;
            pnlGosterge.Left = btnPersonel.Left;
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#8196C0");
            btnOdalar.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnOdaRezerve.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnMusteri.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnRezerveTakip.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            uCtrlPersonelIslemleri1.Visible = true;
            uCtrlMusteriBilgileri1.Visible = false;
            uCtrlOdaİslemleri1.Visible = false;
            uCtrlOdaRezervasyon1.Visible = false;
            uCtrlRezervasyonTakip1.Visible = false;
            uCtrlPersonelIslemleri1.BringToFront();
        }

        private void btnRezerveTakip_Click_1(object sender, EventArgs e)
        {
            pnlGosterge.Visible = true;
            pnlGosterge.Width = btnRezerveTakip.Width;
            pnlGosterge.Left = btnRezerveTakip.Left;
            btnRezerveTakip.BackColor = System.Drawing.ColorTranslator.FromHtml("#8196C0");
            btnOdalar.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnOdaRezerve.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnMusteri.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDCE");
            uCtrlRezervasyonTakip1.Visible = true;
            uCtrlMusteriBilgileri1.Visible = false;
            uCtrlOdaİslemleri1.Visible = false;
            uCtrlOdaRezervasyon1.Visible = false;
            uCtrlPersonelIslemleri1.Visible = false;
            uCtrlRezervasyonTakip1.BringToFront();
        }

    }
}
