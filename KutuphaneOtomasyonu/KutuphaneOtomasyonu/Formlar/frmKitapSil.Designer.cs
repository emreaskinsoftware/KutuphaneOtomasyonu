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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKitabinAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.txtKitabinYazari = new DevExpress.XtraEditors.TextEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.gridKitapListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitabinAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitabinYazari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitapListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitabın Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kitabın Yazarı:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Kitabın Adedi:";
            // 
            // txtKitabinAdi
            // 
            this.txtKitabinAdi.Location = new System.Drawing.Point(121, 51);
            this.txtKitabinAdi.Name = "txtKitabinAdi";
            this.txtKitabinAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitabinAdi.TabIndex = 3;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(121, 132);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Properties.Mask.EditMask = "n0";
            this.txtAdet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 4;
            // 
            // txtKitabinYazari
            // 
            this.txtKitabinYazari.Location = new System.Drawing.Point(121, 90);
            this.txtKitabinYazari.Name = "txtKitabinYazari";
            this.txtKitabinYazari.Size = new System.Drawing.Size(100, 20);
            this.txtKitabinYazari.TabIndex = 5;
            this.txtKitabinYazari.EditValueChanged += new System.EventHandler(this.txtKitabinYazari_EditValueChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(121, 212);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(121, 175);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Emin misiniz ?";
            this.checkEdit1.Size = new System.Drawing.Size(84, 19);
            this.checkEdit1.TabIndex = 7;
            // 
            // gridKitapListesi
            // 
            this.gridKitapListesi.Location = new System.Drawing.Point(242, 23);
            this.gridKitapListesi.MainView = this.gridView1;
            this.gridKitapListesi.Name = "gridKitapListesi";
            this.gridKitapListesi.Size = new System.Drawing.Size(681, 244);
            this.gridKitapListesi.TabIndex = 8;
            this.gridKitapListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridKitapListesi;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridKitapListesi);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKitabinYazari);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAdet);
            this.groupControl1.Controls.Add(this.txtKitabinAdi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(952, 299);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Kitap Sil";
            // 
            // frmKitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 334);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKitapSil";
            this.Text = "frmKitapSil";
            ((System.ComponentModel.ISupportInitialize)(this.txtKitabinAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitabinYazari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitapListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKitabinAdi;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.TextEdit txtKitabinYazari;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraGrid.GridControl gridKitapListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}