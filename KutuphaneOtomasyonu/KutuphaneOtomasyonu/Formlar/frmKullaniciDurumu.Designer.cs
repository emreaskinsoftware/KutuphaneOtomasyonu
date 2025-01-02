namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKullaniciDurumu
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
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullanicininSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtTCNo = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblTCNo = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanicinSoyadi = new DevExpress.XtraEditors.LabelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanicininSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(116, 119);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "Ara";
            // 
            // txtKullanicininSoyadi
            // 
            this.txtKullanicininSoyadi.Location = new System.Drawing.Point(116, 43);
            this.txtKullanicininSoyadi.Name = "txtKullanicininSoyadi";
            this.txtKullanicininSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtKullanicininSoyadi.TabIndex = 25;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(116, 81);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 20);
            this.txtTCNo.TabIndex = 24;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(116, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 20;
            // 
            // lblTCNo
            // 
            this.lblTCNo.Location = new System.Drawing.Point(70, 84);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(33, 13);
            this.lblTCNo.TabIndex = 18;
            this.lblTCNo.Text = "TC No:";
            // 
            // lblKullanicinSoyadi
            // 
            this.lblKullanicinSoyadi.Location = new System.Drawing.Point(12, 46);
            this.lblKullanicinSoyadi.Name = "lblKullanicinSoyadi";
            this.lblKullanicinSoyadi.Size = new System.Drawing.Size(98, 13);
            this.lblKullanicinSoyadi.TabIndex = 15;
            this.lblKullanicinSoyadi.Text = "Kullanınıcının Soyadı:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Location = new System.Drawing.Point(37, 8);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(73, 13);
            this.lblKullaniciAdi.TabIndex = 14;
            this.lblKullaniciAdi.Text = "Kullanıcının Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(234, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(669, 288);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmKullaniciDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 334);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKullanicininSoyadi);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblKullanicinSoyadi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "frmKullaniciDurumu";
            this.Text = "frmKullaniciDurumu";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanicininSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtKullanicininSoyadi;
        private DevExpress.XtraEditors.TextEdit txtTCNo;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblTCNo;
        private DevExpress.XtraEditors.LabelControl lblKullanicinSoyadi;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}