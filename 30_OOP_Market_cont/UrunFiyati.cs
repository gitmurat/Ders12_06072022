using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_Market_cont
{
    internal class UrunFiyati
    {
        public decimal Tutar { get; set; }
        private decimal _VergiOrani;

        public decimal VergiOrani
        {
            get
            {
                return _VergiOrani;
            }
        }

        public decimal VergiTutari
        {
            get { return Tutar * _VergiOrani; }
        }

        public decimal Fiyat 
            { get { return Tutar + VergiTutari; } }

        public UrunFiyati (decimal vergiOrani)
        {
            
            _VergiOrani = vergiOrani;
        }

        public void Hakkında ()
        {
            Console.WriteLine("Tutar : " + Tutar);
            Console.WriteLine("Vergi Oranı: " + VergiOrani);
            Console.WriteLine("Vergi Tutarı: " + VergiTutari);
            Console.WriteLine("Fiyat : " + Fiyat);
        }
    }
}
