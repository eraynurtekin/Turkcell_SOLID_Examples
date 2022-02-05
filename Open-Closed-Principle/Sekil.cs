using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public abstract class Sekil
    {
        public abstract double SekilAlaniHesapla(int kenar1);
        public abstract double SekilAlaniHesapla(int kenar1,int kenar2);
        
        
    }

    public class Kare : Sekil
    {
        public override double SekilAlaniHesapla(int kenar1)
        {
            return kenar1 * kenar1;
        }

        public override double SekilAlaniHesapla(int kenar1, int kenar2)
        {
            return 0;
        }
    }
    public class Dikdörtgen : Sekil
    {
        public override double SekilAlaniHesapla(int kenar1, int kenar2)
        {
            return kenar1 * kenar2;
        }
        public override double SekilAlaniHesapla(int kenar1)
        {
            return 0;
        }


    }
    public class Ucgen : Sekil
    {
        public override double SekilAlaniHesapla(int kenar1)
        {
            return 0;
        }

        public override double SekilAlaniHesapla(int kenar1, int kenar2)
        {
            return (kenar1 * kenar2) / 2;
        }
    }
}
