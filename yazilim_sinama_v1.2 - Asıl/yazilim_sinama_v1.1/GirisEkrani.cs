using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace yazilim_sinama_v1._1
{
    public partial class GirisEkrani : MetroFramework.Forms.MetroForm
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglantim = new SqlConnection("Data Source=MSI;Initial Catalog=sifreleme-veritabani;Integrated Security=True");       //UYGULAMADA KULLANACAĞIMIZ KULLANICI BİLGİLERİNİ VERİTABANI ÜZERİNDEN KULLANDIĞIMIZ İÇİN AQL BAĞLANTISI OLUŞTURDUK.

        public static string kullaniciadi, parola;      //FORMLAR ARASINDADA BİLGİ AKTARIMINDA KULLANABİLECEĞİMİZ 2 DEĞİŞKENİ TNAIMLADIK

        private void girisekrani_Load(object sender, EventArgs e)
        {
            this.AcceptButton = loginbuton;     //ENTER TUŞ ATAMASI
        }

        private void loginbuton_Click(object sender, EventArgs e)       //GİRİŞ YAP BUTONUNA BASILDIĞINDA FONKSİYON ÇAĞRISI YAPILIYOR
        {
            OturumAc();
        }



        //-------------------------------------------------------------------------------------------FONKSİYONLAR---------------------------------------------------------------------------------

        private void OturumAc()     //OTURUM AÇMA DOĞRULAMASI İÇİN OLUŞTURULMUŞ FONKSİYON
        {
            bool durum = false;

            baglantim.Open();       //VERİTABANI BAĞLANTISI AÇILDI
            SqlCommand selectsorgu = new SqlCommand("Select * from kullanicilar where username='" + kullaniciadialtbox.Text + "' and password='" + sifrealtbox.Text + "'", baglantim);      //SQLSORGUSU İLE GİRİLEN BİLGİLERDE KULLANICILARI GETİRDİK
            SqlDataReader kayitoku = selectsorgu.ExecuteReader();

            while (kayitoku.Read())
            {
                if (kayitoku["username"].ToString() == kullaniciadialtbox.Text && kayitoku["password"].ToString() == sifrealtbox.Text)         //VERİTABANINDAN GETİRİLEN BİLGİLER İLE GİRİLMİŞ OLAN BİLGİLER KARŞILARŞTIRILDI
                {
                    durum = true;

                    kullaniciadi = kayitoku.GetValue(1).ToString();         //DAHA SONRA KULLANMAK İÇİN BİLGİLER DEĞİŞKENLERE ATANDI
                    parola = kayitoku.GetValue(2).ToString();

                    this.Hide();
                    Anasayfa panel = new Anasayfa();   //KULLANICI BİLGİLERİ DOĞRULANDIĞINDA KULLANICI İŞLEMLERİNİN OLDUĞU FORM SAYFASI AÇILMASI SAĞLANDI
                    panel.Show();
                    break;
                }
            }
            if (durum == false)         //BİLGİLERİN YANIŞ GİRİLMESİ DURUMU KONTROL EDİLDİ YANLKIŞ İSE Bİ UYARI MESAJI VERİLECEK
            {
                MessageBox.Show("hatalı giriş oturum açılamadı");
            }

            baglantim.Close();      //VERİTABANI BAĞLANTISI KAPATILDI
        }
    }
}
