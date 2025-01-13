namespace KutuphaneOtomasyonu.Formlar
{
    partial class frmKitapAra
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
            this.lblKitabinAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtKitapAra = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOduncVer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitabinAdi
            // 
            this.lblKitabinAdi.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKitabinAdi.Appearance.Options.UseForeColor = true;
            this.lblKitabinAdi.Location = new System.Drawing.Point(35, 14);
            this.lblKitabinAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblKitabinAdi.Name = "lblKitabinAdi";
            this.lblKitabinAdi.Size = new System.Drawing.Size(65, 16);
            this.lblKitabinAdi.TabIndex = 0;
            this.lblKitabinAdi.Text = "Kitabın Adı:";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(129, 11);
            this.txtKitapAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(1037, 22);
            this.txtKitapAra.TabIndex = 1;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitabınAdi_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(1175, 9);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // gridListe
            // 
            this.gridListe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridListe.Location = new System.Drawing.Point(129, 45);
            this.gridListe.MainView = this.gridView1;
            this.gridListe.Margin = new System.Windows.Forms.Padding(4);
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(1146, 353);
            this.gridListe.TabIndex = 3;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(16, 149);
            this.btnOduncVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(105, 28);
            this.btnOduncVer.TabIndex = 4;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmKitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources._128427;
            this.ClientSize = new System.Drawing.Size(1291, 411);
            this.Controls.Add(this.btnOduncVer);
            this.Controls.Add(this.gridListe);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.lblKitabinAdi);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKitapAra";
            this.Text = "frmKitapAra";
            this.Load += new System.EventHandler(this.frmKitapAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblKitabinAdi;
        private DevExpress.XtraEditors.TextEdit txtKitapAra;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnOduncVer;
    }
}