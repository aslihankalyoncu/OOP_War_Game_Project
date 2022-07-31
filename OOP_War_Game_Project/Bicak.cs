using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Bicak : Silah, IBileylenebilir
    {
        public string Bileyle()
        {
            return "Bıçak bileyleniyor...";
        }

        public override int CanAl()
        {
            return this.CanAlmaDegeri;
        }
        public override int AtisKapasitesiniAzalt()
        {
            return this.MaxAtisKapasitesi;
        }
    }
}
