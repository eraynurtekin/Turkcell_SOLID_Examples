using System;

namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cokgenler cokgenler = new Cokgenler{ sekil = new Dikdörtgen()};
            SekilHesapla sekilHesapla = new SekilHesapla { Cokgenler =cokgenler };
            Console.WriteLine(sekilHesapla.AlanHesapla(5,6));

            Cokgenler cokgenler2 = new Cokgenler { sekil = new Ucgen() };
            SekilHesapla sekilHesapla2 = new SekilHesapla { Cokgenler = cokgenler2 };
            Console.WriteLine(sekilHesapla2.AlanHesapla(4,3));

            Cokgenler cokgenler3 = new Cokgenler { sekil = new Kare() };
            SekilHesapla sekilHesapla3 = new SekilHesapla { Cokgenler = cokgenler3 };
            Console.WriteLine(sekilHesapla3.AlanHesapla(8));

        }
    }

    public class SekilHesapla
    {
        public Cokgenler Cokgenler { get; set; }
        public double AlanHesapla(int kenar)
        {
            return Cokgenler.sekil.SekilAlaniHesapla(kenar);
        }
        public double AlanHesapla(int kenar1,int kenar2)
        {
            return Cokgenler.sekil.SekilAlaniHesapla(kenar1,kenar2);
        }

    }

}
