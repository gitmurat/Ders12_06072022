namespace _10_OOP_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UrunFiyati urunFiyati = new UrunFiyati(0.18m);

            urunFiyati.Tutar = 100;
            urunFiyati.Hakkında();
        }
    }
}