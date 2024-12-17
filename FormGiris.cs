using System.Data.SqlClient;
using System.Drawing;

namespace KütüphaneYönetimSistemleri
{
    public partial class FormGiris : Form
    {
        FormKitaplar FormKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=DbC#Forms;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "";

            if ((textBoxKullanıcıAdı.Text == "") || (textBoxSifre.Text == ""))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı !");
                return;
            }
            try
            {
                baglantı.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKütüphaneYöneticileri WHERE KullaniciAdi = @p1", baglantı);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullanıcıAdı.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }

                if (sifre == textBoxSifre.Text)
                {

                    FormKitaplar = new FormKitaplar();
                    this.Hide();
                    FormKitaplar.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre hatalıdır.");
                    textBoxKullanıcıAdı.Text = "";
                    textBoxSifre.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı Hatası!" + ex.Message);
            }
            finally
            {
                baglantı.Close();
            }

        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = false;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
