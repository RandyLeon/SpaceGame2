using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolTrader
{
    class Location
    {
       public string name;
       public string description;

       double xPos;
       double yPos;

       decimal tradeRate;
       decimal fuel;

       public List<Item> items;

       public Location(string name, string description, double xPos, double yPos, List<Item> items, decimal tradeRate = 1.0M,decimal fuel = 10000)
       {
          this.name = name;
          this.description = description;
          this.xPos = xPos;
          this.yPos = yPos;
          this.tradeRate = tradeRate;
          this.items = items;
          this.fuel = fuel;
       }

       public double DistanceTo(Location destination)
       {
          var left = Math.Pow(this.xPos - destination.xPos, 2);
          var right = Math.Pow(this.yPos - destination.yPos, 2);

          return Math.Sqrt(left + right);
       }

          public decimal CostOf(Item item) =>
          item.cost * tradeRate;

        
    }
}
