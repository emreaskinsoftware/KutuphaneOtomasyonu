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
            this.txtKitabınAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitabınAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitabinAdi
            // 
            this.lblKitabinAdi.Location = new System.Drawing.Point(12, 12);
            this.lblKitabinAdi.Name = "lblKitabinAdi";
            this.lblKitabinAdi.Size = new System.Drawing.Size(54, 13);
            this.lblKitabinAdi.TabIndex = 0;
            this.lblKitabinAdi.Text = "Kitabın Adı:";
            // 
            // txtKitabınAdi
            // 
            this.txtKitabınAdi.Location = new System.Drawing.Point(97, 9);
            this.txtKitabınAdi.Name = "txtKitabınAdi";
            this.txtKitabınAdi.Size = new System.Drawing.Size(778, 20);
            this.txtKitabınAdi.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(881, 7);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // gridListe
            // 
            this.gridListe.Location = new System.Drawing.Point(97, 35);
            this.gridListe.MainView = this.gridView1;
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(778, 287);
            this.gridListe.TabIndex = 3;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridListe;
            this.gridView1.Name = "gridView1";
            // 
            // frmKitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 334);
            this.Controls.Add(this.gridListe);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKitabınAdi);
            this.Controls.Add(this.lblKitabinAdi);
            this.Name = "frmKitapAra";
            this.Text = "frmKitapAra";
            ((System.ComponentModel.ISupportInitialize)(this.txtKitabınAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblKitabinAdi;
        private DevExpress.XtraEditors.TextEdit txtKitabınAdi;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}