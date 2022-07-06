namespace _30_OOP_Market_cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pill pill = new Pill();

            Console.WriteLine("Yeni ürün");
            Console.WriteLine("");
            Console.WriteLine(pill.Baslik);

            Console.WriteLine("-----------------------------------");

            pill.UrunFiyati.Tutar = 200;

            pill.UrunFiyati.Hakkında();

            Console.WriteLine("");
            Console.WriteLine("Yeni ürün");
            Console.WriteLine("");

            Sut sut = new Sut();

            sut.DiyetMi = true;
            sut.Hacim = "1 LT";

            Console.WriteLine(sut.Baslik);

            Console.WriteLine("-----------------------------------");

            sut.UrunFiyati.Tutar = 50;

            sut.UrunFiyati.Hakkında();


        }
    }
}