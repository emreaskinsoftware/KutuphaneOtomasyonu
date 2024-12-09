using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        //Kitap Ekleme sayfasına gidiş
        private void btnKitapEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKitapEkle frm = new Formlar.frmKitapEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKitapSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKitapSil frm = new Formlar.frmKitapSil();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKitapAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKitapAra frm = new Formlar.frmKitapAra();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOdunc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmOduncVer frm = new Formlar.frmOduncVer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnIade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmIadeAl frm = new Formlar.frmIadeAl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSureUzat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmSureUzat frm = new Formlar.frmSureUzat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKullaniciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKullaniciEkle frm = new Formlar.frmKullaniciEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKullaniciSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKullaniciSil frm = new Formlar.frmKullaniciSil();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKullaniciGüncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKullaniciGuncelle frm = new Formlar.frmKullaniciGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKullaniciDurumu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKullaniciDurumu frm = new Formlar.frmKullaniciDurumu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKullaniciAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmKullaniciAra frm = new Formlar.frmKullaniciAra();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOduncAlınanlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmEnCokOdunc frm = new Formlar.frmEnCokOdunc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBagisYapanlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmEncokBagis frm = new Formlar.frmEncokBagis();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGeciktirmeRaporu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmGecikmeRaporu frm = new Formlar.frmGecikmeRaporu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
