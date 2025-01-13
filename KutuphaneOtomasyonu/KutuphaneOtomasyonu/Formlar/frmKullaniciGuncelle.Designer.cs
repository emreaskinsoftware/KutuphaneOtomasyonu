namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKullaniciGuncelle
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
            this.btnTelGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtTCNo = new DevExpress.XtraEditors.TextEdit();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.txtTelNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.lblTelNo = new DevExpress.XtraEditors.LabelControl();
            this.lblTCNo = new DevExpress.XtraEditors.LabelControl();
            this.lblEposta = new DevExpress.XtraEditors.LabelControl();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdresGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEpostaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTelGuncelle
            // 
            this.btnTelGuncelle.Location = new System.Drawing.Point(814, 157);
            this.btnTelGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelGuncelle.Name = "btnTelGuncelle";
            this.btnTelGuncelle.Size = new System.Drawing.Size(73, 28);
            this.btnTelGuncelle.TabIndex = 27;
            this.btnTelGuncelle.Text = "Güncelle";
            this.btnTelGuncelle.Click += new System.EventHandler(this.btnTelGuncelle_Click);
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(92, 10);
            this.txtTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(478, 22);
            this.txtTCNo.TabIndex = 24;
            this.txtTCNo.TextChanged += new System.EventHandler(this.txtTCNo_TextChanged);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(673, 119);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(133, 22);
            this.txtEposta.TabIndex = 23;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(673, 165);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Properties.Mask.EditMask = "05\\d?\\d? \\d\\d\\d \\d\\d\\d\\d";
            this.txtTelNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelNo.Size = new System.Drawing.Size(133, 22);
            this.txtTelNo.TabIndex = 22;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(673, 212);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(133, 22);
            this.txtAdres.TabIndex = 21;
            // 
            // lblTelNo
            // 
            this.lblTelNo.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelNo.Appearance.Options.UseForeColor = true;
            this.lblTelNo.Location = new System.Drawing.Point(591, 169);
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
            this.lblTCNo.Location = new System.Drawing.Point(37, 13);
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
            this.lblEposta.Location = new System.Drawing.Point(612, 122);
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
            this.lblAdres.Location = new System.Drawing.Point(623, 216);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(38, 16);
            this.lblAdres.TabIndex = 16;
            this.lblAdres.Text = "Adres:";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(37, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(533, 361);
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
            // btnAdresGuncelle
            // 
            this.btnAdresGuncelle.Location = new System.Drawing.Point(814, 209);
            this.btnAdresGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdresGuncelle.Name = "btnAdresGuncelle";
            this.btnAdresGuncelle.Size = new System.Drawing.Size(73, 28);
            this.btnAdresGuncelle.TabIndex = 29;
            this.btnAdresGuncelle.Text = "Güncelle";
            this.btnAdresGuncelle.Click += new System.EventHandler(this.btnAdresGuncelle_Click);
            // 
            // btnEpostaGuncelle
            // 
            this.btnEpostaGuncelle.Location = new System.Drawing.Point(814, 113);
            this.btnEpostaGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEpostaGuncelle.Name = "btnEpostaGuncelle";
            this.btnEpostaGuncelle.Size = new System.Drawing.Size(73, 28);
            this.btnEpostaGuncelle.TabIndex = 30;
            this.btnEpostaGuncelle.Text = "Güncelle";
            this.btnEpostaGuncelle.Click += new System.EventHandler(this.btnEpostaGuncelle_Click);
            // 
            // frmKullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kutuphaneler_baslangic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.btnEpostaGuncelle);
            this.Controls.Add(this.btnAdresGuncelle);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnTelGuncelle);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblAdres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullaniciGuncelle";
            this.Text = "frmKullaniciGuncelle";
            this.Load += new System.EventHandler(this.frmKullaniciGuncelle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTelGuncelle;
        private DevExpress.XtraEditors.TextEdit txtTCNo;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.TextEdit txtTelNo;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.LabelControl lblTelNo;
        private DevExpress.XtraEditors.LabelControl lblTCNo;
        private DevExpress.XtraEditors.LabelControl lblEposta;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAdresGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEpostaGuncelle;
    }
}