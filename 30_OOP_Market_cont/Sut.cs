using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_Market_cont
{
    internal class Sut : GidaUrun
    {
        public override string Tip => "Süt";
        public override string Marka => "Pınar";
        //public override decimal VergiOrani => 0.08m; GıdaUrun sınıfında vergi oranı belirlendiği için burada belirlemeye gerek yok.
        public string Hacim { get; set; }

        public override string BaslikBelirle()
        {

            string sonuc = base.BaslikBelirle() + " ";
            sonuc += Hacim + " ";
            return sonuc;
        }
    }
}
