using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregameex
{
    class Warp
    {
        double v;
        int d;


        public int Travelled(double distance, int warp)
        {
           // Calculate(warp);
            v = (Math.Pow(warp, (10.0 / 3))) + Math.Pow((10 - warp), ((-11.0 / 3)));
            d = Convert.ToInt32((distance / v) * (365));
            return d;
        }

        //private void Calculate(int warp)
        //{
        //    v = (Math.Pow(warp, (10.0 / 3))) + Math.Pow((10 - warp), ((-11.0 / 3)));
        //}
    }
}
