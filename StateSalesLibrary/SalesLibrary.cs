using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSalesLibrary
{
    public class StateSalesLibrary
    {
        private Dictionary<string, int> StateSales = new Dictionary <string, int>();
                
        public int Get(string state)
        {
            return StateSales[state]; // call Dictionary calles StateSsles, by the Key which is State
        }

        public StateSalesLibrary()  //  constructor, has the name of the class
        {
            StateSales.Add("OH", 90416);
            StateSales.Add("KY", 77408);
            StateSales.Add("IN", 16588);
            StateSales.Add("PA", 55043);
            StateSales.Add("MI", 60099);
            StateSales.Add("NY", 19830);
            StateSales.Add("IL", 81154);
            StateSales.Add("WI", 11679);
            StateSales.Add("MN", 94207);
            StateSales.Add("MS", 93521);
        }
               
    }
}
