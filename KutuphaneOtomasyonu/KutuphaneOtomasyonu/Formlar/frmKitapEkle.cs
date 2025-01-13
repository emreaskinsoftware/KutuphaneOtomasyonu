using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Formlar
{
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }

       

        // Form temizleme metodu
        private void ClearForm()
        {
            txtKitapAdi.Text = "";
            txtYazar.Text = "";
            cmbKategori.SelectedIndex = -1; // ComboBox temizleme
            txtAdet.Text = "";
            chkBagis.Checked = false;
            txtTc.Text = "";
            lblBagisTc.Visible = false;
            txtTc.Visible = false;
        }

        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            // İhtiyaç halinde başlangıç işlemleri
        }

        private void chkBagis_CheckedChanged_1(object sender, EventArgs e)
        {
            lblBagisTc.Visible = chkBagis.Checked;
            txtTc.Visible = chkBagis.Checked;
            if (chkBagis.Checked)
            {
                txtTc.BringToFront(); // TC No kontrolünü ön plana getir
                lblBagisTc.BringToFront();
            }
        }

        private void btnKitapEkle_Click_1(object sender, EventArgs e)
        {
            // Form alanlarından değerleri al
            string kitapAdi = txtKitapAdi.Text.Trim();
            string yazar = txtYazar.Text.Trim();
            string kategori = cmbKategori.Text.Trim();
            int adet = 0;
            bool bagis = chkBagis.Checked;
            int bagisAdedi = 0;

            // Adet kontrolü
            if (!int.TryParse(txtAdet.Text.Trim(), out adet) || adet <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir adet giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bağış kontrolü
            if (bagis)
            {
                if (string.IsNullOrEmpty(txtTc.Text.Trim()) || txtTc.Text.Length != 11 || !txtTc.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Bağış seçeneği işaretliyken geçerli bir TC No girilmelidir (11 haneli)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bagisAdedi = adet; // Bağış seçiliyse, bağış adedi toplam adet ile aynı olur
            }

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(kitapAdi) || string.IsNullOrEmpty(yazar) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıdan onay al
            DialogResult dialogResult = MessageBox.Show(
                "Bilgilerin doğru olduğundan emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                // Veritabanına bağlan ve kaydı ekle
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // Eğer bağış yapılıyorsa kullanıcı var mı kontrol et
                        if (bagis)
                        {
                            string checkUserQuery = @"SELECT COUNT(*) FROM Kullanici WHERE TcNo = @TcNo";
                            using (SqlCommand checkCommand = new SqlCommand(checkUserQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@TcNo", txtTc.Text.Trim());
                                int userExists = Convert.ToInt32(checkCommand.ExecuteScalar());
                                if (userExists == 0)
                                {
                                    MessageBox.Show("Girdiğiniz TC No'ya sahip bir kullanıcı bulunamadı. Bağış işlemi gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }

                        // Kitap ekleme sorgusu
                        string query = @"INSERT INTO Kitap (Ad, Yazar, Kategori, Bagis, Adet, BagisAdedi)
                                         VALUES (@Ad, @Yazar, @Kategori, @Bagis, @Adet, @BagisAdedi)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@Ad", kitapAdi);
                            command.Parameters.AddWithValue("@Yazar", yazar);
                            command.Parameters.AddWithValue("@Kategori", kategori);
                            command.Parameters.AddWithValue("@Bagis", bagis ? 1 : 0);
                            command.Parameters.AddWithValue("@Adet", adet);
                            command.Parameters.AddWithValue("@BagisAdedi", bagisAdedi);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Eğer bağış ise kullanıcı tablosunu güncelle
                                if (bagis)
                                {
                                    string updateBagisQuery = @"
                                    UPDATE Kullanici
                                    SET BagisSayisi = BagisSayisi + @BagisAdedi
                                    WHERE TcNo = @TcNo";

                                    using (SqlCommand updateCommand = new SqlCommand(updateBagisQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@BagisAdedi", bagisAdedi);
                                        updateCommand.Parameters.AddWithValue("@TcNo", txtTc.Text.Trim());
                                        updateCommand.ExecuteNonQuery();
                                    }

                                    MessageBox.Show($"Bağış işlemi başarıyla tamamlandı. {bagisAdedi} kitap bağışı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                // Form alanlarını temizle
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("Kitap eklenirken bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Kullanıcı düzenlemeye devam edebilir
                MessageBox.Show("Lütfen bilgileri kontrol edip düzenleyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
