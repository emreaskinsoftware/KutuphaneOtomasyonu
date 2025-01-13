namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKitapSil
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
            this.gridKitapListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkEminMisiniz = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKitapYazari = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKitapAdedi = new DevExpress.XtraEditors.TextEdit();
            this.txtKitapAdi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitapListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEminMisiniz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapYazari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdedi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKitapListesi
            // 
            this.gridKitapListesi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridKitapListesi.Location = new System.Drawing.Point(329, 55);
            this.gridKitapListesi.MainView = this.gridView1;
            this.gridKitapListesi.Margin = new System.Windows.Forms.Padding(4);
            this.gridKitapListesi.Name = "gridKitapListesi";
            this.gridKitapListesi.Size = new System.Drawing.Size(908, 300);
            this.gridKitapListesi.TabIndex = 17;
            this.gridKitapListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridKitapListesi.Click += new System.EventHandler(this.gridKitapListesi_Click);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridKitapListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // chkEminMisiniz
            // 
            this.chkEminMisiniz.Location = new System.Drawing.Point(167, 242);
            this.chkEminMisiniz.Margin = new System.Windows.Forms.Padding(4);
            this.chkEminMisiniz.Name = "chkEminMisiniz";
            this.chkEminMisiniz.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEminMisiniz.Properties.Appearance.Options.UseForeColor = true;
            this.chkEminMisiniz.Properties.Caption = "Emin misiniz ?";
            this.chkEminMisiniz.Size = new System.Drawing.Size(112, 20);
            this.chkEminMisiniz.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 93);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Kitabın Adı:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(167, 288);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 28);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(53, 146);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Kitabın Yazarı:";
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(167, 138);
            this.txtKitapYazari.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(133, 22);
            this.txtKitapYazari.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(53, 193);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Silinecek Adedi:";
            // 
            // txtKitapAdedi
            // 
            this.txtKitapAdedi.Location = new System.Drawing.Point(167, 189);
            this.txtKitapAdedi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdedi.Name = "txtKitapAdedi";
            this.txtKitapAdedi.Properties.Mask.EditMask = "n0";
            this.txtKitapAdedi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKitapAdedi.Size = new System.Drawing.Size(133, 22);
            this.txtKitapAdedi.TabIndex = 13;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(167, 90);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(133, 22);
            this.txtKitapAdi.TabIndex = 12;
            // 
            // frmKitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.depositphotos_99748964_stock_photo_books_on_the_table_in;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.gridKitapListesi);
            this.Controls.Add(this.chkEminMisiniz);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtKitapYazari);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKitapAdedi);
            this.Controls.Add(this.txtKitapAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKitapSil";
            this.Text = "frmKitapSil";
            this.Load += new System.EventHandler(this.frmKitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKitapListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEminMisiniz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapYazari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdedi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKitapListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit chkEminMisiniz;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKitapYazari;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKitapAdedi;
        private DevExpress.XtraEditors.TextEdit txtKitapAdi;
    }
}