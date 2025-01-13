using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Formlar
{
    public partial class frmGecikmeRaporu : Form
    {
        public frmGecikmeRaporu()
        {
            InitializeComponent();
        }

        private void frmGecikmeRaporu_Load(object sender, EventArgs e)
        {
            LoadGecikmeRaporu(); // İlk yükleme
            ConfigureGrid(); // Grid ayarlarını yap
        }

        // Grid Ayarlarını Yapılandır
        private void ConfigureGrid()
        {
            gridView1.OptionsBehavior.Editable = false; // Düzenlemeyi devre dışı bırak
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklenmesini engelle
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never; // Filtre panelini gizle
        }

        // Gecikme Raporunu Veritabanından Yükler
        private void LoadGecikmeRaporu(string tcNo = "")
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    SELECT 
                        CONCAT(k.Ad, ' ', k.Soyad) AS [Kullanıcı Adı Soyadı],
                        k.TcNo AS [TC No],
                        kt.Ad AS [Kitabın Adı],
                        o.SonIadeTarihi AS [Son İade Tarihi],
                        o.GecikmeUcreti AS [Gecikme Ücreti]
                    FROM OduncAlinanlar o
                    INNER JOIN Kullanici k ON o.KullaniciId = k.ID
                    INNER JOIN Kitap kt ON o.KitapId = kt.ID
                    WHERE o.GecikmeUcreti > 0
                    AND (@TcNo = '' OR k.TcNo LIKE '%' + @TcNo + '%')
                    ORDER BY o.GecikmeUcreti DESC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@TcNo", tcNo);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridControl1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gecikme raporu yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Ara Butonuna Tıklandığında Çalışır
        private void btnAra_Click(object sender, EventArgs e)
        {
            string tcNo = txtTc.Text.Trim();
            LoadGecikmeRaporu(tcNo); // Veriyi filtrele
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            string tcNo = txtTc.Text.Trim();
            LoadGecikmeRaporu(tcNo); // Filtrelenmiş raporu yükle
        }
    }
}
