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
    public partial class frmKitapSil : Form
    {
        public frmKitapSil()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtKitabinYazari_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmKitapSil_Load(object sender, EventArgs e)
        {
            LoadBooks();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır

        }
        private void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, Ad, Yazar, Adet FROM Kitap";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridKitapListesi.DataSource = table; // GridControl için kaynak
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridKitapListesi_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                var selectedRow = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
                if (selectedRow != null)
                {
                    txtKitapAdi.Text = selectedRow["Ad"].ToString();
                    txtKitapYazari.Text = selectedRow["Yazar"].ToString();
                    txtKitapAdedi.Text = selectedRow["Adet"].ToString();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Emin misiniz kontrolü
            if (!chkEminMisiniz.Checked)
            {
                MessageBox.Show("Lütfen silmek için 'Emin misiniz?' kutusunu işaretleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Form alanlarından değerleri al
            string kitapAdi = txtKitapAdi.Text.Trim();
            string yazar = txtKitapYazari.Text.Trim();
            int silinecekAdet = 0;

            if (!int.TryParse(txtKitapAdedi.Text.Trim(), out silinecekAdet) || silinecekAdet <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir silme adedi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Grid'den seçili satır kontrolü
            var selectedRow = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mevcutAdet = int.Parse(selectedRow["Adet"].ToString());
            int kitapId = int.Parse(selectedRow["ID"].ToString());

            // Silme kontrolü
            if (silinecekAdet > mevcutAdet)
            {
                MessageBox.Show($"Silme adedi mevcut adetten fazla olamaz. Mevcut adet: {mevcutAdet}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı işlemi
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    if (silinecekAdet == mevcutAdet)
                    {
                        // Eğer tüm adet siliniyorsa, kitabı tamamen sil
                        string deleteQuery = "DELETE FROM Kitap WHERE ID = @ID";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", kitapId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Kitap tamamen silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Aksi halde sadece adet azalt
                        string updateQuery = "UPDATE Kitap SET Adet = Adet - @SilAdet WHERE ID = @ID";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@SilAdet", silinecekAdet);
                            command.Parameters.AddWithValue("@ID", kitapId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Kitap adedi güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Grid'i yenile
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
