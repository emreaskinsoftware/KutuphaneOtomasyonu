using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Formlar
{
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Bilgi doğruluğu kontrolü
            if (!chkBilgilerDogru.Checked)
            {
                MessageBox.Show("Lütfen 'Bilgiler Doğru' kutusunu işaretleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Girişlerin doğruluğunu kontrol et
            if (string.IsNullOrEmpty(txtAd.Text.Trim()) ||
                string.IsNullOrEmpty(txtSoyad.Text.Trim()) ||
                string.IsNullOrEmpty(txtTC.Text.Trim()) ||
                string.IsNullOrEmpty(txtEposta.Text.Trim()) ||
                string.IsNullOrEmpty(txtTelefonNo.Text.Trim()) ||
                string.IsNullOrEmpty(txtAdres.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TC Kimlik Numarası kontrolü
            if (txtTC.Text.Length != 11 || !long.TryParse(txtTC.Text.Trim(), out _))
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefon numarası kontrolü
            if (!long.TryParse(txtTelefonNo.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), out _))
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcı ekleme sorgusu
                    string query = @"
                INSERT INTO Kullanici (Ad, Soyad, TelNo, TcNo, Eposta, Adres, BagisSayisi, OkuduguKitapSayisi, Kredi, Borc, OduncAldigiKitapSayisi)
                VALUES (@Ad, @Soyad, @TelNo, @TcNo, @Eposta, @Adres, 0, 0, 100, 0, 0)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAd.Text.Trim().ToLower()));
                    command.Parameters.AddWithValue("@Soyad", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSoyad.Text.Trim().ToLower()));
                    command.Parameters.AddWithValue("@TelNo", txtTelefonNo.Text.Trim());
                    command.Parameters.AddWithValue("@TcNo", txtTC.Text.Trim());
                    command.Parameters.AddWithValue("@Eposta", txtEposta.Text.Trim().ToLower());
                    command.Parameters.AddWithValue("@Adres", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAdres.Text.Trim().ToLower()));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtEposta.Text = "";
                    txtTelefonNo.Text = "";
                    txtAdres.Text = "";
                    chkBilgilerDogru.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtKullaniciAdi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
