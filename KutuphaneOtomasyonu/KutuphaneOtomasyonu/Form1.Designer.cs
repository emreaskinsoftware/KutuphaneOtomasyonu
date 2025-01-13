namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKitapEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKitapSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnKitapAra = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdunc = new DevExpress.XtraBars.BarButtonItem();
            this.btnIade = new DevExpress.XtraBars.BarButtonItem();
            this.btnSureUzat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciGüncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciDurumu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciAra = new DevExpress.XtraBars.BarButtonItem();
            this.btnOduncAlınanlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBagisYapanlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGeciktirmeRaporu = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageAnasayfa = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageKitap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageKullanici = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnKitapEkle,
            this.btnKitapSil,
            this.btnKitapAra,
            this.btnOdunc,
            this.btnIade,
            this.btnSureUzat,
            this.barButtonItem7,
            this.btnKullaniciEkle,
            this.btnKullaniciSil,
            this.btnKullaniciGüncelle,
            this.btnKullaniciDurumu,
            this.btnKullaniciAra,
            this.btnOduncAlınanlar,
            this.btnBagisYapanlar,
            this.btnGeciktirmeRaporu,
            this.btnAnaSayfa});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageAnasayfa,
            this.ribbonPageKitap,
            this.ribbonPageKullanici,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1312, 176);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Caption = "Kitap Ekle";
            this.btnKitapEkle.Id = 1;
            this.btnKitapEkle.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Add_Book;
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKitapEkle_ItemClick);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Caption = "Kitap Sil";
            this.btnKitapSil.Id = 2;
            this.btnKitapSil.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Remove_Book;
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKitapSil_ItemClick);
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Caption = "Kitap Ara";
            this.btnKitapAra.Id = 3;
            this.btnKitapAra.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Window_Search;
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKitapAra_ItemClick);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Caption = "Ödünç Ver";
            this.btnOdunc.Id = 4;
            this.btnOdunc.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Return_Book;
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdunc_ItemClick);
            // 
            // btnIade
            // 
            this.btnIade.Caption = "İade Al";
            this.btnIade.Id = 5;
            this.btnIade.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Give;
            this.btnIade.Name = "btnIade";
            this.btnIade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIade_ItemClick);
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.Caption = "Süre uzat";
            this.btnSureUzat.Id = 6;
            this.btnSureUzat.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Add_Time;
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSureUzat_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Caption = "Kullanıcı Ekle";
            this.btnKullaniciEkle.Id = 8;
            this.btnKullaniciEkle.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Add_User_Male;
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciEkle_ItemClick);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Caption = "Kullanıcı Sil";
            this.btnKullaniciSil.Id = 9;
            this.btnKullaniciSil.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Denied;
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciSil_ItemClick);
            // 
            // btnKullaniciGüncelle
            // 
            this.btnKullaniciGüncelle.Caption = "Kullanıcı Güncelle";
            this.btnKullaniciGüncelle.Id = 10;
            this.btnKullaniciGüncelle.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Update;
            this.btnKullaniciGüncelle.Name = "btnKullaniciGüncelle";
            this.btnKullaniciGüncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciGüncelle_ItemClick);
            // 
            // btnKullaniciDurumu
            // 
            this.btnKullaniciDurumu.Caption = "Kullanıcı Durumu";
            this.btnKullaniciDurumu.Id = 11;
            this.btnKullaniciDurumu.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.User;
            this.btnKullaniciDurumu.Name = "btnKullaniciDurumu";
            this.btnKullaniciDurumu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciDurumu_ItemClick);
            // 
            // btnKullaniciAra
            // 
            this.btnKullaniciAra.Caption = "Kullanıcı Ara";
            this.btnKullaniciAra.Id = 12;
            this.btnKullaniciAra.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Find_User_Male;
            this.btnKullaniciAra.Name = "btnKullaniciAra";
            this.btnKullaniciAra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciAra_ItemClick);
            // 
            // btnOduncAlınanlar
            // 
            this.btnOduncAlınanlar.Caption = "En Çok Ödünç Alınanlar";
            this.btnOduncAlınanlar.Id = 13;
            this.btnOduncAlınanlar.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Best_Seller;
            this.btnOduncAlınanlar.Name = "btnOduncAlınanlar";
            this.btnOduncAlınanlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOduncAlınanlar_ItemClick);
            // 
            // btnBagisYapanlar
            // 
            this.btnBagisYapanlar.Caption = "En çok Bağış Yapanlar";
            this.btnBagisYapanlar.Id = 14;
            this.btnBagisYapanlar.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Donate;
            this.btnBagisYapanlar.Name = "btnBagisYapanlar";
            this.btnBagisYapanlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBagisYapanlar_ItemClick);
            // 
            // btnGeciktirmeRaporu
            // 
            this.btnGeciktirmeRaporu.Caption = "Geciktirme Raporu";
            this.btnGeciktirmeRaporu.Id = 15;
            this.btnGeciktirmeRaporu.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Health_Graph;
            this.btnGeciktirmeRaporu.Name = "btnGeciktirmeRaporu";
            this.btnGeciktirmeRaporu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGeciktirmeRaporu_ItemClick);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "AnaSayfa";
            this.btnAnaSayfa.Id = 16;
            this.btnAnaSayfa.ImageOptions.LargeImage = global::KutuphaneOtomasyonu.Properties.Resources.Home;
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // ribbonPageAnasayfa
            // 
            this.ribbonPageAnasayfa.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPageAnasayfa.Name = "ribbonPageAnasayfa";
            this.ribbonPageAnasayfa.Text = "AnaSayfa";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Ana Sayfa";
            // 
            // ribbonPageKitap
            // 
            this.ribbonPageKitap.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPageKitap.Name = "ribbonPageKitap";
            this.ribbonPageKitap.Text = "Kitap İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKitapEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKitapSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKitapAra);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kitap İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOdunc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnIade);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSureUzat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Ödünç Ve iade işlemleri";
            // 
            // ribbonPageKullanici
            // 
            this.ribbonPageKullanici.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPageKullanici.Name = "ribbonPageKullanici";
            this.ribbonPageKullanici.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKullaniciEkle);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKullaniciSil);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKullaniciGüncelle);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKullaniciDurumu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Kullanıcı İşlemler";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Rapor İşlemleri";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnOduncAlınanlar);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBagisYapanlar);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnGeciktirmeRaporu);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Raporlar";
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 629);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageKitap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnKitapEkle;
        private DevExpress.XtraBars.BarButtonItem btnKitapSil;
        private DevExpress.XtraBars.BarButtonItem btnKitapAra;
        private DevExpress.XtraBars.BarButtonItem btnOdunc;
        private DevExpress.XtraBars.BarButtonItem btnIade;
        private DevExpress.XtraBars.BarButtonItem btnSureUzat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciEkle;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciSil;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciGüncelle;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciDurumu;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciAra;
        private DevExpress.XtraBars.BarButtonItem btnOduncAlınanlar;
        private DevExpress.XtraBars.BarButtonItem btnBagisYapanlar;
        private DevExpress.XtraBars.BarButtonItem btnGeciktirmeRaporu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageKullanici;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageAnasayfa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
    }
}

