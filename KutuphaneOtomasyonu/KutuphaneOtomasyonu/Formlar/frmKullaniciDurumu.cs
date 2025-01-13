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
    public partial class frmKullaniciDurumu : Form
    {
        public frmKullaniciDurumu()
        {
            InitializeComponent();
        }

        private void frmKullaniciDurumu_Load(object sender, EventArgs e)
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
                    string query = @"SELECT Ad, Soyad, TcNo, Eposta, TelNo, Adres,BagisSayisi,OkuduguKitapSayisi,Kredi,Borc,OduncAldigiKitapSayisi FROM Kullanici";
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

        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = $"[TcNo] LIKE '%{txtTCNo.Text}%'";
        }
    }
}
