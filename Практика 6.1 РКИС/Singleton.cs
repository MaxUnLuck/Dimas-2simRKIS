using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6._1_РКИС
{
    internal class Singleton
    {
        private static Singleton instance;
        private Singleton(){ }
        public static Singleton GetInstance() 
        {
            if (instance == null) 
            {
                instance = new Singleton();
            }
            return instance;
        }
        public List<string> cpu = new List<string>() 
        {
            "i7-3770","i5-12400f","Pentium-4(Адский разгон)","i3-228"
        };

        public List<string> ram = new List<string>()
        {
            "1Гб серверной","16Гб - HyperX furry","128Гб MSI"
        };

        public List<string> pb = new List<string>()
        {
            "KSAS","PowerMan"
        };

        public List<string> gc= new List<string>()
        {
            "RX 580 (разгон)","GTX 1060 (майнинг)","RTX 4060 (новая)"
        };

        public bool Explosion(int cpu_, int ram_, int pb_, int gc_) 
        {
            int rnd = 0;
            if (cpu_ == 2) 
            {
                rnd += 25;
            }
            if (ram_ == 0)
            {
                rnd += 25;
            }
            if (pb_ == 0)
            {
                rnd += 25;
            }
            if (gc_ == 0)
            {
                rnd += 25;
            }
            Random random = new Random();
            if (random.Next(0, 101) < rnd ) 
            {
                return true;
            }
            return false;
        }
    }
}
