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

namespace KütüphaneYönetimSistemleri
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglantı = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=DbC#Forms;Integrated Security=True");
        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglantı);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxKitapAdı.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxYazarAdı.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxYazarSoyadı.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxISBNNo.Text);
                sqlCommand.Parameters.AddWithValue("@p5", "True");
                sqlCommand.Parameters.AddWithValue("@p6", textBoxKitapTürKodu.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken hata oluştu!" + ex.Message);

            }
            finally
            {
                baglantı.Close();
            }
            verileriGoster();

        }

        private void verileriGoster()
        {
            try
            {
                string q = "SELECT * FROM TableKitaplar";
                SqlDataAdapter da = new SqlDataAdapter(q, baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelgecikmebedeli.Text = "0";
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;
            labelID.Text = dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            textBoxKitapAdı.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            textBoxYazarAdı.Text = dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString();
            textBoxYazarSoyadı.Text = dataGridView1.Rows[secilenSatır].Cells[3].Value.ToString();
            textBoxISBNNo.Text = dataGridView1.Rows[secilenSatır].Cells[4].Value.ToString();
            textBoxKitapTürKodu.Text = dataGridView1.Rows[secilenSatır].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridView1.Rows[secilenSatır].Cells[6].Value.ToString();
            if (dataGridView1.Rows[secilenSatır].Cells[7].Value != DBNull.Value)
                dateTimePickerOduncAlmaTarihi.Value = (DateTime)dataGridView1.Rows[secilenSatır].Cells[7].Value;
        }

        private void buttonKitapGüncelle_Click(object sender, EventArgs e)
        {

            try
            {
                baglantı.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET " +
                    "KitapAdi='" + textBoxKitapAdı.Text + "', " +
                    "YazarAdi='" + textBoxYazarAdı.Text + "', " +
                    "YazarSoyadi='" + textBoxYazarSoyadı.Text + "', " +
                    "ISBN='" + textBoxISBNNo.Text + "', " +
                    "KitapTurKodu=" + textBoxKitapTürKodu.Text + " " +
                    "WHERE ID = @Id", baglantı);

                sqlCommand.Parameters.AddWithValue("@Id", labelID.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap bilgileri güncellenirken hata oluştu!" + ex.Message);

            }
            finally
            {
                baglantı.Close();
            }
            verileriGoster();

        }

        private void buttonKitapOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "--")
            {
                try
                {
                    baglantı.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan=@P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID = @P4", baglantı);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerOduncAlmaTarihi.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç işlemi sırasında hata oluştu!" + ex.Message);

                }
                finally
                {
                    baglantı.Close();
                }
                verileriGoster();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz.");
            }
        }

        private void buttonGecikmeBedeli_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "--")
            {
                DateTime bugununTarihi = DateTime.Now;
                int gunFarkı = (int)(bugununTarihi - dateTimePickerOduncAlmaTarihi.Value.Date).TotalDays;
                if (gunFarkı > 10)
                {
                    int gecikmeBedeli = (gunFarkı - 10) * 1;
                    labelgecikmebedeli.Text = gecikmeBedeli.ToString();

                }
            }
        }

        private void buttonKitapIade_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "--")
            {
                try
                {
                    baglantı.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan=@P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID = @P4", baglantı);
                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();

                    textBoxOduncAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade işlemi sırasında hata oluştu!" + ex.Message);

                }
                finally
                {
                    baglantı.Close();
                }
                verileriGoster();
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {

            metinKutularınıTemizle();
        }
        public void metinKutularınıTemizle()
        {
            labelID.Text = "--";
            textBoxKitapAdı.Text = "";
            textBoxYazarAdı.Text = "";
            textBoxYazarSoyadı.Text = "";
            textBoxISBNNo.Text = "";
            textBoxKitapTürKodu.Text = "";
            textBoxOduncAlan.Text = "";

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaSonuclarınıGoster();
        }

        private void aramaSonuclarınıGoster()
        {
            try
            {

                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxKitapAdı.Text
                                                                               + "%' AND YazarAdi LIKE '" + textBoxYazarAdı.Text + "%' "
                                                                               + " AND YazarSoyadi LIKE '" + textBoxYazarSoyadı.Text + "%' "
                                                                               + " AND ISBN LIKE '" + textBoxISBNNo.Text + "%' "
                                                                               + " AND KitapTurKodu LIKE '" + textBoxKitapTürKodu.Text + "%' "
                                                                               + " AND OduncAlan LIKE '" + textBoxOduncAlan.Text + "%' ";


                SqlDataAdapter da = new SqlDataAdapter(q, baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonTumKitaplarıGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "--" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen silinecek olan kitabı seçiniz.");
            }
            else
            {
                try
                {
                    baglantı.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID = @P1", baglantı);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);
                    sqlCommand.ExecuteNonQuery();

                    textBoxOduncAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silme işlemi sırasında hata oluştu!" + ex.Message);

                }
                finally
                {
                    baglantı.Close();
                }
                verileriGoster();
                metinKutularınıTemizle();
            }

        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
