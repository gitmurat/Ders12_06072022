using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_Market_cont
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
        public abstract decimal VergiOrani { get; }

        public virtual string BaslikBelirle()
        {
        return Marka + " " + Tip;
        }

        public UrunFiyati UrunFiyati { get; set; }                  //public string yerine public ürünfiyatı

        public Urun()
        {
            UrunFiyati = new UrunFiyati(VergiOrani);               
            
            //Urun fiyatı classında yeni bir instance tanımlamak için vergi oranı almamız şart. Bu construtor yeni bir ürün yaratırken aynı zamanda bir ürünfiyatı instance'ını vergi oranına göre yaratıyor. Dolayısıyla her üründe bulunması gereken Ürün Fiyatı da otomatik olarak oluşturuluyor. Bu durumda derived class'ların her birinde vergi oranının tanımlanmış olması gerekir.
        }
    }
}
