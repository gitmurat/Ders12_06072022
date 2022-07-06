using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_Market_cont
{
    abstract class GidaUrun : Urun
    {
        public bool DiyetMi { get; set; }
        public override decimal VergiOrani => 0.01m;

        public override string BaslikBelirle()
        {
            string sonuc =  base.BaslikBelirle() + " ";

            if (this.DiyetMi)
                sonuc += "(diyet) ";
            return sonuc;
        }
    }
}
