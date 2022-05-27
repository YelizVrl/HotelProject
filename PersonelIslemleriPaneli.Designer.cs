
namespace OtelRezervasyonOtomasyonu
{
    partial class uCtrlPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCtrlPersonelIslemleri));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTCPersonelAra = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTCPersonelAra = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGVPersoneller = new System.Windows.Forms.DataGridView();
            this.Personelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxPersonelCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtPersonelTC = new System.Windows.Forms.TextBox();
            this.txtPersonelTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(0, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1426, 49);
            this.panel6.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label6.Location = new System.Drawing.Point(541, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "PERSONEL BİLGİLERİ";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.btnSil.Location = new System.Drawing.Point(384, 581);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 35);
            this.btnSil.TabIndex = 135;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label9.Location = new System.Drawing.Point(1112, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 23);
            this.label9.TabIndex = 134;
            this.label9.Text = "TC Kimlik No\'ya Göre Ara";
            // 
            // btnTCPersonelAra
            // 
            this.btnTCPersonelAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnTCPersonelAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTCPersonelAra.FlatAppearance.BorderSize = 0;
            this.btnTCPersonelAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCPersonelAra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCPersonelAra.ForeColor = System.Drawing.Color.White;
            this.btnTCPersonelAra.Image = ((System.Drawing.Image)(resources.GetObject("btnTCPersonelAra.Image")));
            this.btnTCPersonelAra.Location = new System.Drawing.Point(1356, 164);
            this.btnTCPersonelAra.Name = "btnTCPersonelAra";
            this.btnTCPersonelAra.Size = new System.Drawing.Size(40, 25);
            this.btnTCPersonelAra.TabIndex = 133;
            this.btnTCPersonelAra.UseVisualStyleBackColor = false;
            this.btnTCPersonelAra.Click += new System.EventHandler(this.btnTCPersonelAra_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel5.Location = new System.Drawing.Point(1117, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 132;
            // 
            // txtTCPersonelAra
            // 
            this.txtTCPersonelAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtTCPersonelAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTCPersonelAra.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCPersonelAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTCPersonelAra.Location = new System.Drawing.Point(1116, 163);
            this.txtTCPersonelAra.MaxLength = 11;
            this.txtTCPersonelAra.Multiline = true;
            this.txtTCPersonelAra.Name = "txtTCPersonelAra";
            this.txtTCPersonelAra.Size = new System.Drawing.Size(238, 25);
            this.txtTCPersonelAra.TabIndex = 131;
            this.txtTCPersonelAra.TextChanged += new System.EventHandler(this.txtTCPersonelAra_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.btnKaydet.Location = new System.Drawing.Point(204, 581);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 35);
            this.btnKaydet.TabIndex = 130;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGVPersoneller
            // 
            this.dataGVPersoneller.AllowUserToAddRows = false;
            this.dataGVPersoneller.AllowUserToDeleteRows = false;
            this.dataGVPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVPersoneller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dataGVPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personelid,
            this.PersonelAdSoyad,
            this.PersonelTC,
            this.PersonelCinsiyet,
            this.PersonelTel});
            this.dataGVPersoneller.Location = new System.Drawing.Point(709, 194);
            this.dataGVPersoneller.Name = "dataGVPersoneller";
            this.dataGVPersoneller.ReadOnly = true;
            this.dataGVPersoneller.RowHeadersWidth = 51;
            this.dataGVPersoneller.RowTemplate.Height = 24;
            this.dataGVPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVPersoneller.Size = new System.Drawing.Size(687, 451);
            this.dataGVPersoneller.TabIndex = 129;
            this.dataGVPersoneller.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVPersoneller_CellMouseClick);
            // 
            // Personelid
            // 
            this.Personelid.DataPropertyName = "Personelid";
            this.Personelid.HeaderText = "ID";
            this.Personelid.MinimumWidth = 6;
            this.Personelid.Name = "Personelid";
            this.Personelid.ReadOnly = true;
            // 
            // PersonelAdSoyad
            // 
            this.PersonelAdSoyad.DataPropertyName = "PersonelAdSoyad";
            this.PersonelAdSoyad.HeaderText = "Ad Soyad";
            this.PersonelAdSoyad.MinimumWidth = 6;
            this.PersonelAdSoyad.Name = "PersonelAdSoyad";
            this.PersonelAdSoyad.ReadOnly = true;
            // 
            // PersonelTC
            // 
            this.PersonelTC.DataPropertyName = "PersonelTC";
            this.PersonelTC.HeaderText = "TC Kimlik No";
            this.PersonelTC.MinimumWidth = 6;
            this.PersonelTC.Name = "PersonelTC";
            this.PersonelTC.ReadOnly = true;
            // 
            // PersonelCinsiyet
            // 
            this.PersonelCinsiyet.DataPropertyName = "PersonelCinsiyet";
            this.PersonelCinsiyet.HeaderText = "Cinsiyet";
            this.PersonelCinsiyet.MinimumWidth = 6;
            this.PersonelCinsiyet.Name = "PersonelCinsiyet";
            this.PersonelCinsiyet.ReadOnly = true;
            // 
            // PersonelTel
            // 
            this.PersonelTel.DataPropertyName = "PersonelTel";
            this.PersonelTel.HeaderText = "Telefon";
            this.PersonelTel.MinimumWidth = 6;
            this.PersonelTel.Name = "PersonelTel";
            this.PersonelTel.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel4.Location = new System.Drawing.Point(401, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 2);
            this.panel4.TabIndex = 128;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtKullaniciAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullaniciAd.Location = new System.Drawing.Point(401, 224);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(267, 25);
            this.txtKullaniciAd.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(397, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 126;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel3.Location = new System.Drawing.Point(33, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 2);
            this.panel3.TabIndex = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.Location = new System.Drawing.Point(33, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 2);
            this.panel2.TabIndex = 124;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel1.Location = new System.Drawing.Point(33, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 2);
            this.panel1.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(29, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 122;
            this.label5.Text = "Cinsiyeti";
            // 
            // cboxPersonelCinsiyet
            // 
            this.cboxPersonelCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.cboxPersonelCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPersonelCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxPersonelCinsiyet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxPersonelCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cboxPersonelCinsiyet.FormattingEnabled = true;
            this.cboxPersonelCinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.cboxPersonelCinsiyet.Location = new System.Drawing.Point(33, 398);
            this.cboxPersonelCinsiyet.Name = "cboxPersonelCinsiyet";
            this.cboxPersonelCinsiyet.Size = new System.Drawing.Size(322, 31);
            this.cboxPersonelCinsiyet.TabIndex = 121;
            // 
            // txtPersonelTC
            // 
            this.txtPersonelTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtPersonelTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelTC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPersonelTC.Location = new System.Drawing.Point(33, 309);
            this.txtPersonelTC.MaxLength = 11;
            this.txtPersonelTC.Name = "txtPersonelTC";
            this.txtPersonelTC.Size = new System.Drawing.Size(322, 25);
            this.txtPersonelTC.TabIndex = 120;
            // 
            // txtPersonelTel
            // 
            this.txtPersonelTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtPersonelTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPersonelTel.Location = new System.Drawing.Point(33, 492);
            this.txtPersonelTel.MaxLength = 11;
            this.txtPersonelTel.Name = "txtPersonelTel";
            this.txtPersonelTel.Size = new System.Drawing.Size(322, 25);
            this.txtPersonelTel.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(29, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "TC Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(29, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 117;
            this.label2.Text = "Telefon Numarası";
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtPersonelAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelAdSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(33, 222);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(322, 25);
            this.txtPersonelAdSoyad.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(29, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 115;
            this.label1.Text = "Adı Soyadı";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel7.Location = new System.Drawing.Point(401, 338);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 2);
            this.panel7.TabIndex = 138;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifre.Location = new System.Drawing.Point(401, 312);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(267, 25);
            this.txtSifre.TabIndex = 137;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label7.Location = new System.Drawing.Point(397, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 136;
            this.label7.Text = "Şifre";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel8.Location = new System.Drawing.Point(401, 430);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(267, 2);
            this.panel8.TabIndex = 141;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifreTekrar.Location = new System.Drawing.Point(401, 404);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(267, 25);
            this.txtSifreTekrar.TabIndex = 140;
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label8.Location = new System.Drawing.Point(397, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 139;
            this.label8.Text = "Şifre Tekrar";
            // 
            // uCtrlPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTCPersonelAra);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtTCPersonelAra);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGVPersoneller);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxPersonelCinsiyet);
            this.Controls.Add(this.txtPersonelTC);
            this.Controls.Add(this.txtPersonelTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Name = "uCtrlPersonelIslemleri";
            this.Size = new System.Drawing.Size(1426, 703);
            this.VisibleChanged += new System.EventHandler(this.uCtrlPersonelIslemleri_VisibleChanged);
            this.Leave += new System.EventHandler(this.uCtrlPersonelIslemleri_Leave);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTCPersonelAra;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTCPersonelAra;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGVPersoneller;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxPersonelCinsiyet;
        private System.Windows.Forms.TextBox txtPersonelTC;
        private System.Windows.Forms.TextBox txtPersonelTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelTel;
    }
}
