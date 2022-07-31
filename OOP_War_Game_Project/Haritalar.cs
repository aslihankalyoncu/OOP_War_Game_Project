using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Haritalar
    {
        public List<Harita> HaritalarListe { get; set; }
        public Haritalar()
        {
            HaritalarListe = new List<Harita>();
            HaritaEkle();
        }

        public void HaritaEkle()
        {
            HaritalarListe.Add(new Harita("Vahşi Batı", 5));
            HaritalarListe.Add(new Harita("Hayalet Şehir", 3));
            HaritalarListe.Add(new Harita("Eski Altın Madeni", 4));
            HaritalarListe.Add(new Harita("Kuzey Ormanı", 7));
        }


    }
}
