using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Harita
    {
        public string HaritaAdi { get; set; }
        public int HaritaDusmanSayisi { get; set; }

        public Harita(string haritaAdi, int haritaDusmanSayisi)
        {
            this.HaritaAdi = haritaAdi;
            this.HaritaDusmanSayisi = haritaDusmanSayisi;

        }
    }
}
