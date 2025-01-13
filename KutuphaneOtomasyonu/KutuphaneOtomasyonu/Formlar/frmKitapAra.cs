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
    public partial class frmKitapAra : Form
    {
        public frmKitapAra()
        {
            InitializeComponent();
        }

        private void frmKitapAra_Load(object sender, EventArgs e)
        {
            LoadBooks();
            gridView1.OptionsBehavior.Editable = false; // Tüm düzenlemeleri devre dışı bırakır
            gridView1.OptionsSelection.MultiSelect = false; // Çoklu seçim engellenir
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None; // Yeni satır eklemeyi devre dışı bırakır
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
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
                    ID,
                    Ad AS [Kitap Adı],
                    Yazar AS [Yazarı],
                    Kategori AS [Kategorisi],
                    Adet AS [Kütüphanedeki Adet],
                    (Adet - ISNULL(OduncSayisi, 0)) AS [Alınabilecek Kitap Adedi]
                FROM 
                    Kitap";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    gridListe.DataSource = table; // GridControl'e veri kaynağı olarak ata
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitaplar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtKitabınAdi_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[Kitap Adı] LIKE '%{txtKitapAra.Text}%'";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Lütfen ödünç vermek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show("Kitap ödünç verme işlemi devam edebilir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Seçilen kitabın bilgilerini al
            string kitapAdi = selectedRow["Kitap Adı"].ToString();
            string kitapYazari = selectedRow["Yazarı"].ToString();

            Formlar.frmOduncVer frm = new Formlar.frmOduncVer();
            frm.SetKitapBilgileri(kitapAdi, kitapYazari);
            frm.Show();
        }
    }
}
