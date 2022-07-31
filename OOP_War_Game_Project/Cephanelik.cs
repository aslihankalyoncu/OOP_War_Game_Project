using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Cephanelik
    {
        public IBileylenebilir Bileylenebilir { get; set; }
        public IYakinlastirilabiliyor Yakinlastirilabiliyor { get; set; }

        public List<Silah> Silahlar { get; set; }

        public Cephanelik()
        {
            Silahlar = new List<Silah>();
            Silah s1 = SilahOlustur(SilahCesitleri.Bicak);
            s1.Marka = "Rambo";
            s1.Model = "K500";
            s1.MaxAtisKapasitesi = 100;
            s1.TekAtisKapasitesi = 1;
            s1.CanAlmaDegeri = 5;
            Silahlar.Add(s1);

            Silah s2 = SilahOlustur(SilahCesitleri.Bicak);
            s2.Marka = "Rambo";
            s2.Model = "K700";
            s2.MaxAtisKapasitesi = 100;
            s2.TekAtisKapasitesi = 1;
            s2.CanAlmaDegeri = 8;
            Silahlar.Add(s2);

            Silah s3 = SilahOlustur(SilahCesitleri.Kasatura);
            s3.Marka = "KST";
            s3.Model = "K100";
            s3.MaxAtisKapasitesi = 100;
            s3.TekAtisKapasitesi = 1;
            s3.CanAlmaDegeri = 8;
            Silahlar.Add(s3);

            Silah s4 = SilahOlustur(SilahCesitleri.Tabanca);
            s4.Marka = "Altıpatlar";
            s4.Model = "A300";
            s4.MaxAtisKapasitesi = 6;
            s4.TekAtisKapasitesi = 1;
            s4.CanAlmaDegeri = 8;
            Silahlar.Add(s4);

            Silah s5 = SilahOlustur(SilahCesitleri.Tabanca);
            s5.Marka = "Su";
            s5.Model = "S1000";
            s5.MaxAtisKapasitesi = 15;
            s5.TekAtisKapasitesi = 1;
            s5.CanAlmaDegeri = 8;
            Silahlar.Add(s5);

            Silah s6 = SilahOlustur(SilahCesitleri.PompaliTufek);
            s6.Marka = "Poz";
            s6.Model = "P400";
            s6.MaxAtisKapasitesi = 5;
            s6.TekAtisKapasitesi = 1;
            s6.CanAlmaDegeri = 15;
            Silahlar.Add(s6);

            Silah s7 = SilahOlustur(SilahCesitleri.TaramaliTufek);
            s7.Marka = "Tara";
            s7.Model = "T600";
            s7.MaxAtisKapasitesi = 50;
            s7.TekAtisKapasitesi = 5;
            s7.CanAlmaDegeri = 10;
            Silahlar.Add(s7);

            Silah s8 = SilahOlustur(SilahCesitleri.Roketatar);
            s8.Marka = "Rot";
            s8.Model = "R100";
            s8.MaxAtisKapasitesi = 1;
            s8.TekAtisKapasitesi = 1;
            s8.CanAlmaDegeri = 40;
            Silahlar.Add(s8);

            Silah s9 = SilahOlustur(SilahCesitleri.Top);
            s9.Marka = "Guny";
            s9.Model = "G200";
            s9.MaxAtisKapasitesi = 1;
            s9.TekAtisKapasitesi = 1;
            s9.CanAlmaDegeri = 30;
            Silahlar.Add(s9);

        }

        public Silah SilahOlustur(SilahCesitleri silahCesit)
        {
            switch (silahCesit)
            {
                case SilahCesitleri.Bicak:
                    return new Bicak();

                case SilahCesitleri.Kasatura:
                    return new Kasatura();

                case SilahCesitleri.Tabanca:
                    return new Tabanca();

                case SilahCesitleri.PompaliTufek:
                    return new PompaliTufek();

                case SilahCesitleri.TaramaliTufek:
                    return new TaramaliTufek();

                case SilahCesitleri.Roketatar:
                    return new Roketatar();

                case SilahCesitleri.Top:
                    return new Top();

                default:
                    throw new ArgumentOutOfRangeException("SilahCesitleri");
            }

        }

        public string BileylemeYap()
        {
            return Bileylenebilir.Bileyle();
        }

        public string YakinlastirmaYap()
        {
            return Yakinlastirilabiliyor.Yakinlastir();
        }

        public enum SilahCesitleri
        {
            Bicak,
            Kasatura,
            Tabanca,
            PompaliTufek,
            TaramaliTufek,
            Roketatar,
            Top
        }
    }
}
