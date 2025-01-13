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
            this.txtTCNo = new DevExpress.XtraEditors.TextEdit();
            this.lblTCNo = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(216, 8);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(133, 24);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "Ara";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(75, 10);
            this.txtTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(133, 22);
            this.txtTCNo.TabIndex = 24;
            this.txtTCNo.TextChanged += new System.EventHandler(this.txtTCNo_TextChanged);
            // 
            // lblTCNo
            // 
            this.lblTCNo.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTCNo.Appearance.Options.UseForeColor = true;
            this.lblTCNo.Location = new System.Drawing.Point(13, 13);
            this.lblTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(40, 16);
            this.lblTCNo.TabIndex = 18;
            this.lblTCNo.Text = "TC No:";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(13, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(970, 317);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmKullaniciDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.lblTCNo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullaniciDurumu";
            this.Text = "frmKullaniciDurumu";
            this.Load += new System.EventHandler(this.frmKullaniciDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtTCNo;
        private DevExpress.XtraEditors.LabelControl lblTCNo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}