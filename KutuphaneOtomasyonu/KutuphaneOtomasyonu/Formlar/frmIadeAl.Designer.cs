namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmIadeAl
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
            this.lblGecikmeUcreti = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateIade = new DevExpress.XtraEditors.DateEdit();
            this.txtKitapAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKitapYazari = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnIade = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnListedenSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnListeyeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateIade.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapYazari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGecikmeUcreti
            // 
            this.lblGecikmeUcreti.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGecikmeUcreti.Appearance.Options.UseForeColor = true;
            this.lblGecikmeUcreti.Location = new System.Drawing.Point(168, 334);
            this.lblGecikmeUcreti.Margin = new System.Windows.Forms.Padding(4);
            this.lblGecikmeUcreti.Name = "lblGecikmeUcreti";
            this.lblGecikmeUcreti.Size = new System.Drawing.Size(7, 16);
            this.lblGecikmeUcreti.TabIndex = 29;
            this.lblGecikmeUcreti.Text = "0";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(33, 334);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 16);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "Gecikme Ücreti:";
            // 
            // dateIade
            // 
            this.dateIade.EditValue = null;
            this.dateIade.Location = new System.Drawing.Point(168, 278);
            this.dateIade.Margin = new System.Windows.Forms.Padding(4);
            this.dateIade.Name = "dateIade";
            this.dateIade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIade.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIade.Size = new System.Drawing.Size(133, 22);
            this.dateIade.TabIndex = 27;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(168, 11);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(133, 22);
            this.txtKitapAdi.TabIndex = 26;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtKitabinAdi_TextChanged);
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(168, 62);
            this.txtKitapYazari.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(133, 22);
            this.txtKitapYazari.TabIndex = 25;
            this.txtKitapYazari.TextChanged += new System.EventHandler(this.txtKitabinYazari_TextChanged);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(168, 111);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(133, 22);
            this.txtKullaniciAdi.TabIndex = 24;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(168, 165);
            this.txtKullaniciSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(133, 22);
            this.txtKullaniciSoyadi.TabIndex = 23;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(168, 222);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(133, 22);
            this.txtTC.TabIndex = 22;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(60, 282);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 16);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "İade Tarihi:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 169);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(110, 16);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Kullanıcının Soyadı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(88, 225);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 16);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "TC No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(53, 114);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 16);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Kullanıcı Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 16);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Kitabın Yazarı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Kitabın Adı:";
            // 
            // btnIade
            // 
            this.btnIade.Location = new System.Drawing.Point(872, 371);
            this.btnIade.Margin = new System.Windows.Forms.Padding(4);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(394, 28);
            this.btnIade.TabIndex = 31;
            this.btnIade.Text = "İade Al";
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(475, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(815, 335);
            this.gridControl1.TabIndex = 30;
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
            // btnListedenSil
            // 
            this.btnListedenSil.Location = new System.Drawing.Point(355, 369);
            this.btnListedenSil.Name = "btnListedenSil";
            this.btnListedenSil.Size = new System.Drawing.Size(113, 29);
            this.btnListedenSil.TabIndex = 37;
            this.btnListedenSil.Text = "Listeden sil";
            this.btnListedenSil.Click += new System.EventHandler(this.btnListedenSil_Click);
            // 
            // btnListeyeEkle
            // 
            this.btnListeyeEkle.Location = new System.Drawing.Point(475, 369);
            this.btnListeyeEkle.Name = "btnListeyeEkle";
            this.btnListeyeEkle.Size = new System.Drawing.Size(94, 29);
            this.btnListeyeEkle.TabIndex = 35;
            this.btnListeyeEkle.Text = "Listeye Ekle";
            this.btnListeyeEkle.Click += new System.EventHandler(this.btnListeyeEkle_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(355, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(113, 338);
            this.listBoxControl1.TabIndex = 34;
            // 
            // frmIadeAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.cikartmalar_kitaplar_kutuphane_oda_jpg;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.btnListedenSil);
            this.Controls.Add(this.btnListeyeEkle);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblGecikmeUcreti);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dateIade);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapYazari);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtKullaniciSoyadi);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIadeAl";
            this.Text = "frmIadeAl";
            this.Load += new System.EventHandler(this.frmIadeAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateIade.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapYazari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblGecikmeUcreti;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dateIade;
        private DevExpress.XtraEditors.TextEdit txtKitapAdi;
        private DevExpress.XtraEditors.TextEdit txtKitapYazari;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSoyadi;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIade;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnListedenSil;
        private DevExpress.XtraEditors.SimpleButton btnListeyeEkle;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}