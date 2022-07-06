using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Market_cont
{
    abstract class Urun
    {
        public abstract string Marka { get; }
        public abstract string Tip { get; }
        public string Baslik
        {
            get
            {
                return BaslikBelirle();
            }
        }

        public virtual string BaslikBelirle()
        {
        return Marka + " " + Tip;
        }

        public decimal Fiyat { get; set; }
    }
}
