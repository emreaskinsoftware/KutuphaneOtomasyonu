namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKullaniciSil
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.checkDogru = new DevExpress.XtraEditors.CheckEdit();
            this.txtKullaniciSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefonNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblTelNo = new DevExpress.XtraEditors.LabelControl();
            this.lblTCNo = new DevExpress.XtraEditors.LabelControl();
            this.lblEposta = new DevExpress.XtraEditors.LabelControl();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanicinSoyadi = new DevExpress.XtraEditors.LabelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.checkDogru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(243, 363);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 28);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // checkDogru
            // 
            this.checkDogru.Location = new System.Drawing.Point(243, 309);
            this.checkDogru.Margin = new System.Windows.Forms.Padding(4);
            this.checkDogru.Name = "checkDogru";
            this.checkDogru.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkDogru.Properties.Appearance.Options.UseForeColor = true;
            this.checkDogru.Properties.Caption = "Bilgiler Doğru";
            this.checkDogru.Size = new System.Drawing.Size(133, 20);
            this.checkDogru.TabIndex = 26;
            // 
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(243, 73);
            this.txtKullaniciSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(133, 22);
            this.txtKullaniciSoyadi.TabIndex = 25;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(243, 120);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTC.Size = new System.Drawing.Size(133, 22);
            this.txtTC.TabIndex = 24;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(243, 167);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(133, 22);
            this.txtEposta.TabIndex = 23;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(243, 214);
            this.txtTelefonNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Properties.Mask.EditMask = "05\\d?\\d? \\d\\d\\d \\d\\d\\d\\d";
            this.txtTelefonNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefonNo.Size = new System.Drawing.Size(133, 22);
            this.txtTelefonNo.TabIndex = 22;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(243, 261);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(133, 22);
            this.txtAdres.TabIndex = 21;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(243, 27);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(133, 22);
            this.txtKullaniciAdi.TabIndex = 20;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // lblTelNo
            // 
            this.lblTelNo.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelNo.Appearance.Options.UseForeColor = true;
            this.lblTelNo.Location = new System.Drawing.Point(161, 217);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(67, 16);
            this.lblTelNo.TabIndex = 19;
            this.lblTelNo.Text = "Telefon No:";
            // 
            // lblTCNo
            // 
            this.lblTCNo.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTCNo.Appearance.Options.UseForeColor = true;
            this.lblTCNo.Location = new System.Drawing.Point(182, 124);
            this.lblTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(40, 16);
            this.lblTCNo.TabIndex = 18;
            this.lblTCNo.Text = "TC No:";
            // 
            // lblEposta
            // 
            this.lblEposta.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEposta.Appearance.Options.UseForeColor = true;
            this.lblEposta.Location = new System.Drawing.Point(182, 171);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(4);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(47, 16);
            this.lblEposta.TabIndex = 17;
            this.lblEposta.Text = "E posta:";
            // 
            // lblAdres
            // 
            this.lblAdres.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdres.Appearance.Options.UseForeColor = true;
            this.lblAdres.Location = new System.Drawing.Point(193, 264);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(38, 16);
            this.lblAdres.TabIndex = 16;
            this.lblAdres.Text = "Adres:";
            // 
            // lblKullanicinSoyadi
            // 
            this.lblKullanicinSoyadi.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullanicinSoyadi.Appearance.Options.UseForeColor = true;
            this.lblKullanicinSoyadi.Location = new System.Drawing.Point(105, 77);
            this.lblKullanicinSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.lblKullanicinSoyadi.Name = "lblKullanicinSoyadi";
            this.lblKullanicinSoyadi.Size = new System.Drawing.Size(120, 16);
            this.lblKullanicinSoyadi.TabIndex = 15;
            this.lblKullanicinSoyadi.Text = "Kullanınıcının Soyadı:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullaniciAdi.Appearance.Options.UseForeColor = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(138, 30);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(90, 16);
            this.lblKullaniciAdi.TabIndex = 14;
            this.lblKullaniciAdi.Text = "Kullanıcının Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(406, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(609, 369);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmKullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.sayilarla_boyama_seti_sihirli_kutuphan_e895b_;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.checkDogru);
            this.Controls.Add(this.txtKullaniciSoyadi);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblKullanicinSoyadi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullaniciSil";
            this.Text = "frmKullaniciSil";
            this.Load += new System.EventHandler(this.frmKullaniciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkDogru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.CheckEdit checkDogru;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSoyadi;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.TextEdit txtTelefonNo;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblTelNo;
        private DevExpress.XtraEditors.LabelControl lblTCNo;
        private DevExpress.XtraEditors.LabelControl lblEposta;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraEditors.LabelControl lblKullanicinSoyadi;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}