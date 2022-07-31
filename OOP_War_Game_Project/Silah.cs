using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    public abstract class Silah
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int CanAlmaDegeri { get; set; } //bir kullanımda karşı tarafın can değerini azaltma
        public int MaxAtisKapasitesi { get; set; } //maximmum atabileceği atış veya kapasite
        public int TekAtisKapasitesi { get; set; } // bir atışta ne kadar mermi kullnadığı



        public abstract int CanAl();
        public abstract int AtisKapasitesiniAzalt();

    }
}