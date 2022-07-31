using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_War_Game_Project.Cephanelik;
using static OOP_War_Game_Project.Utils;

namespace OOP_War_Game_Project
{
    class Duello
    {
        Karakter Karakter { get; set; }
        Dusman DuelloDusman { get; set; }
        Silah SaldırıAnıKarakterSilah { get; set; }


        public Duello(Karakter oynKarakter, Dusman dusman)
        {
            this.Karakter = oynKarakter;
            this.DuelloDusman = dusman;
        }

        public int Saldiri()
        {
            int saldiriSayisi = 1;


            while (true)
            {
                if (this.Karakter.KarakterinSilahlari.Count == 0)
                {
                    return 4; // oyuncunun sadırıda atış kapasitesi kalmadı
                }

                if (saldiriSayisi % 2 == 1) // oyuncu saldırısı
                {

                    Utils.EkranaYazdir("Oyuncu saldırıyor...\n");

                    Utils.EkranaYazdir(KullanılabilirSilahListele() + "\n");//atış kapsitesi olanları listele
                    Utils.EkranaYazdir("Silah seçin: ");

                    int maxLimit = this.Karakter.KarakterinSilahlari.Count;
                    SilahSec(SecimAl(maxLimit)); // saldırı öncesi silah seçimi - oyuncu



                    this.DuelloDusman.DusmanCanDegeri -= this.SaldırıAnıKarakterSilah.CanAl();
                    this.SaldırıAnıKarakterSilah.AtisKapasitesiniAzalt();
                    SaldiriSonrasiSilahGuncelle(); //atış kapasite kontrol
                    SaldiriSonrasiSilahIslem(SaldırıAnıKarakterSilah);

                    if (this.DuelloDusman.DusmanCanDegeri <= 0)
                    {
                        return 1; //düşman can değeri 0 oldu
                    }
                }
                else // düşman saldırısı
                {
                    Utils.EkranaYazdir("Düşman saldırıyor...\n");
                    this.Karakter.KarakterCanDegeri -= this.DuelloDusman.DusmanSilahi.CanAl();
                    this.DuelloDusman.DusmanSilahi.AtisKapasitesiniAzalt();
                    if (this.Karakter.KarakterCanDegeri <= 0)
                    {
                        return 2; //oyuncunun can değeri 0 oldu
                    }
                    if (this.DuelloDusman.DusmanSilahi.MaxAtisKapasitesi < this.DuelloDusman.DusmanSilahi.TekAtisKapasitesi)
                    {
                        return 3; //düşmanın atış kapasitesi kalmadı ve
                                  //düşman oyunu kaybeder düşman
                    }
                }
                saldiriSayisi++;
            }
        }

        public void SaldiriSonrasiSilahGuncelle() //atış kapasitesi olmayan silahları çıkartılır
        {
            foreach (Silah item in Karakter.KarakterinSilahlari)
            {
                if (item.MaxAtisKapasitesi < item.TekAtisKapasitesi)
                {
                    Karakter.KarakterinSilahlari.Remove(item);
                    break;
                }
            }
        }

        public string KullanılabilirSilahListele()
        {
            string pano = "";
            int counter = 1;
            foreach (Silah item in Karakter.KarakterinSilahlari)
            {
                pano += $"{counter} - Marka: {item.Marka} - Model: {item.Model}\n";
                counter++;
            }

            return pano;
        }

        public void SilahSec(int secim)
        {

            int sayac = 1;
            foreach (Silah item in Karakter.KarakterinSilahlari)
            {
                if (sayac == secim)
                {
                    this.SaldırıAnıKarakterSilah = item;
                }
                sayac++;
            }
        }

        public void SaldiriSonrasiSilahIslem(Silah silah)
        {
            if (silah.GetType().Name == Enum.GetName(typeof(SilahCesitleri), SilahCesitleri.Bicak))
            {
                IBileylenebilir b = new Bicak();
                Utils.EkranaYazdir(b.Bileyle() + "\n");
            }
            else if (silah.GetType().Name == Enum.GetName(typeof(SilahCesitleri), SilahCesitleri.Kasatura))
            {
                IBileylenebilir k = new Kasatura();
                Utils.EkranaYazdir(k.Bileyle() + "\n");
            }
        }
    }
}


