using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateSalesLibrary;

namespace StateSales
{
    class Program
    {
        static void Main(string[] args)
        {  // namespace  .  class     variable = 
            StateSalesLibrary.StateSalesLibrary pgm = new StateSalesLibrary.StateSalesLibrary();


            var total = pgm.Get("IN") + pgm.Get("NY") + pgm.Get("MN");
            Console.WriteLine($"Sales for IN, NY, & MN are {total}");

            total = pgm.Get("KY") + pgm.Get("MI") + pgm.Get("PA") + pgm.Get("IL");
            Console.WriteLine($"Sales for KY, MI, PA, & IL are {total}");

        }
       
    }
}
