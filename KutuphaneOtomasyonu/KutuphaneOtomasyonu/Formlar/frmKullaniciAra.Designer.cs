namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKullaniciAra
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
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.txtTelNo = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblTelNo = new DevExpress.XtraEditors.LabelControl();
            this.lblTCNo = new DevExpress.XtraEditors.LabelControl();
            this.lblEposta = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanicinSoyadi = new DevExpress.XtraEditors.LabelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanicininSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(121, 198);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "Ara";
            // 
            // txtKullanicininSoyadi
            // 
            this.txtKullanicininSoyadi.Location = new System.Drawing.Point(121, 48);
            this.txtKullanicininSoyadi.Name = "txtKullanicininSoyadi";
            this.txtKullanicininSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtKullanicininSoyadi.TabIndex = 25;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(121, 86);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 20);
            this.txtTCNo.TabIndex = 24;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(121, 124);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 20);
            this.txtEposta.TabIndex = 23;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(121, 162);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 22;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(121, 10);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 20;
            // 
            // lblTelNo
            // 
            this.lblTelNo.Location = new System.Drawing.Point(59, 165);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(56, 13);
            this.lblTelNo.TabIndex = 19;
            this.lblTelNo.Text = "Telefon No:";
            // 
            // lblTCNo
            // 
            this.lblTCNo.Location = new System.Drawing.Point(75, 89);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(33, 13);
            this.lblTCNo.TabIndex = 18;
            this.lblTCNo.Text = "TC No:";
            // 
            // lblEposta
            // 
            this.lblEposta.Location = new System.Drawing.Point(75, 127);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(40, 13);
            this.lblEposta.TabIndex = 17;
            this.lblEposta.Text = "E posta:";
            // 
            // lblKullanicinSoyadi
            // 
            this.lblKullanicinSoyadi.Location = new System.Drawing.Point(17, 51);
            this.lblKullanicinSoyadi.Name = "lblKullanicinSoyadi";
            this.lblKullanicinSoyadi.Size = new System.Drawing.Size(98, 13);
            this.lblKullanicinSoyadi.TabIndex = 15;
            this.lblKullanicinSoyadi.Text = "Kullanınıcının Soyadı:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Location = new System.Drawing.Point(42, 13);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(73, 13);
            this.lblKullaniciAdi.TabIndex = 14;
            this.lblKullaniciAdi.Text = "Kullanıcının Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(227, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(470, 209);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmKullaniciAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 334);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKullanicininSoyadi);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblKullanicinSoyadi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "frmKullaniciAra";
            this.Text = "frmKullaniciAra";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanicininSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.TextEdit txtTelNo;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblTelNo;
        private DevExpress.XtraEditors.LabelControl lblTCNo;
        private DevExpress.XtraEditors.LabelControl lblEposta;
        private DevExpress.XtraEditors.LabelControl lblKullanicinSoyadi;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}