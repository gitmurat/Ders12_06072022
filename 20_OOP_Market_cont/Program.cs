namespace _20_OOP_Market_cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sut sut = new Sut();
            sut.DiyetMi = true;
            sut.Hacim = "1 LT";

            Console.WriteLine(sut.Baslik);
        }
    }
}