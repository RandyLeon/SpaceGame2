using System.Collections.Generic;
using System;
using System.Linq;

//namespace Adventuregameex
//{
//    public class Planet
//    {
//        public static void planetList()
//        {
//            List<string[]> Planet = new List<string[]>();
//            string[] PlanetsArray = new string[5];
//            Console.WriteLine("");
//            PlanetsArray[0] = "1. Earth";
//            PlanetsArray[1] = "2. Reach";
//            PlanetsArray[2] = "3. Pandora";
//            PlanetsArray[3] = "4. Tuffle";
//            PlanetsArray[4] = "5. Krypton";

//            Console.ResetColor();
//            PlanetsArray.ToList().ForEach(Console.WriteLine);
//            Console.WriteLine("Choose which planet you want to go to");
//            int planet = int.Parse(Console.ReadLine());
//            double age = 20;
//            double percent;

//            switch (planet)
//            {
//                case 1:
//                    Console.Clear();

//                    Console.WriteLine("You have arrived at Earth.");
//                    double d = WarpEarth();
//                    Console.WriteLine($"you travelled for {d} days");
//                    percent = d / 365 + age;
//                    Console.WriteLine($"You are {percent} years old.");
//                    Console.ForegroundColor = ConsoleColor.DarkGreen;
//                    Console.WriteLine(@"
//              _-o#&&*****?d:>b-_
//          _o/,`,,  ..,, dMF9MMMMMHo_
//       .o&#'        `,MbHMMMMMMMMMMMHo.
//     .o,, ,         vodM*$&&HMMMMMMMMMM?.
//    ,'              $M&ood,~-`(&##MMMMMMH\
//   /               ,MMMMMMM#b?#bobMMMMHMMML
//  &              ?MMMMMMMMMMMMMMMMM7MMM$R*Hk
// ?$.            :MMMMMMMMMMMMMMMMMMM/HMMM|`*L
//|               |MMMMMMMMMMMMMMMMMMMMbMH   T,
//$H#:            `*MMMMMMMMMMMMMMMMMMMMb#}'  `?
//]MMH#             ""*""""*#MMMMMMMMMMMMM'    -
//MMMMMb_                   |MMMMMMMMMMMP      :
//HMMMMMMMHo                 `MMMMMMMMMT       .
//?MMMMMMMMP                  9MMMMMMMM}       -
//-?MMMMMMM                  |MMMMMMMMM?,d-    ,
// :|MMMMMM-                 `MMMMMMMT .M|.   :
//  .9MMM[                    &MMMMM*' `'    .
//   :9MMk                    `MMM#         -
//     &M                      `          .-
//      `&.                             .
//        `~,   .                     ./
//            . _                  .-
//              '`--.-,dd###pp==+'
//                    ");
//                    Console.ResetColor();
//                    Console.WriteLine("Press 'Enter' to continue");
//                    Console.ReadLine();
//                    break;
//                case 2:
//                    Console.Clear();
//                    Console.WriteLine("You have arrived at Reach.");
//                    d = WarpReach();
//                    Console.WriteLine($"you travelled for {d} days");
//                    percent = d / 365 + age;
//                    Console.WriteLine($"You are {percent} years old.");
//                    Console.ForegroundColor = ConsoleColor.Yellow;
//                    Console.WriteLine(@"
//                       ,.ood888888888888boo.,
//                 .od888P^""            ""^Y888bo.
//             .od8P''   ..oood88888888booo.    ``Y8bo.
//          .odP''  .ood8888888888888888888888boo.  '`Ybo.
//        .d8'   od8'd888888888f`8888't888888888b`8bo   `Yb.
//       d8'  od8^   8888888888[  `'  ]8888888888   ^8bo  `8b
//     .8P  d88'     8888888888P      Y8888888888     `88b  Y8.
//    d8' .d8'       `Y88888888'      `88888888P'       `8b. `8b
//   .8P .88P            """"            """"                Y88. Y8.
//   88  888                                              888  88
//   88  888                                              888  88
//   88  888.        ..                        ..        .888  88
//   `8b `88b,     d8888b.od8bo.      .od8bo.d8888b     ,d88' d8'
//    Y8. `Y88.    8888888888888b    d8888888888888    .88P' .8P
//     `8b  Y88b.  `88888888888888  88888888888888'  .d88P  d8'
//       Y8.  ^Y88bod8888888888888..8888888888888bod88P^  .8P
//        `Y8.   ^Y888888888888888LS888888888888888P^   .8P'
//          `^Yb.,  `^^Y8888888888888888888888P^^'  ,.dP^'
//             `^Y8b..   ``^^^Y88888888P^^^'    ..d8P^'
//                 `^Y888bo.,            ,.od888P^'
//                      '`^^Y888888888888P^^''
                   
//        ");
//                    Console.ResetColor();
//                    Console.WriteLine("Press 'Enter' to continue");
//                    Console.ReadLine();
//                    break;
//                case 3:
//                    Console.Clear();
//                    d = WarpPandora();
//                    Console.WriteLine("You have arrived at Pandora.");
//                    Console.WriteLine($"you travelled for {d} days");
//                    percent = d / 365 + age;
//                    Console.WriteLine($"You are {percent} years old.");
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine(@"
//         ___---___                    
//      .--         --.      
//    ./   ()      .-. \.
//   /   o    .   (   )  \
//  / .            '-'    \         
// | ()    .  O         .  |      
//|                         |      
//|    o           ()       |
//|       .--.          O   |            
// | .   |    |            |
//  \    `.__.'    o   .  /    
//   \                   /                   
//    `\  o    ()      /'         
//      `--___   ___--'
//            ---
//                   ");
//                    Console.ResetColor();
//                    Console.WriteLine("Press 'Enter' to continue");
//                    Console.ReadLine();
//                    break;
//                case 4:
//                    Console.Clear();
//                    d = WarpTuffle();
//                    Console.WriteLine("You have arrived at Tuffle.");
//                    Console.WriteLine($"you travelled for {d} days");
//                    percent = d / 365 + age;
//                    Console.WriteLine($"You are {percent} years old.");
//                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
//                    Console.WriteLine(@"
//              __...----...__
//           .-' -=;::;::`;:::`-.
//        .-' ; `-;:"";`-;   ,;;'`-.
//      .'' ;;:     ,..   `.;;. .';;'.
//     /  ,;;::,     `--'  ,.;: ::  .;:\
//    ..- .; ;:,;,,.,   ,  ;;: ::;;:..;:.
//   ;   ;    .;::,    ;:.;:::::::::;., ;
//   |;. :      ;:;       `-;:::::-'""  |
//   | ;,'  ,;::     ;.     `-;::  `;:::|
//   ;`-;.   ,;:  ,;; `.  ."";,     ;;, ;
//   '. ."".,        "".    ,;:;  '.,;::.
//    `.                              .'
//      `.                          .'
//        `-.                    .-'
//           ""--...______...--""
//                            ");
//                    Console.ResetColor();
//                    Console.WriteLine("Press 'Enter' to continue");
//                    Console.ReadLine();
//                    break;
//                case 5:
//                    Console.Clear();
//                    d = WarpKrypton();
//                    Console.WriteLine("You have arrived at Kryton.");
//                    Console.WriteLine($"you travelled for {d} days");
//                    percent = d / 365 + age;
//                    Console.WriteLine($"You are {percent} years old.");
//                    Console.ForegroundColor = ConsoleColor.DarkYellow;
//                    Console.WriteLine(@"
//  ___  _____    
// .'/,-Y'     '~-.  
// l.Y             ^.           
// /\               _\_      'Doh!'   
//i            ___/'   '\ 
//|          /'   '\   o !   
//l         ]     o !__./   
// \ _  _    \.___./    '~\  
//  X \/ \            ___./  
// ( \ ___.   _..--~~'   ~`-.  
//  ` Z,--   /               \    
//    \__.  (   /       ______) 
//      \   l  /-----~~' /      
//       Y   \          / 
//       |    'x______.^ 
//       |           \    
//       j            Y

//                           ");
//                    Console.ResetColor();
//                    Console.WriteLine("Press 'Enter' to continue");
//                    Console.ReadLine();
//                    break;
//                default:
//                    {
//                        Console.WriteLine("Sorry, thats not a planet we can reach in your lifetime");
//                        Console.WriteLine("Press 'Enter' to continue");
//                        Console.ReadLine();
//                        Console.Clear();
//                        planetList();
//                        break;
//                    }
//            }
//        }

//        private static double WarpKrypton()
//        {
//            double d;
//            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
//            d = Convert.ToInt32((240 / v) * (365));
//            return d;
//        }

//        private static double WarpTuffle()
//        {
//            double d;
//            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
//            d = Convert.ToInt32((120 / v) * (365));
//            return d;
//        }

//        private static double WarpPandora()
//        {
//            double d;
//            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
//            d = Convert.ToInt32((60 / v) * (365));
//            return d;
//        }

//        private static double WarpReach()
//        {
//            double d;
//            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
//            d = Convert.ToInt32((30 / v) * (365));
//            return d;
//        }

//        private static double WarpEarth()
//        {
//            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
//            double d = Convert.ToInt32((15 / v) * (365));
//            return d;
//        }
//    } 

//}