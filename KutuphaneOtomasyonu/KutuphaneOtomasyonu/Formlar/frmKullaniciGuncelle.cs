using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Formlar
{
    public partial class frmKullaniciGuncelle : Form
    {
        public frmKullaniciGuncelle()
        {
            InitializeComponent();
        }

        private void frmKullaniciGuncelle_Load_1(object sender, EventArgs e)
        {
            LoadKullanicilar();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
        }
        private void LoadKullanicilar()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT Ad, Soyad, TcNo, Eposta, TelNo, Adres FROM Kullanici";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridControl1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcılar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        

        private void btnEpostaGuncelle_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tcNo = selectedRow["TcNo"].ToString();
            string yeniEposta = txtEposta.Text.Trim();

            if (string.IsNullOrEmpty(yeniEposta) || !yeniEposta.Contains("@") || !yeniEposta.Contains("."))
            {
                MessageBox.Show("Geçerli bir e-posta adresi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Kullanici SET Eposta = @Eposta WHERE TcNo = @TcNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Eposta", yeniEposta);
                    command.Parameters.AddWithValue("@TcNo", tcNo);

                    command.ExecuteNonQuery();

                    MessageBox.Show("E-posta başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKullanicilar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("E-posta güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTelGuncelle_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tcNo = selectedRow["TcNo"].ToString();
            string yeniTelefon = txtTelNo.Text.Trim();

            // Girilen telefon numarasını kontrol et
            yeniTelefon = yeniTelefon.Replace(" ", ""); // Boşlukları kaldır
            if (string.IsNullOrEmpty(yeniTelefon) || yeniTelefon.Length != 11 || !yeniTelefon.All(char.IsDigit))
            {
                MessageBox.Show("Geçerli bir telefon numarası girin (11 haneli, sadece rakamlar).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Kullanici SET TelNo = @TelNo WHERE TcNo = @TcNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TelNo", yeniTelefon);
                    command.Parameters.AddWithValue("@TcNo", tcNo);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Telefon numarası başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKullanicilar(); // Grid'i güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Telefon numarası güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAdresGuncelle_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tcNo = selectedRow["TcNo"].ToString();
            string yeniAdres = txtAdres.Text.Trim();

            if (string.IsNullOrEmpty(yeniAdres))
            {
                MessageBox.Show("Adres alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Kullanici SET Adres = @Adres WHERE TcNo = @TcNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Adres", yeniAdres);
                    command.Parameters.AddWithValue("@TcNo", tcNo);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Adres başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKullanicilar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Adres güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (selectedRow != null)
            {
                txtTCNo.Text = selectedRow["TcNo"].ToString();
                txtEposta.Text = selectedRow["Eposta"].ToString();
                txtTelNo.Text = selectedRow["TelNo"].ToString();
                txtAdres.Text = selectedRow["Adres"].ToString();
            }
        }

        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[TcNo] LIKE '%{txtTCNo.Text}%'";
        }
    }
}
