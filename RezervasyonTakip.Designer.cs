
namespace OtelRezervasyonOtomasyonu
{
    partial class uCtrlRezervasyonTakip
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCtrlRezervasyonTakip));
            this.dataGVRezerveOdalar = new System.Windows.Forms.DataGridView();
            this.Rezerveid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtOdaUcreti = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSureUzat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxMusteriCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtMusteriTC = new System.Windows.Forms.TextBox();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikisVer = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOdaAra = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtOdaAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTarihAra = new System.Windows.Forms.Button();
            this.dtpCikisTarihAra = new System.Windows.Forms.DateTimePicker();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblDeneme = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRezerveOdalar)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVRezerveOdalar
            // 
            this.dataGVRezerveOdalar.AllowUserToAddRows = false;
            this.dataGVRezerveOdalar.AllowUserToDeleteRows = false;
            this.dataGVRezerveOdalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVRezerveOdalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dataGVRezerveOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVRezerveOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rezerveid,
            this.MusteriAdSoyad,
            this.MusteriTC,
            this.MusteriCinsiyet,
            this.MusteriTel,
            this.OdaNumara,
            this.OdaUcret,
            this.GirisTarih,
            this.CikisTarih});
            this.dataGVRezerveOdalar.Location = new System.Drawing.Point(683, 243);
            this.dataGVRezerveOdalar.Name = "dataGVRezerveOdalar";
            this.dataGVRezerveOdalar.ReadOnly = true;
            this.dataGVRezerveOdalar.RowHeadersWidth = 51;
            this.dataGVRezerveOdalar.RowTemplate.Height = 24;
            this.dataGVRezerveOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVRezerveOdalar.Size = new System.Drawing.Size(724, 408);
            this.dataGVRezerveOdalar.TabIndex = 36;
            this.dataGVRezerveOdalar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVRezerveOdalar_CellMouseClick);
            // 
            // Rezerveid
            // 
            this.Rezerveid.DataPropertyName = "Rezerveid";
            this.Rezerveid.HeaderText = "ID";
            this.Rezerveid.MinimumWidth = 6;
            this.Rezerveid.Name = "Rezerveid";
            this.Rezerveid.ReadOnly = true;
            // 
            // MusteriAdSoyad
            // 
            this.MusteriAdSoyad.DataPropertyName = "MusteriAdSoyad";
            this.MusteriAdSoyad.HeaderText = "Ad Soyad";
            this.MusteriAdSoyad.MinimumWidth = 6;
            this.MusteriAdSoyad.Name = "MusteriAdSoyad";
            this.MusteriAdSoyad.ReadOnly = true;
            // 
            // MusteriTC
            // 
            this.MusteriTC.DataPropertyName = "MusteriTC";
            this.MusteriTC.HeaderText = "TC";
            this.MusteriTC.MinimumWidth = 6;
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.ReadOnly = true;
            // 
            // MusteriCinsiyet
            // 
            this.MusteriCinsiyet.DataPropertyName = "MusteriCinsiyet";
            this.MusteriCinsiyet.HeaderText = "Cinsiyet";
            this.MusteriCinsiyet.MinimumWidth = 6;
            this.MusteriCinsiyet.Name = "MusteriCinsiyet";
            this.MusteriCinsiyet.ReadOnly = true;
            // 
            // MusteriTel
            // 
            this.MusteriTel.DataPropertyName = "MusteriTel";
            this.MusteriTel.HeaderText = "Telefon";
            this.MusteriTel.MinimumWidth = 6;
            this.MusteriTel.Name = "MusteriTel";
            this.MusteriTel.ReadOnly = true;
            // 
            // OdaNumara
            // 
            this.OdaNumara.DataPropertyName = "OdaNumara";
            this.OdaNumara.HeaderText = "Oda No";
            this.OdaNumara.MinimumWidth = 6;
            this.OdaNumara.Name = "OdaNumara";
            this.OdaNumara.ReadOnly = true;
            // 
            // OdaUcret
            // 
            this.OdaUcret.DataPropertyName = "OdaUcret";
            this.OdaUcret.HeaderText = "Oda Ücreti";
            this.OdaUcret.MinimumWidth = 6;
            this.OdaUcret.Name = "OdaUcret";
            this.OdaUcret.ReadOnly = true;
            // 
            // GirisTarih
            // 
            this.GirisTarih.DataPropertyName = "GirisTarih";
            this.GirisTarih.HeaderText = "Giriş Tarihi";
            this.GirisTarih.MinimumWidth = 6;
            this.GirisTarih.Name = "GirisTarih";
            this.GirisTarih.ReadOnly = true;
            // 
            // CikisTarih
            // 
            this.CikisTarih.DataPropertyName = "CikisTarih";
            this.CikisTarih.HeaderText = "Çıkış Tarihi";
            this.CikisTarih.MinimumWidth = 6;
            this.CikisTarih.Name = "CikisTarih";
            this.CikisTarih.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(0, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1426, 49);
            this.panel6.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label6.Location = new System.Drawing.Point(534, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "REZERVASYON TAKİBİ";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel11.Location = new System.Drawing.Point(411, 241);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(241, 2);
            this.panel11.TabIndex = 126;
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtOdaNumarasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOdaNumarasi.Enabled = false;
            this.txtOdaNumarasi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNumarasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOdaNumarasi.Location = new System.Drawing.Point(411, 215);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(241, 25);
            this.txtOdaNumarasi.TabIndex = 125;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(411, 109);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(241, 34);
            this.panel9.TabIndex = 124;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label13.Location = new System.Drawing.Point(40, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "ODA BİLGİLERİ";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(27, 109);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(322, 34);
            this.panel8.TabIndex = 123;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label12.Location = new System.Drawing.Point(63, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel7.Location = new System.Drawing.Point(411, 334);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 2);
            this.panel7.TabIndex = 122;
            // 
            // txtOdaUcreti
            // 
            this.txtOdaUcreti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtOdaUcreti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOdaUcreti.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaUcreti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOdaUcreti.Location = new System.Drawing.Point(411, 308);
            this.txtOdaUcreti.Name = "txtOdaUcreti";
            this.txtOdaUcreti.Size = new System.Drawing.Size(241, 25);
            this.txtOdaUcreti.TabIndex = 121;
            this.txtOdaUcreti.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label11.Location = new System.Drawing.Point(407, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 23);
            this.label11.TabIndex = 120;
            this.label11.Text = "Toplam Oda Ücreti";
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnSureUzat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSureUzat.FlatAppearance.BorderSize = 0;
            this.btnSureUzat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSureUzat.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.btnSureUzat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.btnSureUzat.Location = new System.Drawing.Point(386, 614);
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.Size = new System.Drawing.Size(142, 35);
            this.btnSureUzat.TabIndex = 119;
            this.btnSureUzat.Text = "Süre Uzat";
            this.btnSureUzat.UseVisualStyleBackColor = false;
            this.btnSureUzat.Click += new System.EventHandler(this.btnSureUzat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label8.Location = new System.Drawing.Point(407, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 117;
            this.label8.Text = "Çıkış Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label7.Location = new System.Drawing.Point(407, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 116;
            this.label7.Text = "Giriş Tarihi";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihi.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihi.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihi.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCikisTarihi.Location = new System.Drawing.Point(411, 496);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(241, 32);
            this.dtpCikisTarihi.TabIndex = 115;
            this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpCikisTarihi_ValueChanged);
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpGirisTarihi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpGirisTarihi.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpGirisTarihi.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpGirisTarihi.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpGirisTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGirisTarihi.Location = new System.Drawing.Point(411, 403);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(241, 32);
            this.dtpGirisTarihi.TabIndex = 114;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel3.Location = new System.Drawing.Point(27, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 2);
            this.panel3.TabIndex = 113;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.Location = new System.Drawing.Point(27, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 2);
            this.panel2.TabIndex = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel1.Location = new System.Drawing.Point(27, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 2);
            this.panel1.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(23, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 110;
            this.label5.Text = "Müşteri Cinsiyeti";
            // 
            // cboxMusteriCinsiyet
            // 
            this.cboxMusteriCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.cboxMusteriCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMusteriCinsiyet.Enabled = false;
            this.cboxMusteriCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxMusteriCinsiyet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxMusteriCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cboxMusteriCinsiyet.FormattingEnabled = true;
            this.cboxMusteriCinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.cboxMusteriCinsiyet.Location = new System.Drawing.Point(27, 404);
            this.cboxMusteriCinsiyet.Name = "cboxMusteriCinsiyet";
            this.cboxMusteriCinsiyet.Size = new System.Drawing.Size(322, 31);
            this.cboxMusteriCinsiyet.TabIndex = 109;
            // 
            // txtMusteriTC
            // 
            this.txtMusteriTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtMusteriTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMusteriTC.Enabled = false;
            this.txtMusteriTC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriTC.Location = new System.Drawing.Point(27, 305);
            this.txtMusteriTC.MaxLength = 11;
            this.txtMusteriTC.Name = "txtMusteriTC";
            this.txtMusteriTC.Size = new System.Drawing.Size(322, 25);
            this.txtMusteriTC.TabIndex = 108;
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtMusteriTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMusteriTel.Enabled = false;
            this.txtMusteriTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriTel.Location = new System.Drawing.Point(27, 503);
            this.txtMusteriTel.MaxLength = 11;
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(322, 25);
            this.txtMusteriTel.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(407, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Oda Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(23, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Müşteri TC Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(23, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "Müşteri Telefon Numarası";
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtMusteriAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMusteriAdSoyad.Enabled = false;
            this.txtMusteriAdSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(27, 213);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(322, 25);
            this.txtMusteriAdSoyad.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(23, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 102;
            this.label1.Text = "Müşteri Adı Soyadı";
            // 
            // btnCikisVer
            // 
            this.btnCikisVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnCikisVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikisVer.FlatAppearance.BorderSize = 0;
            this.btnCikisVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisVer.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.btnCikisVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.btnCikisVer.Location = new System.Drawing.Point(137, 614);
            this.btnCikisVer.Name = "btnCikisVer";
            this.btnCikisVer.Size = new System.Drawing.Size(142, 35);
            this.btnCikisVer.TabIndex = 128;
            this.btnCikisVer.Text = "Çıkış Ver";
            this.btnCikisVer.UseVisualStyleBackColor = false;
            this.btnCikisVer.Click += new System.EventHandler(this.btnCikisVer_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel10.Controls.Add(this.label14);
            this.panel10.Location = new System.Drawing.Point(683, 109);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(724, 34);
            this.panel10.TabIndex = 129;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label14.Location = new System.Drawing.Point(234, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "REZERVASYONLU ODALAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label10.Location = new System.Drawing.Point(1123, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 23);
            this.label10.TabIndex = 135;
            this.label10.Text = "Oda Numarasına Göre Ara";
            // 
            // btnOdaAra
            // 
            this.btnOdaAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnOdaAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdaAra.FlatAppearance.BorderSize = 0;
            this.btnOdaAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaAra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaAra.ForeColor = System.Drawing.Color.White;
            this.btnOdaAra.Image = ((System.Drawing.Image)(resources.GetObject("btnOdaAra.Image")));
            this.btnOdaAra.Location = new System.Drawing.Point(1367, 212);
            this.btnOdaAra.Name = "btnOdaAra";
            this.btnOdaAra.Size = new System.Drawing.Size(40, 25);
            this.btnOdaAra.TabIndex = 134;
            this.btnOdaAra.UseVisualStyleBackColor = false;
            this.btnOdaAra.Click += new System.EventHandler(this.btnOdaAra_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel5.Location = new System.Drawing.Point(1128, 236);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 133;
            // 
            // txtOdaAra
            // 
            this.txtOdaAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtOdaAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOdaAra.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOdaAra.Location = new System.Drawing.Point(1127, 211);
            this.txtOdaAra.Multiline = true;
            this.txtOdaAra.Name = "txtOdaAra";
            this.txtOdaAra.Size = new System.Drawing.Size(238, 25);
            this.txtOdaAra.TabIndex = 132;
            this.txtOdaAra.TextChanged += new System.EventHandler(this.txtOdaAra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label9.Location = new System.Drawing.Point(679, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 23);
            this.label9.TabIndex = 139;
            this.label9.Text = "Çıkış Tarihine Göre Ara";
            // 
            // btnTarihAra
            // 
            this.btnTarihAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnTarihAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarihAra.FlatAppearance.BorderSize = 0;
            this.btnTarihAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarihAra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihAra.ForeColor = System.Drawing.Color.White;
            this.btnTarihAra.Image = ((System.Drawing.Image)(resources.GetObject("btnTarihAra.Image")));
            this.btnTarihAra.Location = new System.Drawing.Point(923, 212);
            this.btnTarihAra.Name = "btnTarihAra";
            this.btnTarihAra.Size = new System.Drawing.Size(40, 25);
            this.btnTarihAra.TabIndex = 138;
            this.btnTarihAra.UseVisualStyleBackColor = false;
            this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
            // 
            // dtpCikisTarihAra
            // 
            this.dtpCikisTarihAra.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihAra.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihAra.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihAra.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihAra.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.dtpCikisTarihAra.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.dtpCikisTarihAra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCikisTarihAra.Location = new System.Drawing.Point(683, 210);
            this.dtpCikisTarihAra.Name = "dtpCikisTarihAra";
            this.dtpCikisTarihAra.Size = new System.Drawing.Size(234, 30);
            this.dtpCikisTarihAra.TabIndex = 140;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(969, 212);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(40, 25);
            this.btnYenile.TabIndex = 141;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(614, 531);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(16, 17);
            this.lblUcret.TabIndex = 142;
            this.lblUcret.Text = "0";
            this.lblUcret.Visible = false;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(636, 531);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(16, 17);
            this.lblSonuc.TabIndex = 143;
            this.lblSonuc.Text = "0";
            this.lblSonuc.Visible = false;
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Font = new System.Drawing.Font("Goudy Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeneme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.lblDeneme.Location = new System.Drawing.Point(572, 339);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(17, 19);
            this.lblDeneme.TabIndex = 144;
            this.lblDeneme.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Goudy Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label15.Location = new System.Drawing.Point(407, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 19);
            this.label15.TabIndex = 145;
            this.label15.Text = "Uzatılan Sürenin Ücreti:";
            // 
            // uCtrlRezervasyonTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dtpCikisTarihAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTarihAra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOdaAra);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtOdaAra);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.btnCikisVer);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtOdaNumarasi);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtOdaUcreti);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSureUzat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxMusteriCinsiyet);
            this.Controls.Add(this.txtMusteriTC);
            this.Controls.Add(this.txtMusteriTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGVRezerveOdalar);
            this.Name = "uCtrlRezervasyonTakip";
            this.Size = new System.Drawing.Size(1426, 703);
            this.VisibleChanged += new System.EventHandler(this.uCtrlRezervasyonTakip_VisibleChanged);
            this.Leave += new System.EventHandler(this.uCtrlRezervasyonTakip_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRezerveOdalar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVRezerveOdalar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtOdaNumarasi;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtOdaUcreti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSureUzat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxMusteriCinsiyet;
        private System.Windows.Forms.TextBox txtMusteriTC;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikisVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezerveid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaNumara;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisTarih;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOdaAra;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtOdaAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTarihAra;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihAra;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblDeneme;
        private System.Windows.Forms.Label label15;
    }
}
