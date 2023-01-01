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

namespace _01_IngilizceTurkceKelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Oyun içerisinde kullanılacak global veriler
        int soru = 0;
        int dogru = 0;
        int yanlis = 0;
        int bos = 0;
        string kelime;
        string dogruCevap;
        int sure = 90;

        // Rastgele sayı üretmek için gerekli sınıf
        Random rnd = new Random();

        // Veri tabanı bağlantı adresi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5QU84T\\SQLEXPRESS;Initial Catalog=CeviriOyunu;Integrated Security=True");

        // Soru getirme metodu
        void SoruGetir(int id)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Sozluk where Id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kelime = oku[1].ToString().ToLower();
                dogruCevap = oku[2].ToString().ToLower();
            }
            baglanti.Close();
        }

        // Oyunu başlat tuşuna basıldığında yapılacak işlemler
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            soru = 0;
            dogru = 0;
            yanlis = 0;
            bos = 0;
            sure = 90;
            soru++;
            lblDogru.Text = "0 Doğru";
            lblYanlis.Text = "0 Yanlış";
            lblBos.Text = "0 Boş";
            lblSoru.Text = soru.ToString() + ". Soru";
            btnBaslat.Enabled = false;
            pictureDogru.Visible = false;
            pictureYanlis.Visible = false;
            btnBitir.Enabled = true;
            btnPas.Enabled = true;
            btnSonraki.Enabled = true;
            txtTurkce.Enabled = true;
            timer1.Start();
            int sayi = rnd.Next(1, 101);
            SoruGetir(sayi);
            lblEnglish.Text = kelime;
            txtTurkce.Clear();
            txtTurkce.Focus();
        }

        // Zaman ayarlaması yapılır.
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString() + " saniye";
            if (sure == 0)
            {
                timer1.Stop();
                btnBaslat.Enabled = true;
                btnBitir.Enabled = false;
                btnPas.Enabled = false;
                btnSonraki.Enabled= false;
                txtTurkce.Enabled = false;
                MessageBox.Show("Sonuçlarınız " + "\n" + "Soru Sayısı: " + soru + "\n" + "Doğru Sayısı: " + dogru + "\n" + "Yanlış Sayısı: " + yanlis + "\n" +
                "Boş Sayısı: " + bos, "Yarışma Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sonraki soruyu getirmesi ve cevap kontrolü yapılır.
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            int sayi = rnd.Next(1, 101);
            if (dogruCevap == txtTurkce.Text.ToLower())
            {
                dogru++;
                pictureDogru.Visible = true;
                pictureYanlis.Visible = false;
                lblDogru.Text = dogru.ToString() + " Doğru";
            }
            else
            {
                yanlis++;
                pictureDogru.Visible = false;
                pictureYanlis.Visible = true;
                lblYanlis.Text = yanlis.ToString() + " Yanlış";
            }
            soru++;
            lblSoru.Text = soru.ToString() + ". Soru";
            SoruGetir(sayi);
            lblEnglish.Text = kelime;
            txtTurkce.Clear();
        }

        // Soru değiştirilir ve yeni soru getirilir.
        private void btnPas_Click(object sender, EventArgs e)
        {
            int sayi = rnd.Next(1, 101);
            SoruGetir(sayi);
            lblEnglish.Text = kelime;
            bos++;
            lblBos.Text = bos.ToString() + " Boş";
            soru++;
            lblSoru.Text = soru.ToString() + ". Soru";
        }

        // Oyunun yarıda bitirilmesini sağlar.
        private void btnBitir_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = true;
            btnBitir.Enabled = false;
            btnPas.Enabled = false;
            btnSonraki.Enabled = false;
            txtTurkce.Enabled = false;
            timer1.Stop();
            MessageBox.Show("Sonuçlarınız " + "\n" + "Soru Sayısı: " + soru + "\n" + "Doğru Sayısı: " + dogru + "\n" + "Yanlış Sayısı: " + yanlis + "\n" + 
                "Boş Sayısı: " + bos, "Yarışma Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
