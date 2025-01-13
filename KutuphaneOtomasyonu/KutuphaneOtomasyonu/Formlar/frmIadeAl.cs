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
    public partial class frmIadeAl : Form
    {
        public frmIadeAl()
        {
            InitializeComponent();
        }

        private void frmIadeAl_Load(object sender, EventArgs e)
        {
            LoadIadeEdilecekKitaplar();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
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
                    u.Ad AS [Kullanıcı Adı],
                    u.Soyad AS [Kullanıcı Soyadı],
                    u.TcNo AS [TC No],
                    o.OduncVermeTarihi AS [Ödünç Alma Tarihi],
                    o.SonIadeTarihi AS [Son İade Tarihi],
                    CASE 
                        WHEN GETDATE() > o.SonIadeTarihi THEN DATEDIFF(DAY, o.SonIadeTarihi, GETDATE())
                        ELSE 0
                    END AS [Gecikme Ücreti]
                FROM OduncAlinanlar o
                INNER JOIN Kitap k ON o.KitapId = k.ID
                INNER JOIN Kullanici u ON o.KullaniciId = u.ID
                WHERE o.SonIadeTarihi IS NOT NULL";

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


        private void txtKitabinAdi_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[Kitap Adı] LIKE '%{txtKitapAdi.Text}%'";
        }

        private void txtKitabinYazari_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow != null)
            {
                txtKitapAdi.Text = selectedRow["Kitap Adı"].ToString();
                txtTC.Text = selectedRow["TC No"].ToString();
                txtKullaniciAdi.Text = selectedRow["Kullanıcı Adı"].ToString(); // Kullanıcı adı doğrudan alınır
                txtKullaniciSoyadi.Text = selectedRow["Kullanıcı Soyadı"].ToString(); // Kullanıcı soyadı doğrudan alınır

                dateIade.EditValue = DateTime.Today; // Bugünün tarihi
                lblGecikmeUcreti.Text = selectedRow["Gecikme Ücreti"].ToString() + " ₺";
            }
        }


        private void btnIade_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow == null)
            {
                MessageBox.Show("Lütfen iade edilecek bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kitapAdi = selectedRow["Kitap Adı"].ToString();
            string tcNo = selectedRow["TC No"].ToString();
            decimal gecikmeUcreti = 0;

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Gecikme ücretini kontrol et
                    string gecikmeQuery = @"
                SELECT GecikmeUcreti 
                FROM OduncAlinanlar o
                INNER JOIN Kitap k ON o.KitapId = k.ID
                INNER JOIN Kullanici u ON o.KullaniciId = u.ID
                WHERE k.Ad = @KitapAdi AND u.TcNo = @TcNo";

                    SqlCommand gecikmeCommand = new SqlCommand(gecikmeQuery, connection);
                    gecikmeCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                    gecikmeCommand.Parameters.AddWithValue("@TcNo", tcNo);

                    object result = gecikmeCommand.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        gecikmeUcreti = Convert.ToDecimal(result);
                    }

                    // Gecikme ücreti varsa kullanıcıdan ödeme durumu alın
                    if (gecikmeUcreti > 0)
                    {
                        DialogResult gecikmeOnay = MessageBox.Show(
                            $"Gecikme ücreti: {gecikmeUcreti:C}. Ödeme alındı mı?",
                            "Gecikme Ücreti",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (gecikmeOnay == DialogResult.Yes)
                        {
                            string inputBorc = Microsoft.VisualBasic.Interaction.InputBox(
                                $"Ödenen miktarı giriniz. Toplam gecikme ücreti: {gecikmeUcreti:C}",
                                "Borç Ödemesi",
                                "0"
                            );

                            if (decimal.TryParse(inputBorc, out decimal odenenMiktar) && odenenMiktar >= 0)
                            {
                                if (odenenMiktar >= gecikmeUcreti)
                                {
                                    string updateUserQuery = @"
                                UPDATE Kullanici
                                SET Borc = 0, Kredi = 100
                                WHERE TcNo = @TcNo";

                                    SqlCommand updateUserCommand = new SqlCommand(updateUserQuery, connection);
                                    updateUserCommand.Parameters.AddWithValue("@TcNo", tcNo);
                                    updateUserCommand.ExecuteNonQuery();

                                    MessageBox.Show("Tüm borç ödendi. Kullanıcının borcu sıfırlandı ve kredi 100 olarak güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    decimal kalanBorc = gecikmeUcreti - odenenMiktar;
                                    string updatePartialUserQuery = @"
                                UPDATE Kullanici
                                SET Borc = @KalanBorc
                                WHERE TcNo = @TcNo";

                                    SqlCommand updatePartialCommand = new SqlCommand(updatePartialUserQuery, connection);
                                    updatePartialCommand.Parameters.AddWithValue("@KalanBorc", kalanBorc);
                                    updatePartialCommand.Parameters.AddWithValue("@TcNo", tcNo);
                                    updatePartialCommand.ExecuteNonQuery();

                                    MessageBox.Show($"Kısmi ödeme yapıldı. Kalan borç: {kalanBorc:C}.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz bir ödeme miktarı girildi. Borç değiştirilmeyecek.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gecikme ücreti alınmadı. Borç değiştirilmeyecek.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Kitabı iade et
                    string deleteQuery = @"
                DELETE FROM OduncAlinanlar
                WHERE KitapId = (SELECT ID FROM Kitap WHERE Ad = @KitapAdi)
                AND KullaniciId = (SELECT ID FROM Kullanici WHERE TcNo = @TcNo)";

                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                    deleteCommand.Parameters.AddWithValue("@TcNo", tcNo);
                    deleteCommand.ExecuteNonQuery();

                    // Kitap tablosunu güncelle
                    string updateQuery = @"
                UPDATE Kitap
                SET 
                    OduncSayisi = OduncSayisi - 1,
                    OkunmaSayisi = OkunmaSayisi + 1,
                    Durum = CASE WHEN (Adet - OduncSayisi) > 0 THEN 1 ELSE 0 END
                WHERE Ad = @KitapAdi";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                    updateCommand.ExecuteNonQuery();

                    // Kullanıcı tablosunu güncelle
                    string updateKullaniciQuery = @"
                UPDATE Kullanici
                SET 
                    OkuduguKitapSayisi = OkuduguKitapSayisi + 1,
                    OduncAldigiKitapSayisi = OduncAldigiKitapSayisi - 1
                WHERE TcNo = @TcNo";

                    SqlCommand updateKullaniciCommand = new SqlCommand(updateKullaniciQuery, connection);
                    updateKullaniciCommand.Parameters.AddWithValue("@TcNo", tcNo);
                    updateKullaniciCommand.ExecuteNonQuery();

                    MessageBox.Show($"'{kitapAdi}' başarıyla iade edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Listbox'tan kitabı sil
                    if (listBoxControl1.Items.Count > 0)
                    {
                        listBoxControl1.Items.RemoveAt(listBoxControl1.Items.Count - 1);
                    }

                    // Grid ve diğer alanları temizle
                    LoadIadeEdilecekKitaplar();
                    txtKullaniciAdi.Text = "";
                    txtKullaniciSoyadi.Text = "";
                    txtKitapAdi.Text = "";
                    txtKitapYazari.Text = "";
                    txtTC.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İade alma işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UpdateTotalGecikmeUcreti();
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

            // Farklı kullanıcı kontrolü
            foreach (var item in listBoxControl1.Items)
            {
                string mevcutKullaniciAdi = item.ToString().Split('-')[1].Trim();
                if (!mevcutKullaniciAdi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Farklı kullanıcıların kitapları aynı anda listeye eklenemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // ListBox'a ekle
            listBoxControl1.Items.Add($"{kitapAdi} - {kullaniciAdi}");

            // Kitap ve kullanıcı bilgilerini temizle
            txtKitapAdi.Text = "";
            txtKullaniciAdi.Text = "";
            UpdateTotalGecikmeUcreti();
        }

        private void UpdateTotalGecikmeUcreti()
        {
            decimal totalGecikme = 0;

            foreach (var item in listBoxControl1.Items)
            {
                string kitapAdi = item.ToString().Split('-')[0].Trim();

                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT GecikmeUcreti 
                FROM OduncAlinanlar o
                INNER JOIN Kitap k ON o.KitapId = k.ID
                WHERE k.Ad = @KitapAdi";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KitapAdi", kitapAdi);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalGecikme += Convert.ToDecimal(result);
                    }
                }
            }

            lblGecikmeUcreti.Text = $"Toplam Gecikme Ücreti: {totalGecikme:C}";
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[Kullanıcı Adı] LIKE '%{txtKullaniciAdi.Text}%'";
        }
    }

}
