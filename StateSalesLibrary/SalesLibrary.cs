using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSalesLibrary
{
    public class SalesLibrary
    {
        private Dictionary<string, int> Sales = new Dictionary <string, int>();
        public void Add(string state, int sales)
        {
            Sales.Add(state, sales);           
        }
        public int Get(string state)
        {
            return Sales[state];
        }

    }
}
