using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Formlar
{
    public partial class frmSureUzat : Form
    {
        public frmSureUzat()
        {
            InitializeComponent();
        }

        private void frmSureUzat_Load(object sender, EventArgs e)
        {
            // Gecikme ücretlerini güncelle ve grid'i yükle
            UpdateGecikmeUcreti();
            LoadIadeEdilecekKitaplar();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır

        }
        private void UpdateGecikmeUcreti()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("CalculateGecikmeUcreti", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gecikme ücretleri güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadIadeEdilecekKitaplar()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    SELECT 
                        k.Ad AS [Kitap Adı],
                        CONCAT(u.Ad, ' ', u.Soyad) AS [Kullanıcı Adı],
                        u.TcNo AS [TC No],
                        o.OduncVermeTarihi AS [Ödünç Alma Tarihi],
                        o.SonIadeTarihi AS [Son İade Tarihi],
                        o.GecikmeUcreti AS [Gecikme Ücreti]
                    FROM OduncAlinanlar o
                    INNER JOIN Kitap k ON o.KitapId = k.ID
                    INNER JOIN Kullanici u ON o.KullaniciId = u.ID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table; // Grid'e veriyi bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İade edilecek kitaplar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[Kullanıcı Adı] LIKE '%{txtKullaniciAdi.Text}%'";
        }
        private void txtKitabinAdi_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[Kitap Adı] LIKE '%{txtKitapAdi.Text}%'";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow != null)
            {
                txtKitapAdi.Text = selectedRow["Kitap Adı"].ToString();
                txtTC.Text = selectedRow["TC No"].ToString();

                string tamAd = selectedRow["Kullanıcı Adı"].ToString();
                if (!string.IsNullOrEmpty(tamAd))
                {
                    // Soyadı son kelime olarak kabul ediyoruz
                    string[] adSoyad = tamAd.Split(' ');
                    txtKullaniciSoyadi.Text = adSoyad[adSoyad.Length-1]; // Son kelime soyad

                    // Geriye kalan tüm kelimeleri ad olarak birleştir
                    txtKullaniciAdi.Text = string.Join(" ", adSoyad.Take(adSoyad.Length - 1));
                }
            }

        }

        private void btnListedenSil_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxControl1.Items.Remove(listBoxControl1.SelectedItem);
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            // Grid'den seçilen satırı al
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow == null)
            {
                MessageBox.Show("Lütfen listesine eklemek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kitapAdi = selectedRow["Kitap Adı"].ToString();
            string kullaniciAdi = selectedRow["Kullanıcı Adı"].ToString();

            // Aynı kitabın birden fazla eklenmesini engelle
            foreach (var item in listBoxControl1.Items)
            {
                if (item.ToString().Contains(kitapAdi) && item.ToString().Contains(kullaniciAdi))
                {
                    MessageBox.Show("Bu kitap zaten listede mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // ListBox'a ekle
            listBoxControl1.Items.Add($"{kitapAdi} - {kullaniciAdi}");

            // Kitap ve kullanıcı bilgilerini temizle
            txtKitapAdi.Text = "";
            txtKullaniciAdi.Text = "";
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.Items.Count == 0)
            {
                MessageBox.Show("Lütfen süre uzatılacak kitapları listeye ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtGun.Text) || !int.TryParse(txtGun.Text, out int uzatmaGun) || uzatmaGun <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir uzatma süresi girin (1-15 gün arası).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (uzatmaGun > 15)
            {
                MessageBox.Show("Süre en fazla 15 gün uzatılabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in listBoxControl1.Items)
            {
                string[] kitapBilgileri = item.ToString().Split('-');
                string kitapAdi = kitapBilgileri[0].Trim();
                string kullaniciAdi = kitapBilgileri[1].Trim();

                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // Mevcut son iade tarihini al
                        string getSonIadeTarihiQuery = @"
                SELECT SonIadeTarihi
                FROM OduncAlinanlar o
                INNER JOIN Kitap k ON o.KitapId = k.ID
                INNER JOIN Kullanici u ON o.KullaniciId = u.ID
                WHERE k.Ad = @KitapAdi AND CONCAT(u.Ad, ' ', u.Soyad) = @KullaniciAdi";

                        SqlCommand getSonIadeTarihiCommand = new SqlCommand(getSonIadeTarihiQuery, connection);
                        getSonIadeTarihiCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                        getSonIadeTarihiCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        object result = getSonIadeTarihiCommand.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show($"'{kitapAdi}' için mevcut bir ödünç alma kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        DateTime mevcutSonIadeTarihi = Convert.ToDateTime(result);

                        // Eğer son iade tarihi geçmişse, gecikme süresini hesapla ve borca ekle
                        if (mevcutSonIadeTarihi < DateTime.Today)
                        {
                            int gecikmeGun = (DateTime.Today - mevcutSonIadeTarihi).Days;

                            string updateBorcQuery = @"
                    UPDATE Kullanici
                    SET Borc = Borc + @GecikmeTutar
                    WHERE ID = (SELECT KullaniciId 
                                FROM OduncAlinanlar o
                                INNER JOIN Kitap k ON o.KitapId = k.ID
                                WHERE k.Ad = @KitapAdi AND KullaniciId = (SELECT ID FROM Kullanici WHERE CONCAT(Ad, ' ', Soyad) = @KullaniciAdi))";

                            SqlCommand updateBorcCommand = new SqlCommand(updateBorcQuery, connection);
                            updateBorcCommand.Parameters.AddWithValue("@GecikmeTutar", gecikmeGun);
                            updateBorcCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                            updateBorcCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                            updateBorcCommand.ExecuteNonQuery();
                        }

                        // Yeni son iade tarihini hesapla
                        DateTime yeniSonIadeTarihi = mevcutSonIadeTarihi > DateTime.Today
                            ? mevcutSonIadeTarihi.AddDays(uzatmaGun)
                            : DateTime.Today.AddDays(uzatmaGun);

                        // Son iade tarihini güncelle
                        string updateSonIadeTarihiQuery = @"
                UPDATE OduncAlinanlar
                SET SonIadeTarihi = @YeniSonIadeTarihi
                WHERE KitapId = (SELECT ID FROM Kitap WHERE Ad = @KitapAdi)
                AND KullaniciId = (SELECT ID FROM Kullanici WHERE CONCAT(Ad, ' ', Soyad) = @KullaniciAdi)";

                        SqlCommand updateSonIadeTarihiCommand = new SqlCommand(updateSonIadeTarihiQuery, connection);
                        updateSonIadeTarihiCommand.Parameters.AddWithValue("@YeniSonIadeTarihi", yeniSonIadeTarihi);
                        updateSonIadeTarihiCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                        updateSonIadeTarihiCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        updateSonIadeTarihiCommand.ExecuteNonQuery();

                        // Başarı mesajı
                        MessageBox.Show($"'{kitapAdi}' için süre başarıyla uzatıldı.\nYeni Son İade Tarihi: {yeniSonIadeTarihi.ToShortDateString()}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"'{kitapAdi}' için süre uzatma işlemi sırasında hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Grid'i güncelle ve text alanlarını temizle
            LoadIadeEdilecekKitaplar();
            txtGun.Text = string.Empty;
            txtKitapAdi.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtKullaniciSoyadi.Text = string.Empty;
            txtTC.Text = string.Empty;
            listBoxControl1.Items.Clear();
        }



    }
}
