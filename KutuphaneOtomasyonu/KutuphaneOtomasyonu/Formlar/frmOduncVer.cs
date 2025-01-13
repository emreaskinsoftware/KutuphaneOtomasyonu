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
    public partial class frmOduncVer : Form
    {
        public frmOduncVer()
        {
            InitializeComponent();
        }

        private void frmOduncVer_Load(object sender, EventArgs e)
        {
            LoadBooks();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            LoadKullanicilar();
            gridView2.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView2.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;

            dtpOduncAlmaTarihi.EditValue = DateTime.Today;
            lblSonIadeTarihi.Text = DateTime.Today.AddDays(15).ToShortDateString(); // İade tarihi
        }
        // Kitap bilgilerini form alanlarına yazdırmak için bir metot
        public void SetKitapBilgileri(string kitapAdi, string kitapYazari)
        {
            txtKitapAdi.Text = kitapAdi;
            txtKitapYazari.Text = kitapYazari;
        }
        private void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    k.ID AS [KitapID],
                    k.Ad AS [Kitap Adı],
                    k.Yazar AS [Yazarı],
                    k.Kategori AS [Kategorisi],
                    k.Adet AS [Kütüphanedeki Adet],
                    (k.Adet - ISNULL(k.OduncSayisi, 0)) AS [Alınabilecek Kitap Adedi]
                FROM 
                    Kitap k";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table; // GridControl'e veriyi bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitaplar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadKullanicilar()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    ID,
                    Ad AS [Kullanıcı Adı],
                    Soyad AS [Soyadı],
                    TcNo AS [TC No]
                FROM Kullanici";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl2.DataSource = table; // İkinci grid'e kullanıcı tablosunu bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcılar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[Kitap Adı] LIKE '%{txtKitapAdi.Text}%' OR [Yazarı] LIKE '%{txtKitapAdi.Text}%'";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.Items.Count >= 3)
            {
                MessageBox.Show("Listeye en fazla 3 kitap eklenebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gridView1.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Lütfen bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow == null)
            {
                MessageBox.Show("Geçerli bir kitap seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int alinabilirAdet = int.Parse(selectedRow["Alınabilecek Kitap Adedi"].ToString());
            if (alinabilirAdet <= 0)
            {
                MessageBox.Show("Bu kitabın ödünç verilebilecek adedi yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ListBox'a ekle
            listBoxControl1.Items.Add($"{selectedRow["Kitap Adı"]} - {selectedRow["Yazarı"]}");

            // Kitap adı ve yazarı temizle
            txtKitapAdi.Text = "";
            txtKitapYazari.Text = "";
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.Items.Count == 0)
            {
                MessageBox.Show("Lütfen ödünç verilecek kitapları listeye ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tcNo = txtTC.Text.Trim();
            if (string.IsNullOrEmpty(tcNo))
            {
                MessageBox.Show("Lütfen kullanıcı TC numarasını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kullaniciId = GetKullaniciId(tcNo);

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcı borç ve kredi durumunu güncellemek için prosedür çağrısı
                    SqlCommand hesaplaBorcVeKrediCommand = new SqlCommand("UpdateKullaniciBorcVeKredi", connection);
                    hesaplaBorcVeKrediCommand.CommandType = CommandType.StoredProcedure;
                    hesaplaBorcVeKrediCommand.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                    hesaplaBorcVeKrediCommand.ExecuteNonQuery();

                    // Güncellenmiş borç ve kredi bilgilerini al
                    var (kredi, borc) = GetKullaniciBilgileri(tcNo);

                    // Kullanıcı bilgilerini kontrol et
                    if (kredi <= 0)
                    {
                        MessageBox.Show("Kullanıcının kredisi yok. Ödünç verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (borc > 0)
                    {
                        MessageBox.Show("Kullanıcının borcu var. Ödünç verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kullanıcının toplam ödünç sayısını kontrol et
                    int toplamOduncSayisi = GetToplamOduncSayisi(kullaniciId);
                    if (toplamOduncSayisi + listBoxControl1.Items.Count > 3)
                    {
                        MessageBox.Show("Kullanıcı toplamda 3'ten fazla kitap ödünç alamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kitapları ödünç verme işlemi
                    foreach (string kitap in listBoxControl1.Items)
                    {
                        var kitapBilgileri = kitap.Split('-');
                        string kitapAdi = kitapBilgileri[0].Trim();

                        // Kitap ödünç verme işlemi
                        try
                        {
                            string query = @"
                    INSERT INTO OduncAlinanlar (KitapId, KullaniciId, OduncVermeTarihi, SonIadeTarihi)
                    VALUES (@KitapId, @KullaniciId, @OduncVermeTarihi, @SonIadeTarihi)";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@KitapId", GetKitapId(kitapAdi));
                            command.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                            command.Parameters.AddWithValue("@OduncVermeTarihi", DateTime.Today);
                            command.Parameters.AddWithValue("@SonIadeTarihi", DateTime.Today.AddDays(15));
                            command.ExecuteNonQuery();

                            // Alınabilecek kitap sayısını güncelle
                            UpdateAlinabilecekKitapSayisi(GetKitapId(kitapAdi));

                            MessageBox.Show($"'{kitapAdi}' ödünç verildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // Kullanıcının ödünç aldığı kitap sayısını güncelle
                    string updateOduncSayisiQuery = @"
            UPDATE Kullanici
            SET OduncAldigiKitapSayisi = OduncAldigiKitapSayisi + @KitapSayisi
            WHERE ID = @KullaniciId";
                    SqlCommand updateOduncSayisiCommand = new SqlCommand(updateOduncSayisiQuery, connection);
                    updateOduncSayisiCommand.Parameters.AddWithValue("@KitapSayisi", listBoxControl1.Items.Count);
                    updateOduncSayisiCommand.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                    updateOduncSayisiCommand.ExecuteNonQuery();


                    // Listeyi temizle ve kitap listesini güncelle
                    listBoxControl1.Items.Clear();
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private int GetKitapId(string kitapAdi)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Kitap WHERE Ad = @Ad", connection);
                command.Parameters.AddWithValue("@Ad", kitapAdi);
                return (int)command.ExecuteScalar();
            }
        }
        private int GetKullaniciId(string tcNo)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Kullanici WHERE TcNo = @TcNo", connection);
                command.Parameters.AddWithValue("@TcNo", tcNo);
                return (int)command.ExecuteScalar();
            }
        }

        private (int Kredi, decimal Borc) GetKullaniciBilgileri(string tcNo)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Kredi, Borc FROM Kullanici WHERE TcNo = @TcNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TcNo", tcNo);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int kredi = reader["Kredi"] != DBNull.Value ? Convert.ToInt32(reader["Kredi"]) : 0;
                        decimal borc = reader["Borc"] != DBNull.Value ? Convert.ToDecimal(reader["Borc"]) : 0;
                        return (kredi, borc);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return (0, 0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı bilgileri alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (0, 0);
                }
            
            }
        }
        private void UpdateAlinabilecekKitapSayisi(int kitapId)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Kitap SET OduncSayisi = OduncSayisi + 1 WHERE ID = @KitapId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KitapId", kitapId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alınabilecek kitap sayısı güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            gridView2.ActiveFilterString = $"[Kullanıcı Adı] LIKE '%{txtKullaniciAdi.Text}%'";
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            // Seçilen satırdaki kullanıcı bilgilerini al
            var selectedRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (selectedRow != null)
            {
                txtKullaniciAdi.Text = selectedRow["Kullanıcı Adı"].ToString();
                txtKullaniciSoyadi.Text = selectedRow["Soyadı"].ToString();
                txtTC.Text = selectedRow["TC No"].ToString();
            }
        }
        private int GetToplamOduncSayisi(int kullaniciId)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT COUNT(*)
                FROM OduncAlinanlar
                WHERE KullaniciId = @KullaniciId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                    return (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Toplam ödünç kitap sayısı alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        private void btnListedenSil_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedIndex >= 0)
            {
                listBoxControl1.Items.RemoveAt(listBoxControl1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen listeden silinecek bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
