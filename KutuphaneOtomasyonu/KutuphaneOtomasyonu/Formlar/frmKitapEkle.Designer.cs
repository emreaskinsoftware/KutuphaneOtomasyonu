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
            this.components = new System.ComponentModel.Container();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.lblKategori = new DevExpress.XtraEditors.LabelControl();
            this.lblYazar = new DevExpress.XtraEditors.LabelControl();
            this.lblAdet = new DevExpress.XtraEditors.LabelControl();
            this.btnKitapEkle = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.groupKitapEkle = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.checkBagis = new DevExpress.XtraEditors.CheckEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKitapEkle)).BeginInit();
            this.groupKitapEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBagis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(25, 55);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(54, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Kitabın Adı:";
            // 
            // lblKategori
            // 
            this.lblKategori.Location = new System.Drawing.Point(35, 151);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(44, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblYazar
            // 
            this.lblYazar.Location = new System.Drawing.Point(48, 100);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(31, 13);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblAdet
            // 
            this.lblAdet.Location = new System.Drawing.Point(52, 201);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(27, 13);
            this.lblAdet.TabIndex = 3;
            this.lblAdet.Text = "Adet:";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(92, 273);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 4;
            this.btnKitapEkle.Text = "Kitap Ekle";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(92, 52);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(92, 97);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(92, 148);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
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
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 7;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(92, 198);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 8;
            // 
            // groupKitapEkle
            // 
            this.groupKitapEkle.Controls.Add(this.dataLayoutControl1);
            this.groupKitapEkle.Controls.Add(this.checkBagis);
            this.groupKitapEkle.Controls.Add(this.pictureEdit1);
            this.groupKitapEkle.Controls.Add(this.lblAd);
            this.groupKitapEkle.Controls.Add(this.textEdit3);
            this.groupKitapEkle.Controls.Add(this.lblKategori);
            this.groupKitapEkle.Controls.Add(this.comboBoxEdit1);
            this.groupKitapEkle.Controls.Add(this.lblYazar);
            this.groupKitapEkle.Controls.Add(this.textEdit2);
            this.groupKitapEkle.Controls.Add(this.lblAdet);
            this.groupKitapEkle.Controls.Add(this.textEdit1);
            this.groupKitapEkle.Controls.Add(this.btnKitapEkle);
            this.groupKitapEkle.Location = new System.Drawing.Point(12, 12);
            this.groupKitapEkle.Name = "groupKitapEkle";
            this.groupKitapEkle.Size = new System.Drawing.Size(944, 310);
            this.groupKitapEkle.TabIndex = 9;
            this.groupKitapEkle.Text = "Kitap Ekle";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::KutuphaneOtomasyonu.Properties.Resources.KitapEkle;
            this.pictureEdit1.Location = new System.Drawing.Point(251, 23);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(242, 282);
            this.pictureEdit1.TabIndex = 9;
            // 
            // checkBagis
            // 
            this.checkBagis.Location = new System.Drawing.Point(92, 234);
            this.checkBagis.Name = "checkBagis";
            this.checkBagis.Properties.Caption = "Bağış";
            this.checkBagis.Size = new System.Drawing.Size(75, 19);
            this.checkBagis.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(590, 98);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = null;
            this.dataLayoutControl1.Size = new System.Drawing.Size(180, 120);
            this.dataLayoutControl1.TabIndex = 11;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 334);
            this.Controls.Add(this.groupKitapEkle);
            this.Name = "frmKitapEkle";
            this.Text = "KitapIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKitapEkle)).EndInit();
            this.groupKitapEkle.ResumeLayout(false);
            this.groupKitapEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBagis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.LabelControl lblKategori;
        private DevExpress.XtraEditors.LabelControl lblYazar;
        private DevExpress.XtraEditors.LabelControl lblAdet;
        private DevExpress.XtraEditors.SimpleButton btnKitapEkle;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.GroupControl groupKitapEkle;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.CheckEdit checkBagis;
    }
}