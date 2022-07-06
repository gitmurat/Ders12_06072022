using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_Market_cont
{
    internal class Pill : Urun
    {
        public override string Marka => "Duracell";

        public override string Tip => "Pil";

        public override decimal VergiOrani => 0.18m;
    }
}
