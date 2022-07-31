using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    class Top : Silah
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

    }
}
