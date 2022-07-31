using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Oyun
    {
        public Karakter Oyuncu { get; set; }
        public Haritalar Haritalar { get; set; }
        public Harita OyuncuSecilenHarita { get; set; }
        public Cephanelik Cephane { get; set; }
        public List<Dusman> Dusmanlar { get; set; }

        public Oyun()
        {
            Oyuncu = new Karakter();
            Cephane = new Cephanelik();
            Haritalar = new Haritalar();
            Dusmanlar = new List<Dusman>();
        }

        public void KarakterOlustur(string ad)
        {
            Oyuncu.KarakterAdi = ad;
            Oyuncu.KarakterCanDegeri = 100;
            Oyuncu.KarakterinSilahlari = new List<Silah>();
        }

        public string HaritalariListele()
        {
            string pano = "";
            int sayac = 1;
            foreach (Harita item in Haritalar.HaritalarListe)
            {
                pano += $"{sayac} - Harita adı : {item.HaritaAdi}\n";
                sayac++;
            }
            return pano;

        }

        public void HaritaSec(int secim)
        {
            int counter = 1;

            foreach (Harita item in Haritalar.HaritalarListe)
            {
                if (counter == secim)
                {
                    this.OyuncuSecilenHarita = item;
                    break;
                }
                counter++;
            }
        }

        public string CephanedekiSilahlariListele()
        {
            string pano = "";
            int counter = 1;
            foreach (Silah item in Cephane.Silahlar)
            {
                pano += $"{counter} - Marka: {item.Marka} - Model: {item.Model}\n";
                counter++;
            }

            return pano;
        }

        public void SilaSec(int secim1, int secim2, int secim3)
        {
            Silah temp = null;

            int[] arr = new int[3] { secim1, secim2, secim3 };
            for (int i = 0; i < 3; i++)
            {
                int counter = 1;
                foreach (Silah item in Cephane.Silahlar)
                {
                    if (counter == arr[i])
                    {
                        temp = item;

                        break;
                    }
                    counter++;

                }
                Oyuncu.KarakterinSilahlari.Add(temp);
            }

        }

        public void DusmanOlustur()
        {
            Dusman tempDusman = new Dusman();
            Random rand = new Random();
            int can = rand.Next(30, 70);
            tempDusman.DusmanCanDegeri = can;

            int rastgelesilah = rand.Next(1, Cephane.Silahlar.Count);
            int counter = 1;

            foreach (Silah item in Cephane.Silahlar)
            {
                if (counter == rastgelesilah)
                {
                    tempDusman.DusmanSilahi = item;
                }
                counter++;
            }
            Dusmanlar.Add(tempDusman);
        }
        public void Duellolar()
        {
            int duelloSayac = 1;
            int sonuc = 0;
            foreach (Dusman item in Dusmanlar)
            {
                Utils.EkranaYazdir("------------------------\n");
                Utils.EkranaYazdir($"------  {duelloSayac}. Düello ------\n");
                Utils.EkranaYazdir("------------------------\n");
                Duello temp = new Duello(Oyuncu, item);

                int a = temp.Saldiri();

                if (a == 1) // oyuncu kazandı düelloyu
                {
                    Utils.EkranaYazdir("Oyuncu kazandı düelloyu\n");
                    sonuc++;
                }
                else if (a == 2) // düşman kazandı düelloyu
                {
                    Utils.EkranaYazdir("Düşman kazandı düelloyu\n");
                    sonuc = -1;
                    break;
                }
                else if (a == 3) //düşmanın atış kapasitesi kalmadı ve oyunu kaybeder düşman
                {
                    Utils.EkranaYazdir("Düşmanın atış kapasitesi kalmadı ve düşman oyunu kaybeder\n");
                    sonuc++;
                }
                else if (a == 4) // oyuncunun saldırıda atış kapasitesi kalmadı
                {
                    Utils.EkranaYazdir("Oyuncunun sadırıda atış kapasitesi kalmadı\n");
                    sonuc = -1;
                    break;
                }
                duelloSayac++;
            }
            if (sonuc > 0)
            {
                Utils.EkranaYazdir("----- OYUN KAZANILDI -----\n");
            }
            else
            {
                Utils.EkranaYazdir("Oyuncu öldü. Oyun kaybedildi...\n");
                Utils.EkranaYazdir("----- SON -----\n ");
            }
        }

        public void OyunBasla()
        {
            Utils.EkranaYazdir("-----------------------------------\n");
            Utils.EkranaYazdir("------- TechCareer War Game -------\n");
            Utils.EkranaYazdir("-----------------------------------\n");

            string giris = "";

            Utils.EkranaYazdir("Karakter oluşturma:\n");
            Utils.EkranaYazdir("Karakter için ad giriniz: ");
            giris = Utils.GirisAl();
            Utils.EkranaYazdir("Karakter oluşturuluyor...\n");
            this.KarakterOlustur(giris);

            Utils.EkranaYazdir("HARİTALAR\n");
            Utils.EkranaYazdir(HaritalariListele() + "\n");
            Utils.EkranaYazdir("Harita Seçimi için giriş yapınız:\n");
            int secim = Utils.SecimAl(this.Haritalar.HaritalarListe.Count);
            HaritaSec(secim);
            Utils.EkranaYazdir($"Haritanız : {OyuncuSecilenHarita.HaritaAdi}\n");
            Utils.EkranaYazdir($"Haritada savaşacağınız düşman sayısı {OyuncuSecilenHarita.HaritaDusmanSayisi}\n");

            for (int i = 0; i < OyuncuSecilenHarita.HaritaDusmanSayisi; i++)
            {
                DusmanOlustur();
            }


            Utils.EkranaYazdir("----- Silah Seçimi -----\n");
            Utils.EkranaYazdir("Cephaneden kullanacağınız 3 adet silah seçimi yapınız\n");
            Utils.EkranaYazdir("----- CEPHANELİK -----\n");

            int[] arrSecim = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Utils.EkranaYazdir(CephanedekiSilahlariListele());

                Utils.EkranaYazdir("Seçiminiz : ");
                arrSecim[i] = Utils.SecimAl(Cephane.Silahlar.Count);

            }
            Utils.EkranaYazdir(CephanedekiSilahlariListele() + "\n");

            SilaSec(arrSecim[0], arrSecim[1], arrSecim[2]);


            Utils.EkranaYazdir("Düellolar başlıyor...\n");
            Utils.EkranaYazdir("-------------------------\n");
            Utils.EkranaYazdir("------- DÜELLOLAR -------\n");
            Utils.EkranaYazdir("-------------------------\n");
            Duellolar();
        }
    }
}
