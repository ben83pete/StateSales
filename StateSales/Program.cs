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
        {
            var stateSales = new StringDictionary();
            
            stateSales.Add("OH", 90416);
            stateSales.Add("KY", 77408);
            stateSales.Add("IN", 16588);
            stateSales.Add("PA", 55043);
            stateSales.Add("MI", 60099);
            stateSales.Add("NY", 19830);
            stateSales.Add("IL", 81154);
            stateSales.Add("WI", 11679);
            stateSales.Add("MN", 94207);
            stateSales.Add("MS", 93521);



            Console.WriteLine($"The person with Key # 42 is {stateSales.Get(42)}");

        }
       
    }
}
