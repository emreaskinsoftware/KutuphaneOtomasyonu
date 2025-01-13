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
    public partial class frmEncokBagis : Form
    {
        public frmEncokBagis()
        {
            InitializeComponent();
        }

        private void frmEncokBagis_Load(object sender, EventArgs e)
        {
            LoadBagisList();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            txtTc.TextChanged += txtTc_TextChanged; // Filtreleme için etkinlik
        }
        private void LoadBagisList()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY BagisSayisi DESC) AS [Sıralama],
                        Ad,
                        Soyad,
                        TcNo AS [TC],
                        BagisSayisi AS [Bağış Sayısı]
                    FROM Kullanici
                    WHERE BagisSayisi > 0
                    ORDER BY BagisSayisi DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table; // Grid'e veriyi bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağış listesi yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            string tcFilter = txtTc.Text.Trim();
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY BagisSayisi DESC) AS [Sıralama],
                        Ad,
                        Soyad,
                        TcNo AS [TC],
                        BagisSayisi AS [Bağış Sayısı]
                    FROM Kullanici
                    WHERE TcNo LIKE @TcNo AND BagisSayisi > 0
                    ORDER BY BagisSayisi DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@TcNo", "%" + tcFilter + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table; // Grid'i güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Filtreleme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         }
    }
}
