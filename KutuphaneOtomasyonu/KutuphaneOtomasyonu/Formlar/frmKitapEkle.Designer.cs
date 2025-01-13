namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKitapEkle
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
            this.txtTc = new DevExpress.XtraEditors.TextEdit();
            this.lblBagisTc = new DevExpress.XtraEditors.LabelControl();
            this.chkBagis = new DevExpress.XtraEditors.CheckEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.lblKategori = new DevExpress.XtraEditors.LabelControl();
            this.cmbKategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblYazar = new DevExpress.XtraEditors.LabelControl();
            this.txtYazar = new DevExpress.XtraEditors.TextEdit();
            this.lblAdet = new DevExpress.XtraEditors.LabelControl();
            this.txtKitapAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnKitapEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBagis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(519, 266);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.Name = "txtTc";
            this.txtTc.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtTc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTc.Size = new System.Drawing.Size(133, 22);
            this.txtTc.TabIndex = 25;
            this.txtTc.Visible = false;
            // 
            // lblBagisTc
            // 
            this.lblBagisTc.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBagisTc.Appearance.Options.UseForeColor = true;
            this.lblBagisTc.Location = new System.Drawing.Point(454, 269);
            this.lblBagisTc.Name = "lblBagisTc";
            this.lblBagisTc.Size = new System.Drawing.Size(40, 16);
            this.lblBagisTc.TabIndex = 24;
            this.lblBagisTc.Text = "TC No:";
            this.lblBagisTc.Visible = false;
            // 
            // chkBagis
            // 
            this.chkBagis.Location = new System.Drawing.Point(519, 233);
            this.chkBagis.Margin = new System.Windows.Forms.Padding(4);
            this.chkBagis.Name = "chkBagis";
            this.chkBagis.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkBagis.Properties.Appearance.Options.UseForeColor = true;
            this.chkBagis.Properties.Caption = "Bağış";
            this.chkBagis.Size = new System.Drawing.Size(100, 20);
            this.chkBagis.TabIndex = 23;
            this.chkBagis.CheckedChanged += new System.EventHandler(this.chkBagis_CheckedChanged_1);
            // 
            // lblAd
            // 
            this.lblAd.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAd.Appearance.Options.UseForeColor = true;
            this.lblAd.Location = new System.Drawing.Point(429, 13);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(65, 16);
            this.lblAd.TabIndex = 13;
            this.lblAd.Text = "Kitabın Adı:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(519, 189);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(133, 22);
            this.txtAdet.TabIndex = 21;
            // 
            // lblKategori
            // 
            this.lblKategori.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Appearance.Options.UseForeColor = true;
            this.lblKategori.Location = new System.Drawing.Point(443, 131);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(52, 16);
            this.lblKategori.TabIndex = 14;
            this.lblKategori.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Location = new System.Drawing.Point(519, 127);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKategori.Properties.Items.AddRange(new object[] {
            "Çocuk",
            "Aksiyon",
            "Polisiye",
            "Felsefe",
            "Tarih",
            "Politik",
            "Klasik",
            "Kişisel Gelişim",
            "Bilim Kurgu",
            "Fantastik",
            "Macera",
            "Edebiyat",
            "Şiir"});
            this.cmbKategori.Size = new System.Drawing.Size(133, 22);
            this.cmbKategori.TabIndex = 20;
            // 
            // lblYazar
            // 
            this.lblYazar.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYazar.Appearance.Options.UseForeColor = true;
            this.lblYazar.Location = new System.Drawing.Point(460, 68);
            this.lblYazar.Margin = new System.Windows.Forms.Padding(4);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(37, 16);
            this.lblYazar.TabIndex = 15;
            this.lblYazar.Text = "Yazar:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(519, 64);
            this.txtYazar.Margin = new System.Windows.Forms.Padding(4);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(133, 22);
            this.txtYazar.TabIndex = 19;
            // 
            // lblAdet
            // 
            this.lblAdet.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdet.Appearance.Options.UseForeColor = true;
            this.lblAdet.Location = new System.Drawing.Point(465, 192);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(31, 16);
            this.lblAdet.TabIndex = 16;
            this.lblAdet.Text = "Adet:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(519, 9);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(133, 22);
            this.txtKitapAdi.TabIndex = 18;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(519, 331);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(133, 28);
            this.btnKitapEkle.TabIndex = 17;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click_1);
            // 
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kutuphane0;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.lblBagisTc);
            this.Controls.Add(this.chkBagis);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.btnKitapEkle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKitapEkle";
            this.Text = "KitapIslemleri";
            this.Load += new System.EventHandler(this.frmKitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBagis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTc;
        private DevExpress.XtraEditors.LabelControl lblBagisTc;
        private DevExpress.XtraEditors.CheckEdit chkBagis;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.LabelControl lblKategori;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKategori;
        private DevExpress.XtraEditors.LabelControl lblYazar;
        private DevExpress.XtraEditors.TextEdit txtYazar;
        private DevExpress.XtraEditors.LabelControl lblAdet;
        private DevExpress.XtraEditors.TextEdit txtKitapAdi;
        private DevExpress.XtraEditors.SimpleButton btnKitapEkle;
    }
}