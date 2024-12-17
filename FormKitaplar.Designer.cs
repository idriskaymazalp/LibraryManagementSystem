namespace KütüphaneYönetimSistemleri
{
    partial class FormKitaplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            groupBox1 = new GroupBox();
            buttonKitapSil = new Button();
            buttonTumKitaplarıGoster = new Button();
            buttonAra = new Button();
            buttonTemizle = new Button();
            buttonKitapEkle = new Button();
            buttonKitapGüncelle = new Button();
            textBoxKitapTürKodu = new TextBox();
            textBoxISBNNo = new TextBox();
            textBoxYazarSoyadı = new TextBox();
            textBoxYazarAdı = new TextBox();
            textBoxKitapAdı = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonKitapOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttonKitapIade = new Button();
            buttonGecikmeBedeli = new Button();
            label12 = new Label();
            labelgecikmebedeli = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonKitapSil);
            groupBox1.Controls.Add(buttonTumKitaplarıGoster);
            groupBox1.Controls.Add(buttonAra);
            groupBox1.Controls.Add(buttonTemizle);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(buttonKitapGüncelle);
            groupBox1.Controls.Add(textBoxKitapTürKodu);
            groupBox1.Controls.Add(textBoxISBNNo);
            groupBox1.Controls.Add(textBoxYazarSoyadı);
            groupBox1.Controls.Add(textBoxYazarAdı);
            groupBox1.Controls.Add(textBoxKitapAdı);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(782, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // buttonKitapSil
            // 
            buttonKitapSil.Font = new Font("Century", 10.2F);
            buttonKitapSil.Location = new Point(275, 340);
            buttonKitapSil.Name = "buttonKitapSil";
            buttonKitapSil.Size = new Size(109, 52);
            buttonKitapSil.TabIndex = 18;
            buttonKitapSil.Text = "Kitap Sil";
            buttonKitapSil.UseVisualStyleBackColor = true;
            buttonKitapSil.Click += buttonKitapSil_Click;
            // 
            // buttonTumKitaplarıGoster
            // 
            buttonTumKitaplarıGoster.Font = new Font("Century", 10.2F);
            buttonTumKitaplarıGoster.Location = new Point(390, 340);
            buttonTumKitaplarıGoster.Name = "buttonTumKitaplarıGoster";
            buttonTumKitaplarıGoster.Size = new Size(147, 52);
            buttonTumKitaplarıGoster.TabIndex = 17;
            buttonTumKitaplarıGoster.Text = "Tüm Kitapları Göster";
            buttonTumKitaplarıGoster.UseVisualStyleBackColor = true;
            buttonTumKitaplarıGoster.Click += buttonTumKitaplarıGoster_Click;
            // 
            // buttonAra
            // 
            buttonAra.Font = new Font("Century", 10.2F);
            buttonAra.Location = new Point(543, 340);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(112, 52);
            buttonAra.TabIndex = 16;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Font = new Font("Century", 10.2F);
            buttonTemizle.Location = new Point(661, 340);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(110, 52);
            buttonTemizle.TabIndex = 15;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Font = new Font("Century", 10.2F);
            buttonKitapEkle.Location = new Point(160, 340);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(109, 52);
            buttonKitapEkle.TabIndex = 14;
            buttonKitapEkle.Text = "Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // buttonKitapGüncelle
            // 
            buttonKitapGüncelle.Font = new Font("Century", 10.2F);
            buttonKitapGüncelle.Location = new Point(7, 340);
            buttonKitapGüncelle.Name = "buttonKitapGüncelle";
            buttonKitapGüncelle.Size = new Size(147, 52);
            buttonKitapGüncelle.TabIndex = 13;
            buttonKitapGüncelle.Text = "Kitap Bilgilerini Güncelle";
            buttonKitapGüncelle.UseVisualStyleBackColor = true;
            buttonKitapGüncelle.Click += buttonKitapGüncelle_Click;
            // 
            // textBoxKitapTürKodu
            // 
            textBoxKitapTürKodu.Location = new Point(227, 269);
            textBoxKitapTürKodu.Name = "textBoxKitapTürKodu";
            textBoxKitapTürKodu.Size = new Size(258, 32);
            textBoxKitapTürKodu.TabIndex = 11;
            // 
            // textBoxISBNNo
            // 
            textBoxISBNNo.Location = new Point(227, 217);
            textBoxISBNNo.Name = "textBoxISBNNo";
            textBoxISBNNo.Size = new Size(258, 32);
            textBoxISBNNo.TabIndex = 10;
            // 
            // textBoxYazarSoyadı
            // 
            textBoxYazarSoyadı.Location = new Point(227, 165);
            textBoxYazarSoyadı.Name = "textBoxYazarSoyadı";
            textBoxYazarSoyadı.Size = new Size(258, 32);
            textBoxYazarSoyadı.TabIndex = 9;
            // 
            // textBoxYazarAdı
            // 
            textBoxYazarAdı.Location = new Point(227, 119);
            textBoxYazarAdı.Name = "textBoxYazarAdı";
            textBoxYazarAdı.Size = new Size(258, 32);
            textBoxYazarAdı.TabIndex = 8;
            // 
            // textBoxKitapAdı
            // 
            textBoxKitapAdı.Location = new Point(227, 71);
            textBoxKitapAdı.Name = "textBoxKitapAdı";
            textBoxKitapAdı.Size = new Size(258, 32);
            textBoxKitapAdı.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F);
            label7.Location = new Point(24, 278);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(175, 23);
            label7.TabIndex = 6;
            label7.Text = "Kitap Tür Kodu : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(24, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 5;
            label6.Text = "ISBN No : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F);
            label5.Location = new Point(24, 174);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 4;
            label5.Text = "Yazar Soyadı : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F);
            label4.Location = new Point(24, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 3;
            label4.Text = "Yazar Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F);
            label3.Location = new Point(24, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adı : ";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(227, 40);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 23);
            labelID.TabIndex = 1;
            labelID.Text = "--";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F);
            label1.Location = new Point(24, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitapOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(799, 9);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(332, 410);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            buttonKitapOduncVer.Font = new Font("Century", 10.2F);
            buttonKitapOduncVer.Location = new Point(93, 340);
            buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            buttonKitapOduncVer.Size = new Size(157, 52);
            buttonKitapOduncVer.TabIndex = 15;
            buttonKitapOduncVer.Text = "Kitap Ödünç Ver";
            buttonKitapOduncVer.UseVisualStyleBackColor = true;
            buttonKitapOduncVer.Click += buttonKitapOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePickerOduncAlmaTarihi.Location = new Point(152, 91);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(157, 28);
            dateTimePickerOduncAlmaTarihi.TabIndex = 9;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(152, 49);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(157, 32);
            textBoxOduncAlan.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F);
            label9.Location = new Point(8, 98);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 4;
            label9.Text = "Tarih : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F);
            label8.Location = new Point(8, 52);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(137, 23);
            label8.TabIndex = 3;
            label8.Text = "Ödünç Alan : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitapIade);
            groupBox3.Controls.Add(buttonGecikmeBedeli);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(labelgecikmebedeli);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(1139, 9);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(283, 413);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // buttonKitapIade
            // 
            buttonKitapIade.Font = new Font("Century", 10.2F);
            buttonKitapIade.Location = new Point(63, 349);
            buttonKitapIade.Name = "buttonKitapIade";
            buttonKitapIade.Size = new Size(157, 52);
            buttonKitapIade.TabIndex = 14;
            buttonKitapIade.Text = "Kitap İade Et";
            buttonKitapIade.UseVisualStyleBackColor = true;
            buttonKitapIade.Click += buttonKitapIade_Click;
            // 
            // buttonGecikmeBedeli
            // 
            buttonGecikmeBedeli.Font = new Font("Century", 10.2F);
            buttonGecikmeBedeli.Location = new Point(63, 264);
            buttonGecikmeBedeli.Name = "buttonGecikmeBedeli";
            buttonGecikmeBedeli.Size = new Size(157, 52);
            buttonGecikmeBedeli.TabIndex = 13;
            buttonGecikmeBedeli.Text = "Gecikme Bedeli Hesaplama";
            buttonGecikmeBedeli.UseVisualStyleBackColor = true;
            buttonGecikmeBedeli.Click += buttonGecikmeBedeli_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(247, 49);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(36, 23);
            label12.TabIndex = 6;
            label12.Text = "TL";
            // 
            // labelgecikmebedeli
            // 
            labelgecikmebedeli.AutoSize = true;
            labelgecikmebedeli.Location = new Point(188, 49);
            labelgecikmebedeli.Margin = new Padding(4, 0, 4, 0);
            labelgecikmebedeli.Name = "labelgecikmebedeli";
            labelgecikmebedeli.Size = new Size(21, 23);
            labelgecikmebedeli.TabIndex = 5;
            labelgecikmebedeli.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 12F);
            label10.Location = new Point(8, 49);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(172, 23);
            label10.TabIndex = 4;
            label10.Text = "Gecikme Bedeli : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(12, 425);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1410, 214);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1404, 189);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1431, 636);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Century", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormKitaplar";
            Text = "Kütüphane Yönetim Sistemleri";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label labelID;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox textBoxKitapAdı;
        private TextBox textBoxYazarSoyadı;
        private TextBox textBoxYazarAdı;
        private TextBox textBoxKitapTürKodu;
        private TextBox textBoxISBNNo;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button buttonKitapGüncelle;
        private Button buttonKitapKaydet;
        private Label label9;
        private Label label8;
        private TextBox textBoxOduncAlan;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private Label label10;
        private Button buttonKitapOduncVer;
        private Button buttonKitapIade;
        private Button buttonGecikmeBedeli;
        private Label label12;
        private Label labelgecikmebedeli;
        private Button buttonKitapEkle;
        private Button buttonAra;
        private Button buttonTemizle;
        private Button buttonTumKitaplarıGoster;
        private Button buttonKitapSil;
        //private Button buttonTumKitaplarıGoster;
    }
}