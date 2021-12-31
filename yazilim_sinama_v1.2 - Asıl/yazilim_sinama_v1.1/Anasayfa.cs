using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;//sha256 için kütüphane
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace yazilim_sinama_v1._1
{
    public partial class Anasayfa : MetroFramework.Forms.MetroForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        string plaintext, ciphertext;       //KULLANICI EKRANINDA KULLANACAĞIMIZ DEĞİŞKEN VE TEXT,KEY PARÇALARINI TUTACAĞIMIZ DİZİLERİ OLUŞTURDUK
        string[] KeyDizi = new string[4];
        string[] MetinDizi;


        private void sifrelebuton_Click(object sender, EventArgs e)     //ŞİFRELE BUTONUNA TIKLANDIĞINDA YAPILACAK İŞLEMLER
        {
            int formkontrol=FormKontrol();      //FORM BİLGİLERİNDE KEY,ALGORİTMA,TEXT BİLGİLERİNİN BOŞ VEYA DOĞRU GİRİLMESİNİ KONTROL EDEN FONKSİYON ÇAĞIRILDI

            if (spnradiobuton.Checked==true && formkontrol == 0)        //FORMDA HATA OLMMAMASI DURUMUNDA SEÇİLEN ALGORİTMAYA GÖRE ŞİFRELEME FONKSİYONLARI ÇAĞIRILDI
            {
                SPNSifreleme();
            }
            else if (sharadiobuton.Checked == true&& formkontrol == 0  )
            {
                SHASifreleme();
            }
        }

        private void cözbuton_Click(object sender, EventArgs e)     //ÇÖZ BUTONUNA TIKLANDIĞINDA YAPILACAK İŞLEMLER
        {
            int formkontrol = FormKontrol();

            if (spnradiobuton.Checked == true && formkontrol == 0)      //FORMDA HATA OLMAMASI HALİNDE SEÇİLEN ALGORİTMADA ŞİFRE ÇÖZME İŞLEMİ VARSA KULLANILACAK FONKSİYON ÇAĞIRILDI
            {
                SPNCözme();
            }
            else if (sharadiobuton.Checked == true && formkontrol == 0)
            {
                MessageBox.Show("SHA 256 ALGORİTMASI GERİYE DOĞRU ÇÖZÜLEMEZ!");
            }
        }

        //----------------------------------------------------------------------------------------FONKSİYONLAR------------------------------------------------------------------------------------


        private int FormKontrol()       //ŞİFRELEME VE ÇÖZME EKRANINDA GEREKLİ SEÇENEKLERİN SEÇİLİ VE BOŞ OLMAMASI KONTROL EDİLMESİ İÇİN YAZILAN FONKSİYON
        {
            int formkarar = 0;

            if (spnradiobuton.Checked==false  &&sharadiobuton.Checked==false)       //HERHANGİ BİR ALGORİTMA TÜRÜ SEÇİLDİMİ KONTROL ETTİK
            {
                MessageBox.Show("İŞLEM YAPMAK İÇİN ALGORİTMA TÜRÜ SEÇMELİSİNİZ !");
                formkarar++;
            }
            else if (spnradiobuton.Checked==true)       
            {
                if (metinkutusu1.Text=="")
                {
                    MessageBox.Show("PLAİN TEXT KISMINI BOŞ BIRAKAMAZSINIZ !");     //GİRİLEN TEXT KISMI BOŞ GEÇİLMEMESİ İÇİN KONTROL ETTİK
                    formkarar++;
                }
                else if (keyaltbox.Text.Length != 8)
                {
                    MessageBox.Show("ALGORİTMADA KULLANILACAK KEY 8 KARAKTER İÇERMELİDİR !");       //ŞİFRELEME ALGORİTMASINDA KULLANILACAK OLAN KEYİN YETERLİ KARAKTER SAYISINDA OLMASINI KONTROL ETTİK
                    formkarar++;
                }
            }
            else if (sharadiobuton.Checked == true)
            {
                if (metinkutusu1.Text == "" )
                {
                    MessageBox.Show("PLAİN TEXT KISMINI BOŞ BIRAKAMAZSINIZ !");
                    formkarar++;
                }
            }

            return formkarar++; ;
        }

        private void SPNSifreleme()     //SPN ŞİFRELEME ALGORİTMA İŞLEMLERİNİN YAPILACAĞI FONKSİYON
        {
            string göndera, gönderb, xorluhal;
            ciphertext = "";
            keyaltbox.Text = ENGCevir(keyaltbox.Text);      //GİRİLEN ŞİFRELEME KEYİ İÇESİRİNNDEKİ TÜRKÇE KARAKTERLERİ DEĞİŞTİRMEK İÇİN GEREKLİ FONKSİYONA GÖNDERDİK
            KeyDüzenle(keyaltbox.Text);     //ŞİFRELEME KEYİ ALGORİTMADA KULLANILMAK ÜZERE GEREKLİ PARÇALAR HALİNE GETİREN FONKSİYONA GÖNDERİLDİ
            metinkutusu1.Text = ENGCevir(metinkutusu1.Text);        //GİRİLEN TEXT İÇERİSİNDE TÜRKÇE KARAKTERLERİ DEĞİŞTİRMEK İÇİN GEREKLİ FONKSİYONA GÖNDERİLDİ 
            CiftmiKontrol(metinkutusu1.Text);       //SPN ALGORİTMASINDA TEXT 2 ŞER KARAKTERLER HALİNDE PARÇALANIP ŞİFRELENECEĞİ İÇİN GİRİLEN DEGERİN ÇİFT SAYIDA KARAKTER İÇERİYORMU DİYE KONTROL EDEN FONKSİYONA GÖNDERDİK
            MetinDizi = new string[plaintext.Length / 2];       //ŞİFRELENECEK OLAN MESAJIN PARÇALAR HALİNDE TUTULACAĞI DİZİYİ KARAKTER SAYISINA GÖRE OLUŞTURDUK
            MesajDüzenle(plaintext);        //ŞİFRELENECEK METİNİN 2 KARAKTER HALİNDE PARÇALANMASI İÇİN GEREKLİ FONKSİYONA GÖNDERDİK

            for (int metinSdöngüsü = 0; metinSdöngüsü < plaintext.Length / 2; metinSdöngüsü++)      //METİN İÇERİSİNDEKİ 2 KARAKTERLİK PARÇALARI DEĞİŞTİRMEK İÇİN DÖNGÜ
            {

                for (int i = 0; i < 2; i++)     //HER PARÇA İÇERİSİNDEKİ KARAKTER İÇİN DÖNGÜ
                {

                    göndera = MetinDizi[metinSdöngüsü];     //DİZİ İÇERİSİNDE GEREKLİ METİN PARÇASINI ALDIK "GÖNDERA" DEĞİŞKENİNE 
                    gönderb = KeyDizi[i];       //DİZİ İÇERİSİNDE GEREKLİ KEY PARÇASINI ALDIK "GÖNDERB" DEĞİŞKENİNE 
                    xorluhal = XorMaker(göndera, gönderb);      //DAHA SONRA GEREKLİ KEY VE METİN PARÇALARI XOR İŞLEMİNİ UYGULAMAK İÇİN FONKSİYONA GÖNDERİLDİ
                    MetinDizi[metinSdöngüsü] = KaristirSifrele(xorluhal);       //VE XOR İŞLEMİ SONUCUNDA BİNARY DEĞERLERİN SPN ALGORİTMASI GEREĞİ YERLERİ BELLİ ŞEKİLDE KARILACAK FONKSİYONA GÖNDERİLDİ VE SONUÇ TEKRAR DİZİYE YERLEŞTİRİLDİ 
                    
                }
                MetinDizi[metinSdöngüsü] = XorMaker(MetinDizi[metinSdöngüsü], KeyDizi[2]);      //3. KISIMDA KARMA İŞLEMİ OLMADAN 2 KERE ÜST ÜSTE XOR İŞLEMİ YAPILACAK FARKLI KEY PARÇALARI İLE
                MetinDizi[metinSdöngüsü] = XorMaker(MetinDizi[metinSdöngüsü], KeyDizi[3]);

                ciphertext += MetinDizi[metinSdöngüsü];     //DAHA SONRA ŞİFRELENMİŞ MESAJ SONUCUNU DEĞİŞKENE TAŞIDIK

            }


            metinkutusu2.Text = ciphertext;     //SONRASINDA İSE KULLANICININ GÖRECEĞİ VEYA ŞİFRELİ MESAJJI GÖNDERMEK İSTEYEBİLECEĞİ YERLEREDE YERLEŞTİRDİK
            txt_text.Text = ciphertext;
        }

        private void SPNCözme()     //SPN ALGORİTMASI GERİ ÇÖZÜMÜ İÇİN FONKSİYON 
        {
            string xorluhalgeri, gönderc, gönderd;      
            ciphertext = "";
            string hashparca;
            keyaltbox.Text = ENGCevir(keyaltbox.Text);
            KeyDüzenle(keyaltbox.Text);
            MetinDizi = new string[metinkutusu1.Text.Length / 16];      //16 BİNARY DEĞER BİR METİN PARÇASINA İFADE ETTİĞİ İÇİN DÖNGÜYÜ KURDUK

            for (int metinCdöngüsü = 0; metinCdöngüsü < metinkutusu1.Text.Length / 16; metinCdöngüsü++)
            {
                hashparca = metinkutusu1.Text.Substring(metinCdöngüsü * 16, 16);
                MetinDizi[metinCdöngüsü] = XorMaker(hashparca, KeyDizi[3]);// METİN BİNARY PARÇALARINA GEREKLİ KEY İLE TEKRAR XOR İŞLEMİ UYGULANIYOR

                for (int i = 2; i > 0; i--)
                {
                    gönderc = MetinDizi[metinCdöngüsü];
                    gönderd = KeyDizi[i];
                    xorluhalgeri = XorMaker(gönderc, gönderd);
                    MetinDizi[metinCdöngüsü] = KaristirCoz(xorluhalgeri);       //XOR İŞLEMLERİ VE ARDINDAN ALGORİTMAYA GÖRE TERSE KARIŞTIRMA İŞLEMİ YAPILIYOR

                }
                MetinDizi[metinCdöngüsü] = XorMaker(MetinDizi[metinCdöngüsü], KeyDizi[0]);
                ciphertext += MetinDizi[metinCdöngüsü];
            }

            metinkutusu2.Text = StringeCevir(ciphertext);       //ARDINDAN ELDE EDİLEN ÇÖZÜLMÜŞ BİNARY DEĞER STRİNGE ÇEVİRMEK İÇİN FONKSİYONA YÖNLENDİRİLİYOR
        }

        private void SHASifreleme()     //UYGULAMA İÇERİSİNDE SHA ALGORİTMASI İÇİN ŞİFRELEME FONKSİYONU
        {
            metinkutusu2.Text = "";

            // Create a SHA256   
            using (SHA256 sha256 = SHA256.Create())     //SHA256 İÇİN HAZIR KÜTÜPHANE KULLANDIK
            {
                // ComputeHash - returns byte array  
                byte[] bitDizi = sha256.ComputeHash(Encoding.UTF8.GetBytes(metinkutusu1.Text));

                // Convert byte array to a string   
                StringBuilder sifrelihash = new StringBuilder();
                for (int i = 0; i < bitDizi.Length; i++)
                {
                    sifrelihash.Append(bitDizi[i].ToString("x2"));
                }
                 metinkutusu2.Text = sifrelihash.ToString() ;
            }

        }

        private void KeyDüzenle(string girdikey)        //ŞİFRELEME İÇİN KEYİ 2 KARAKTERDEN OLUŞAN 4 PARÇAYA BÖLEN FONKSİYON
        {
            int artis1 = 0;

            for (int i = 0; i < 4; i++)
            {
                KeyDizi[i] = DegerParcala(girdikey, artis1);
                artis1 += 2;
            }
            
        }

        public string DegerParcala(string tamsifre,int alinacakparca)      //GİRİLEN METİN İÇERİSİNDEN GEREKLİ PARÇAYI ALMASINI SAĞLAYAN FONKSİYON
        {
            string bytekey,cevirilmisdeger;
            bytekey=tamsifre.Substring(alinacakparca, 2);
            cevirilmisdeger = BinaryCevir(bytekey);
            return cevirilmisdeger;   

        }

        public string BinaryCevir(string CevirilecekDeger)     //ALINAN PARÇANIN BİNARY HALE ÇEVİRİLMESİNİ SAĞLAYAN FONKSİYON
        {
            string SonucBinary = "";
            for (int i = 0; i < CevirilecekDeger.Length; i++)
            {
                SonucBinary += Convert.ToString(CevirilecekDeger[i], 2).PadLeft(8, '0');
            }
            return SonucBinary;
        }

        public string ENGCevir(string TRtext)      //TÜRKÇE KARAKTERLERİ DÖNÜŞTÜREN FONKSİYONUMUZ
        {
            TRtext = TRtext.Replace("ı","i");
            TRtext = TRtext.Replace("İ","I");
            TRtext = TRtext.Replace("ğ","g");
            TRtext = TRtext.Replace("Ğ","G");
            TRtext = TRtext.Replace("ş","s");
            TRtext = TRtext.Replace("Ş","S");
            TRtext = TRtext.Replace("ö","o");
            TRtext = TRtext.Replace("Ö","O");
            TRtext = TRtext.Replace("Ç","C");
            TRtext = TRtext.Replace("ç","c");
            TRtext = TRtext.Replace("Ü","U");
            TRtext = TRtext.Replace("ü","u");

            return TRtext;
        }

        private void CiftmiKontrol(string engmetin)     //ŞİFRELENECEK METİN ÇİFT SAYIDA KARAKTER OLMASI GEREKTİĞİ İÇİN KONTROLÜNÜ YAPAN VE TAMAMLAMAK İÇİN BOŞLUK KARAKTERİ EKLEYEN FONKSİYON
        {
            if(metinkutusu1.Text.Length% 2 == 1)
            {
                plaintext = engmetin + " ";
            }
            else
            {
                plaintext = engmetin;
            }
        }

        private void MesajDüzenle(string metin)     //ŞİFRELENECEK METİNİ PARÇALARA AYIRIP DİZİSİNE ATAMAYA YARAYAN FONKSİYON
        {
            int artis2=0;

            for (int say = 0; say < metin.Length/2; say++)
             {
                
                MetinDizi[say] = DegerParcala(metin, artis2);
                artis2+=2;   
                
            }
            
        }

        private string XorMaker(string a,string b)             //ALGORİTMA İÇERİSİNDE XOR İŞLEMLERİNİ UYGULAYACAK OLAN FONKSİYON
        {
            string  xorsonuc="";
            int islem = 0;


            for (int i = 0; i < 16; i++)
            {
                islem = Convert.ToInt32(a[i]) ^ Convert.ToInt32(b[i]);
                xorsonuc += islem.ToString();
            }
            return xorsonuc;

        }

        public string StringeCevir(string binaryal)        //ÇÖZÜM İŞLEMİNDE METİN ÇÖZÜLDÜKTEN SONRA OLUŞAN SON BİNARY HALİNİ KULLANICIYA SUNMADAN ÖNCE STRİNG HALE ÇEVİREN FONKSİYON
        {
            Encoding enc = System.Text.Encoding.ASCII;

            string binaryString = binaryal.Replace(" ", "");

            var bytes = new byte[binaryString.Length / 8];

            var binaryboyut = (int)(binaryString.Length / 8);

            for (var i = 0; i < binaryboyut; i++)
            {
                bytes[i] = Convert.ToByte(binaryString.Substring(i * 8, 8), 2);
            }

            string stringsonuc = enc.GetString(bytes);

            return stringsonuc;

        }

        public string KaristirSifrele(string KarisacakText)        //SPN ALGORİTMASI İÇİN ŞİFRELEME YAPARKEN KULLANILACAK BELİRLİ KARMA İŞLEMİNİ YAPACAK OLAN FONKSİYON
        {
            string KarisikText="";
            KarisikText += KarisacakText[2];
            KarisikText += KarisacakText[8];
            KarisikText += KarisacakText[12];
            KarisikText += KarisacakText[5];
            KarisikText += KarisacakText[9];
            KarisikText += KarisacakText[0];
            KarisikText += KarisacakText[14];
            KarisikText += KarisacakText[4];
            KarisikText += KarisacakText[11];
            KarisikText += KarisacakText[1];
            KarisikText += KarisacakText[15];
            KarisikText += KarisacakText[6];
            KarisikText += KarisacakText[3];
            KarisikText += KarisacakText[10];
            KarisikText += KarisacakText[7];
            KarisikText += KarisacakText[13];

            return KarisikText;

        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            oturumyaz.Text = GirisEkrani.kullaniciadi;
            CheckForIllegalCrossThreadCalls = false;//dinamik nesne eklemek için listeye
        }

        private string KaristirCoz(string KarisacakText)        //SPN ALGORİTMASI İÇİN ŞİFRE ÇÖZME İŞLEMİ YAPARKEN KULLANILACAK BELİRLİ KARMA İŞLEMİNİ YAPACAK OLAN FONKSİYON
        {
            string KarisikText = "";
            KarisikText += KarisacakText[5];
            KarisikText += KarisacakText[9];
            KarisikText += KarisacakText[0];
            KarisikText += KarisacakText[12];
            KarisikText += KarisacakText[7];
            KarisikText += KarisacakText[3];
            KarisikText += KarisacakText[11];
            KarisikText += KarisacakText[14];
            KarisikText += KarisacakText[1];
            KarisikText += KarisacakText[4];
            KarisikText += KarisacakText[13];
            KarisikText += KarisacakText[8];
            KarisikText += KarisacakText[2];
            KarisikText += KarisacakText[15];
            KarisikText += KarisacakText[6];
            KarisikText += KarisacakText[10];

            return KarisikText;

        }


        //---------------------------------------------------------------------------CLİENT İÇİN KODLAR--------------------------------------------------------------------------------


        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        byte[] receivedBuf = new byte[1024];//veri almak için yer ayırdık
        private void ReceiveData(IAsyncResult ar)//burası asenkron oldugu için hep çalışır thread gibi veriyi almak için
        {

            int listede_yok = 0;
            try
            {

                Socket socket = (Socket)ar.AsyncState;      //ASENKRON SOKETI ALIRIZ
                int received = socket.EndReceive(ar);       //VERININ TOPLAM UZUNLUGU
                byte[] dataBuf = new byte[received];        //VERIYI BYTE CEVIRDIK
                Array.Copy(receivedBuf, dataBuf, received);     //DATABUF=RECEIVEDBUF VE RECEIVED UZUNLUK
                string gelen = Encoding.ASCII.GetString(dataBuf).ToString();        //SERVERDAN GELEN MESAJ
                if (gelen.Contains("sil*"))
                {
                    string parcala = gelen.Substring(4, (gelen.Length - 4));
                    Console.WriteLine("degerim  " + parcala);
                    for (int j = 0; j < listBox1.Items.Count; j++)      // LIST BOXTANDA KALDIR
                    {
                        if (listBox1.Items[j].Equals(parcala))
                        {
                            listBox1.Items.RemoveAt(j);

                        }
                    }
                }
                else if (gelen.Contains("@"))       //IÇERISINDE @ IÇERIYORSA CLIENTI LISTEYE EKLICEZ
                {

                    for (int i = 0; i < listBox1.Items.Count; i++)      //LISTEDEKI ITEMLER KADAR DÖN
                    {
                        if (listBox1.Items[i].ToString().Equals(gelen))     //LISTEDE VARSA O CLIENT
                        {
                            listede_yok = 1;        //VAR
                        }
                    }
                    if (listede_yok == 0)       //YOKSA  EKLE CLIENTI
                    {
                        string ben = "@" + oturumyaz.Text;
                        if (ben.Equals(gelen))      //KENDIMI EKLEME
                        {

                        }
                        else
                        {
                            listBox1.Items.Add(gelen);
                        }
                    }

                }
                else
                {
                    rb_chat.AppendText(gelen + "\n");
                    metinkutusu1.Text = gelen;
                }

                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
              
            }
            catch (Exception e)
            {
                Console.WriteLine("ReceiveData() metodunda hata " + e.Message);
            }

        }

        private void SendLoop()
        {
            while (true)
            {

                byte[] receivedBuf = new byte[1024];
                int rev = _clientSocket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    rb_chat.AppendText("\nServer: " + Encoding.ASCII.GetString(data) + "\n");
                }
                else _clientSocket.Close();

            }
        }

        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)        //SERVER ÇALIŞMIYORSA(ÇALIŞISAYA KADAR DÖNGÜ DÖNER)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect("127.0.0.1", 100);        //127.0.0.1=IPADDRESS.LOOPBACK DEMEK 100 PORTUNA BAĞLAN
                }
                catch (SocketException)
                {
                    
                    Console.WriteLine("bağlantılar: " + attempts.ToString());
                }
            }

            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);        //ASYNCCALLBACK THREAD GIBI ASENKRON EŞ ZAMANSIZ ÇALIŞIYOR
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + oturumyaz.Text);     //ISMIMIZIN BAŞINA 2 TANE @@ KOYDUM BELLI OLSUN
            _clientSocket.Send(buffer);     //vveriyi gönderdik servera
            
            btnConnect.BackColor = Color.Lime;
            btnConnect.Text = "Sunucuya Bağlanıldı";
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(LoopConnect);
            t1.Start();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (_clientSocket.Connected)        //CLIENT SERVERA BAĞLI ISE
            {
                string tmpStr = "";
                foreach (var item in listBox1.SelectedItems)        //LISTBOXTAKI SEÇILI ITEMLERE
                {

                    tmpStr = listBox1.GetItemText(item);        //ISIMLERINI
                    txt_text.Text = ENGCevir(txt_text.Text);
                    byte[] buffer = Encoding.ASCII.GetBytes(tmpStr + " :" + txt_text.Text + "*" + oturumyaz.Text);      //byte çevir
                    _clientSocket.Send(buffer);     //VE GÖNDER IP VE PORTA
                    Thread.Sleep(20);

                }
                if (tmpStr.Equals(""))
                {
                    MessageBox.Show("lütfen listeden değer seçiniz");
                }
                else
                {
                    rb_chat.AppendText(oturumyaz.Text + ": " + txt_text.Text + "\n");
                   
                }


            }
        }
     

    }
}
