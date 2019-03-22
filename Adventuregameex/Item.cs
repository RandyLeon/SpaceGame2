using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolTrader
{
    class Item
    {
        public  string name;
        public  decimal cost;
        private string v1;
        private double v2;
        private decimal v3;

        public Item(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public Item(string v1, double v2, decimal v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
