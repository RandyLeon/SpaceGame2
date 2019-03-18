using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregameex
{
    class Money
    {
        public static void money()
        {
            int fund = 1200;
            while (fund > 0)
            {
                fund -= 500;
                break;
            }
            Console.WriteLine($"Funds = {fund}");
            Console.WriteLine("Press 'Enter' to continue");
        }
    }
}
