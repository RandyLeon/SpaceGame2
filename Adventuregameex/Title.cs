using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregameex
{
    class Title
    {
        public static void title()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"


      ███████╗ ██████╗ ██╗         ████████╗██████╗  █████╗ ██████╗ ███████╗██████╗                =        
      ██╔════╝██╔═══██╗██║         ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗              /.\
      ███████╗██║   ██║██║            ██║   ██████╔╝███████║██║  ██║█████╗  ██████╔╝             /...\
      ╚════██║██║   ██║██║            ██║   ██╔══██╗██╔══██║██║  ██║██╔══╝  ██╔══██╗            /.....\
      ███████║╚██████╔╝███████╗       ██║   ██║  ██║██║  ██║██████╔╝███████╗██║  ██║           |... ...|        
      ╚══════╝ ╚═════╝ ╚══════╝       ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝           |..   ..| 
                                                                                               |.     .|
                                                                                               |..   ..|
                                                                                               |... ...|     
                                                                                             _/.........\_
                                                                                            /.\........./.\
                                                                                           /...\......./...\
                                                                                          /.....\...../.....\
                                                                                         /_______\.../_______\
                                                                                                  \./
                                                                                                   _
                                                                                                  ___
                                                                                                _______ ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 'Enter' to begin your adventure\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            string myText = "Welcome to SOL TRADER brave adventurer!\n\n" +
                "The year is 2147. Exploring the stars has become a hobby for many as space travel become commonplace.\n" +
                "You have just from the stellar business academy with a degree in intergalactic finance! Well done.\n" +
                "While is school unfortunately your wife left you and took the kids, also your father got sick and died.\n" +
                "This is great news, now that your only family has left you you're free to roam the stars whenever you want.\n" +
                "Your deceased father left you his most prized possesion, The Millenium Space Rat! Its not much but it\n" +
                "will get the job done for now, once you get going you can buy yourself a new ship. Unless you end up\n" +
                "dying alone in the infinite abyss of space... Well anyways, GOOD LUCK in your travels.\n\n" +
                "Press 'Enter' to continue";

            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i]);
                System.Threading.
                Thread.Sleep(5);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
