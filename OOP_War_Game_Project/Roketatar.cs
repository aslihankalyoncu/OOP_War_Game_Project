using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Roketatar : Silah, IYakinlastirilabiliyor
    {
        public override int AtisKapasitesiniAzalt()
        {
            this.MaxAtisKapasitesi -= this.TekAtisKapasitesi;
            return this.MaxAtisKapasitesi;
        }

        public override int CanAl()
        {
            return this.CanAlmaDegeri;
        }

        public string Yakinlastir()
        {
            return $"{this.Marka} {this.Model}'in yakınlaştırma özelliği aktifleştiriyor...";
        }
    }
}
