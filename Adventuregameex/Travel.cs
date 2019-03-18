using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregameex
{
    class Travel
    {
        public static void gameTitle()
        {
            Title.title();
            first();
        }

        public static void first()
        {
            List<string[]> Planet = new List<string[]>();
            string[] PlanetsArray = new string[5];
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            PlanetsArray[0] = "1. Earth";
            PlanetsArray[1] = "2. Reach";
            PlanetsArray[2] = "3. Pandora";
            PlanetsArray[3] = "4. Tuffle";
            PlanetsArray[4] = "5. Krypton";

            Console.ResetColor();
            PlanetsArray.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("Choose which planet you want to go to");
            int planet = int.Parse(Console.ReadLine());
            double age = 20;
            double percent;

            switch (planet)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("You have arrived at Earth.");
                    double d = WarpEarth();
                    Console.WriteLine($"you travelled for {d} days");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@"
                                           ?O,                              
                                           =?Z7
                            ~I++?+??$OOZOO$=+I7
                  Z=     ~?=+==+++++??ZZZOZZZ$I.                    
                  OZI=.,?==?$OOZ$$ZZI+?$Z$ZZZOZZ,                      
                   +=I$=?O8I7$$$Z$$$77I+7OZZZOZOOZ:                     
                   +77+ID7$7=~=+==?OZZI7+ZZ$ZZOOZZZ$                      
                   =I=I87=+D ~,~~==I8? OZ7I7Z$$ZZZZZZZ$
                   .,I? ZO+O:..,...,:~~=+7OO+$$$$ZZZZZZOZ                 
                  $7+$+=.........,:~=+?$877$ZZZZZZZZZZO$I
                 $I77 ~~,,.........,~~++?I8I$$ZZ$$OZZOZOOZ$?             
                I7II7=:.......:MDN8DN=+I? Z7$$$$$Z$ZZZOZZZZZ?               
                777II=:,.....?DN?8OODD? I?I$$$7777$7$ZZZZOOOZI
               I777II ~~,....NN8ZMMMMNO8? I7Z7$$7$7$7ZZZZZOOOZ$$          
               $$77II=~~,..,.DO8MMMMM$8II7Z7$7$77$ZZZZOOOOOOOZZ$Z7
              Z$77II7++=:::::MO88MMM?$N77$77$$$ZZZZZOOOO888OOOOOZZ$Z:
             $$7II?+?II?==~~=~MZ$7I$IZI$$777$$ZOO88OOOOO888888OOZO$$$7ZO
           ,$Z$77I???+II?++++=+=+7$?I77$??I7$ZZZOZOO$$OOO88OOZ$7.$OZ7$Z7ZZO ~
           $$$7777I?+?+77I???????I777$=I? I7$$$ZOOZD7$ZOOOOOOZ$$7    7ZZ$$ZZZ7:
          $Z$$$ZZOZ$??+I=77$77777$+~?8?++II7$$$$ZM? ZZZOZZZZZ$$$7        I?$O$
         ?$Z$$ZOO8O$7I?+=O7??==+?ZZ?++=+?III7Z8MN7OZZZZZZZZZ$$7I       +?$Z$
         77ZZ$OO$7DOZ7II???++++====~===++?8DN8Z8? OOZZZOZZZ$$$$7:     :?IZZ
         $7$O=$OOZ$I$77I???++++=======~+O8NOZZZ$??ZZZZZZZZZ$$$7I     :?$Z$     
       $I7Z$.$OOZ$$?$M8OZ?++=+~=~+OD8O8ZMZ$ZM8+$OOOOOOZZZZ$$77+    ?IZZ=      
      $I7$Z   OOZOZO? I8+$++$II7ZN7$NNNNNDNNZ?+ZOOOOZOZZZZ$$$$$I??+?IZ7
      I7$$O    $OOOZOO+?IOO78MMMMMDNDD8O88=?+IOOOOOZZZZZZZ$$$I+I???78+        
   ,=7$Z$      888OOZ8O?++O=MNMMDO8OI,:+??7OOOOOOZZZZZZ$$$$I???77ZO$         
   ,7I??+       88OOOOOO8II++????++++?I$OO88OOOOOZZZZZZ$$IOI$$7I8O:           
     87?+?7      78O888OO888OZ777$$ZO8ZO8O8OOOOOZZZZ$$$7IIOO$?Z87
       D$?+?,    ,=888OO8OOOOOOOOOOOO8OOOOOOOZZ$$Z$$77IZOO+.OOZ$Z
          8II+7:I$7ZO888O888OOOOOOOO8OOOOZZZZZ$$$$$I?OOZZZ7           
            $?I?ZOOO88OOOOOOOOOOOOOOZZZ$ZZZ$$$7$I?    
              88D8OOO$78$$ZZO8OOOOOOZZZOZZZ$$$,          
               OO8D8888OI7$$7,,.~+II7II?~                  
                D888O,+?7$$       ");
                    Console.ResetColor();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You have arrived at Reach.");
                    d = WarpReach();
                    Console.WriteLine($"you travelled for {d} days");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"
                   
      MMMD~=========================================================~NMMM   
    ZMMM?Z$$$77III????++++++=======================~~~================ZMMN+     
    MMMD~MMMMMMMMMMMMMMMMMMMD================~~~~~~~~~========~~~~===~~MMMM    
  ,MMMM~NMMMMMMMM  .  .... MM~==============MMMMMMMMMMMMMMMMNMMMMMN~====MMMM
  NMMM~~MMMMMMMMMD    .  ..MM~============~=MM. ...         DNMMMMM=====:MMMZ
  MMMD==MMMMMMMMMD       ..MM=============~ZM8.         . .MMMMMMMM~=====NMMM
 NMMN~~~MMDMMMMMM.        .MM~=============DMI .         . MMMMMMMM====+=~MMMN
 MMM:===DMM..~~  ..      . MM~~============8MZ..        ...MMMMMMMM~======~MMM
+MMM====:MMZ          .  .OMN===============MM.            .7MMMMMM~=======MMM:
MMM$=====8MM .         ..?MN:=~=============MM..             ...ZMN========8MMM
MMM~~=====?MM8. . ......?MM?=~==============+MM?,..        ....=MM~========~MMM
MMM~=======IMMM+......,$MMO====~~~I$==:======OMM~..          .DMM==========~MMM~
MMM========~=MMNNM$7DMMNM====~NMMMMMMMMMN~====OMMM. , .  . , MMM=~=========~MMM?
MMM==========~~~8MMMMMI~====?MM7=~==~~==MMM=====ZMMMNI:.:OMNMM+~~===========MMM8
MMM========================~MN~========~~NMM=====~IMNMMMMMMM~===============MMM8
MMM~=======================NM~~===========:MM~==========~==================~MMM?
MMM~~======================MM=====~=~======MM~=============================~MMM=
NMM~=====================+~MN~=~?~~~=~+====~MM+~============~==============:MMM
MMMZ======================DM~==Z==~~~==M====DM=~==========================~8MMD
=MMM~====================~MM~=~M~======~I==~~MM~=========================~~MMM:
 MMM~====================+MM==7?========7~===MM8==========================~MMM
 NMMN~===================8MN=~===+===========+MM=========================~NMMD
  MMM7~==================MM7=~===============~MM~=======================~OMMM
 ,8MMM:~==============~==MM~+================~OMM=~====================~:MMM$ 
   MMMM================NNMMD~=~===============~MM~~====================~MMMM 
    MMMN==============~~+~+=N~~==============~~N~=~====================MMMM     
          MMMN=====================================================MMMM ");
                    Console.ResetColor();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    d = WarpPandora();
                    Console.WriteLine("You have arrived at Pandora.");
                    Console.WriteLine($"you travelled for {d} days");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
                                                                           
                                                                     
                                      :~~~:,                          
                              +NMMMMMMMMMMMMMMMN?                       
                       ....DMMMMMM8I~.....:?OMMMMMMN,,                     
                      .?MMMMO,....:=++++++??+++++~8MMMMI                     
                    .=MMMM....:=+++++++++++++++++?+?+NMMM?                     
                   .MMMN...,=++++++++++++++++++??+++??=NMMM                
                  ?MMM...,=+++++++++++++++++++++++++++++=MMM$                
                 NMM$...~++++++++++++++++++++++++++++++?+?ZMMN                
                MMM:..:+++++++++++++++++++++++++++++++?????+MMM            
               MMM,..~+++++++++++++++++++++++++++++++??++???=MMM            
              MMM..,++++++++++++++++++++++++++++++?+?????????+MMM        
             7MM:..++++++++++++++++++++++++++++?+??+??????????+MM8        
             MMO..=++++++++??++++++++++++??++?????????????????+OMM         
            ZMM..:++++++??++MMMM=?+++++++?++++=NMMM+???????????+MMD        
            MM8.,++++++++?IMMMMMN7??+++?+++???MMMMMMZ???????????OMM        
           ,MM:.~+++++++?+NMM+=MMM+?+++??++++NMM+=NMM+???????????MM=        
           IMM..+++++++++?8MM88MM8???++?++???ZMN8DMMD???????????+MMO        
           8MM.,+++++++++++?MMMN++??+++?????+?+NMMM??????????????MMM        
           NMM.:+++++++++++++++++??+++???????????????????????????NMM        
           8MM.:+++++++++?+++???++++++??????????????????????????+MMN        
           7MM.~+++++++++++++++++???????????????????????????????+MMO        
           :MM,:++++++++++++?=??++??????+???????????I????????????MM+        
            MMO:++++++++?++MM????????+???????????IMN+???????????OMM        
            8MM.+?+++++++?=NMMD+++++????????????NMMM+????????II?MMN        
             MM$=??++++++??+$MMM8=???????????+DMMM$?????????I??$MM:        
             +MM+??+??+?+????+=MMMMMMMNDNMMMMMMN=????????II?I?7MM7        
              NMM=++++??++??????+?DMMMMMMMMMD?+I????????????I?MMN               
               MMM=+?+++?????????????+++++?I??I??????????I?I?MMM              
                MMM=???+???????????+????????????????????I?I?MMM             
                 MMM7????????????????????????????????????I7MMM                
                  OMMM++??????????????????????????????I?+NMMN,                
                   ,MMM8+???????????????????????????I??OMMM=                
                      MMMMZ=?+?I????????????????II??ZMMNM                    
                        NMMMMZ++?????????????????ZMMMMM                    
                          +MMMMMMDZI?????+??$DMMMMMM?                        
                             ,8MMMMMMMMMMMMMMNMMD,                       
                                  :+7ZZZ7+=              
                   ");
                    Console.ResetColor();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    d = WarpTuffle();
                    Console.WriteLine("You have arrived at Tuffle.");
                    Console.WriteLine($"you travelled for {d} days");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(@"
                                                
                                 :~~~~~~~~~~~:                               
                             :~~~~~~~~~~~~~~~~~~~~                            
                          ~NDDDN= ~~~~~~~~~~~~~~NDNNDO
                        ~NDDDODDD~~~~~~~~~~~~~NND8DNNDN
                       ~NN+=~~~~~~~~~~~~~~~~~~~~~~~~~NN~,                     
                      ~~~=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~                     
                    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~                   
                   ~~~~~~~~~=~=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~                   
                  ~~~~~~~~~NDDD+=~~~~~~~~~~~~~~~=NNNN~~~~~~~~                 
                  ~~~~~~~~NDDDNN~~~~~~~~~~~~~~~~NDDDDN~~~~~~~,                
                 =~~~~~~~ZDDDDDD~~~~~~~~~~~~~~~~DDDDDND~~~~~~~                
                 ~~~~~~~~NNNDDDD~~~~~~~~~~~~~~~~NDDDDDN~~~~~~~,                
                ~~~~~~~~~=NNNND~~~~~~~~~~~~~~~~~~DNDDD==~~~~~~~
                ~~~~~~~~~~+NDN==~~~~~~~==~~~~~~~~~DDN?==~~~~~~~                
                ~~~~~~~~~~~~~~~~~~~~=DDDDN8~~~~~~~~~~~~~~~~~~~~                
                ~~~~~~~~~~~~~~~~~~~$DDDDDDDN~~~~~~~~~~~~~~~~~~~                
                ~~~~~~~~~~~~~~~~~~$DDDDDDDDDN~~~~~~~~~~~~~~~~~~                
                ~~~~~~~~~~~~~~~~~~NDDDDDDDDDDN~~~~~~~~~~~~~~~~~                
                 ~~~~~~~~~~~~~~~=ODDDDDDDDDDNN~~~~~~~~~~~~~~~~,                
                 ~~~~~~~~~~~~~~~~NDNDDDDDDDDDN~~~~~~~~~~~~~~==                
                  ~~~~~~~~~~~~~~~NDDDDDDDDDDDN~~~~~~~~~~~~~~=,                
                  ~~~~~~~~~~~~~~~NNDDDDDDDDDDN~~~~~~~~~~~~~~~                
                   ~~~~~~~~~~~~~~INDDDDDDDDDDD=-~~~~~~~~~~~~~
                    ~~~~~~~~~~~~~~DNDDDDDDDDN$~~~~~~~~~~~~~                   
                     :~~~~~~~~~~~~=DDDDDDDDDD~~~~~~~~~~~~~                    
                       ~~~~~~~~~~~~~DNDDDDNN~=~~~~~~~~~~,                     
                        ,= ~~~~~~~~~~~IDDDN~~~~~~~~~~~~:                       
                          ,~~~~~~~~~~~~~~~~~~~~~~~~=,                        
                             ~~~~~~~~~~~~~~~~~~~=~                        
                                ,~~~~~~~~~~~,    
                            
                            ");
                    Console.ResetColor();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    d = WarpKrypton();
                    Console.WriteLine("You have arrived at Kryton.");
                    Console.WriteLine($"you travelled for {d} days");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(@"

 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++I
 =++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 =+++++++++++++++++++++++++++++++++==++++++++++++++++++++++++++++++++++++++++=
 =+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=
 +======+=ZN7=++===+========================================+===++$D7+=======?
 ?=======+DDDDDDI==+==================================+++===+=?DD8DDD========I
 7=======+?8DNDDDDDD8I++==+=++=+++++=======+===+==+++===+78NDDDDDD8D=+======+$
 $===========78DDDDDDDDD88DDNDDOOZ?========+?ZO8DDNDDDDDDDDDDD8DD7===========$
  ==============+~DDDDDDDDDDDDDDDDD=========DDDDDDDDDDDDDDDDO==+============+
  $=+===========+$D8DDDDDDD?I$ZOOD+=+=======+8OOZ$I+DDDDDDDDD?=============+$
  ?==============ZD8DDDDDDD=========================DDDDDDDDD7============+=+   
   7=============~8DD8DDDD7========================+ODD8DDDDO==============$   
   ~7==============ZD88DNI==========================+ZDDDDDZ==+===========7,   
    ~====================================================================?   
     7~=================================================================+~    
      7+=====================================~+=========================7      
       I======================$8NDNNNDDDDDDDNDND7~====================~$      
        $==================DDDDDDDDDDDDDDDDDDDDDDDD8=================?~         
         ?=================?DNDDDDDDDDDDDDDDDDDDDD8?================+         
          :+=======================================================7,         
            I=====================================================I         
              7~~============================================~=+7,            
               7============================================~I:            
                  +I=~====================================~?I               
                    =7==+=======================~=~======$~                    
                       ?7~=================~~=========7~                    
                           :77=~~==~===~~~====~~+7I,                          
                                 :=777777777+,                    
                           ");
                    Console.ResetColor();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    break;
                default:
                    {
                        Console.WriteLine("Sorry, thats not a planet we can reach in your lifetime");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }
            }

            //if (planet > 0 && planet < 6)
            //{
            //    age+=1;
            //    if (age == 70)
            //    {
            //        Console.WriteLine("Oh boy, it looks like you are 70 years old time for your shot\n" +
            //            "GAME OVER.......");
            //        Console.ReadLine();
            //        Console.WriteLine("Press 'Enter' to continue");
            //        gameTitle();

            //    }
            //    Console.WriteLine($"Age is now {age}");
            //    Console.WriteLine("Press 'Enter' to continue");
            //    Console.ReadLine();
            //}
            Console.Clear();
            second();

        }

        private static double WarpKrypton()
        {
            double d;
            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
            d = Convert.ToInt32((240 / v) * (365));
            return d;
        }

        private static double WarpTuffle()
        {
            double d;
            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
            d = Convert.ToInt32((120 / v) * (365));
            return d;
        }

        private static double WarpPandora()
        {
            double d;
            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
            d = Convert.ToInt32((60 / v) * (365));
            return d;
        }

        private static double WarpReach()
        {
            double d;
            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
            d = Convert.ToInt32((30 / v) * (365));
            return d;
        }

        private static double WarpEarth()
        {
            double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
            double d = Convert.ToInt32((15 / v) * (365));
            return d;
        }

        private static void second()
        {
            //Random rnd = new Random();
            //string[] secOptions = {"In the hallway you see that the cops are searching lockers.",
            //"in the hallway, you see your stalker walking toward you.",
            //"In the hallway, the fire alarm goes off."};
            //int randomNumber = rnd.Next(0, 3);
            //string secText = secOptions[randomNumber];

            //string secChoice;

            //Console.WriteLine(secText);
            //Console.WriteLine("Do you try to hide in the bathroom, Yes or No");
            //Console.Write("Choice: ");
            //secChoice = Console.ReadLine().ToLower();

            List<string[]> Good = new List<string[]>();
            string[] GoodsArray = new string[8];
            Console.WriteLine("");
            GoodsArray[0] = "1. Freeze Dried Food: 50 Credits";
            GoodsArray[1] = "2. Clothing: 75 Credits";
            GoodsArray[2] = "3. Liquid Oxygen: 150 Credits";
            GoodsArray[3] = "4. Droid Equipment: 275 Credits";
            GoodsArray[4] = "5. Polymer: 380 Credits";
            GoodsArray[5] = "6. Mega Seed: 500 Credits";
            GoodsArray[6] = "7. Kalaxian Crystal: 1000 Credits";

            Console.ResetColor();
            GoodsArray.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("Enter positive # of item you wish to buy or the negative # of item you wish to sell. enter 8 to not buy anything.");
            int array = int.Parse(Console.ReadLine());

            int funds = 1200;

            do
            {

                switch (array)
                {
                    case 1:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 50;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case 2:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 75;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case 3:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 150;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case 4:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 275;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case 5:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 380;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case 6:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 500;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case 7:
                        Console.WriteLine($"Item has been purchased");
                        funds -= 1000;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -1:
                        Console.WriteLine($"Item has been sold");
                        funds += 50;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -2:
                        Console.WriteLine($"Item has been sold");
                        funds += 75;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -3:
                        Console.WriteLine($"Item has been sold");
                        funds += 150;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -4:
                        Console.WriteLine($"Item has been sold");
                        funds += 275;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -5:
                        Console.WriteLine($"Item has been sold");
                        funds += 380;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -6:
                        Console.WriteLine($"Item has been sold");
                        funds += 500;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    case -7:
                        Console.WriteLine($"Item has been sold");
                        funds += 1000;
                        Console.WriteLine($"Funds = {funds}");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    default:
                        Console.WriteLine("Thanks for shopping!!");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                }
            } while (array > 8);

             
        }
        
    }
}
