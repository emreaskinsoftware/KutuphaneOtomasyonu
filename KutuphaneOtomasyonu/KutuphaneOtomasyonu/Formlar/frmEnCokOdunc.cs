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
    public partial class frmEnCokOdunc : Form
    {
        public frmEnCokOdunc()
        {
            InitializeComponent();
        }

        private void frmEnCokOdunc_Load(object sender, EventArgs e)
        {
            LoadBooks();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            LoadCategories();
        }
        private void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Kategori FROM Kitap ORDER BY Kategori";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    comboBoxKategori.Properties.Items.Clear(); // DevExpress ComboBoxEdit için
                    comboBoxKategori.Properties.Items.Add("Tüm Kategoriler"); // İlk seçenek tüm kitaplar
                    while (reader.Read())
                    {
                        comboBoxKategori.Properties.Items.Add(reader["Kategori"].ToString());
                    }
                    comboBoxKategori.SelectedIndex = 0; // Varsayılan olarak ilk seçenek seçili
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategoriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadBooks(string kategori = null)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY k.OkunmaSayisi DESC) AS [Sıra],
                    k.Ad AS [Kitap Adı],
                    k.Yazar AS [Yazar],
                    k.Kategori AS [Kategori],
                    k.OkunmaSayisi AS [Okunma Sayısı]
                FROM Kitap k";

                    if (!string.IsNullOrEmpty(kategori) && kategori != "Tüm Kategoriler")
                    {
                        query += " WHERE k.Kategori = @Kategori";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(kategori) && kategori != "Tüm Kategoriler")
                    {
                        command.Parameters.AddWithValue("@Kategori", kategori);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table; // Grid'e veriyi bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitaplar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxKategori.SelectedItem.ToString();
            LoadBooks(selectedCategory);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxKategori.SelectedItem.ToString();
            LoadBooks(selectedCategory);
        }
    }
}
