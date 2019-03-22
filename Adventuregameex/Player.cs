using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolTrader
{
    class Player
    {
        public double age = 20;
        public double days = 0;
        public decimal money;
        //public decimal fuel;

        public Location location;
        public List<Item> inventory = new List<Item>();

        public Player(Location location)
        {
            this.location = location;
            money = 1500M;
        }

        //public void FuelLoss()
        //{
        //    this.location = location;
        //    fuel -= 200M;
        //}
       

        public void TravelTo(Location destination, double warpSpeed)
        {
            var distance = location.DistanceTo(destination);
            var speed = WarpFormula.WarpSpeedToLightSpeed(warpSpeed);

            age += distance / speed;

            location = destination;
        }

        public void DaysTraveled(Location destination, double warpSpeed)
        {
            var distance = location.DistanceTo(destination);
            var speed = WarpFormula.WarpSpeedToLightSpeed(warpSpeed);

            days += distance / speed;

            location = destination;
        }

        public void BuyItem(Item item)
        {
            money -= location.CostOf(item);
            inventory.Add(item);
        }

        public void SellItem(Item item)
        {
            money += location.CostOf(item);
            inventory.Remove(item);
        }
    }
}
