using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Formlar
{
    public partial class frmKullaniciSil : Form
    {
        public frmKullaniciSil()
        {
            InitializeComponent();
        }

        private void frmKullaniciSil_Load(object sender, EventArgs e)
        {
            LoadKullanicilar(); // Kullanıcıları grid'e yükler
            gridView1.OptionsBehavior.Editable = false; // Grid düzenlenemez
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim devre dışı
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklenemez
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
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
                            Ad AS [Kullanıcı Adı],
                            Soyad AS [Soyadı],
                            TcNo AS [TC No],
                            Eposta AS [E-posta],
                            TelNo AS [Telefon No],
                            Adres AS [Adres]
                        FROM Kullanici";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table; // Grid'e veriyi bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcılar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcı adına göre filtreleme
            gridView1.ActiveFilterString = $"[Kullanıcı Adı] LIKE '%{txtKullaniciAdi.Text}%'";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            // Grid'den seçilen satırı text kutularına doldur
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow != null)
            {
                txtKullaniciAdi.Text = selectedRow["Kullanıcı Adı"].ToString();
                txtKullaniciSoyadi.Text = selectedRow["Soyadı"].ToString();
                txtTC.Text = selectedRow["TC No"].ToString();
                txtEposta.Text = selectedRow["E-posta"].ToString();
                txtTelefonNo.Text = selectedRow["Telefon No"].ToString();
                txtAdres.Text = selectedRow["Adres"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtKullaniciSoyadi.Text) || string.IsNullOrEmpty(txtTC.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin veya bilgileri eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcıyı sil
                    string deleteQuery = @"
                        DELETE FROM Kullanici
                        WHERE TcNo = @TcNo";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@TcNo", txtTC.Text.Trim());
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKullanicilar(); // Grid'i güncelle
                        ClearFields(); // Alanları temizle
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            txtKullaniciAdi.Text = string.Empty;
            txtKullaniciSoyadi.Text = string.Empty;
            txtTC.Text = string.Empty;
            txtEposta.Text = string.Empty;
            txtTelefonNo.Text = string.Empty;
            txtAdres.Text = string.Empty;
        }
    }
}
