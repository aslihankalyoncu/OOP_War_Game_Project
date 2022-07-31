using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Kasatura : Silah, IBileylenebilir
    {
        public override int AtisKapasitesiniAzalt()
        {
            return this.MaxAtisKapasitesi;

        }
        public string Bileyle()
        {
            return "Kasatura bileyleniyor...";
        }

        public override int CanAl()
        {
            return this.CanAlmaDegeri;
        }
    }
}
