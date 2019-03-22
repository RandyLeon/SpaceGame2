using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolTrader
{
    class Endings
    {
        public static void Intro()
        {
            string prompt = "Press any key to continue...";

            Console.Clear();
            Title.Title0();

            Console.Clear();
            Title.IntroText();

            Title.IntroText2();
            Selection.UserInput(prompt);
        }

        public static void ClosingMessage(Quit quitReason)
        {
            Console.Clear();

            switch (quitReason)
            {
                case Quit.UserQuit:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(@"Bye! Felicia...                            
          _.----.                          
       .-'       \-.                       
      /           ; \                      
     :           /:  \                     
     ;         .'  ;  ;                    
     ;      .-'    :  :                    
    :   _.+(   .-- :  :                    
    ;  ;   ' :  :  :  :                    
    ;  :           ;  ;                    
    :   ;    -    :  :                     
     )  '   .-.   '  :                     
    (    '. `'' .'   ;                     
     '-._.:`---':-'-.'+'                   
          ;     ;    '                     
   _..__.-. -. (:                          
 ,'   .:(o);     '-._                      
 :    _: 0 ;        \`.                    
 ;  .'/.\-/-.        `:                    
:  : :  -U--:'-.  \    ;                   
;  ; :  ----;   '-.L.-' \                  
'. '  \ ---(      ;O:    ;                 
  \ '. '-;-'      :-:    :                 
   `. ""/         ; :    ;                  
     ""T      .-':  :`. /                   
       :  --""   :   ; Y                    
        ;        ;   : :                   
        :       :     ; ;                  
         ;      :   ; : :                  
         :      ;   :  ; \                 
          ;    :    ;  :  \_               
          :    :        \  \'-.            
          ;    ;         \  `. '-.         
         :    :     c     \   `./'-._      
         ;    :            \    \    '-.   
        :     ;             `.    -.  -.`. 
        :    :       __..--"" \     `.\.`.\ 
        ;    :_..--"";  ;  _.-'\      ')))T 
       :     ;      _L.-'""     ;      '-=' 
");
                    break;
                case Quit.Age:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(@"YOU ATE ALL MY TWINKIES!!!.                                
                    dS$$S$S$S$S$S$S$$Sb                    
                   :$$S^S$S$S$S$S$S^S$$;                   
                   SSP   `^$S$S$^'   TSS                   
                   $$       `''       $$                   
                  _SS ,-           -  SS_                  
                 :-.|  _    - .-   _  |.-;                 
                 :\(; ' '-._.'._.-' ` |)/;                 
                  \`|  , o       o .  |'/                  
                   ':     -'   `-     ;'                   
                     ;.              :                     
                     : `    ._.    ' ;                     
                   .sSb   ._____.   dSs.                   
                _.d8dSSb.   ._.   .SSbT8b._                
            _.oOPd88SSSS T.     .P SSSS888OOo.             
        _.mMMOOPd888SSSSb TSqqqSP dSSSS88OMOOOMm._         
     .oOMMMOMOOM8O8OSSSSSb TSSSP dSSSSS8OOMMOOMMOOOo._     
   .OOMMOOOMMOOMOOOO  '^SSSTSSP dSSS^'OOOOMMOOMMMOOMMMb.   
  dOOOMMMOMMOOOMOOOO      '^SSSS^'   :OOO8MMMOOMMOOMMOMMb  
 :MMMOOMMOMMOOMMO8OS         `P      8O8OPdMMOOMMOMMOMMMM; 
 MMMMOOMMMMMOOMbTO8S;               :8888MMMMMOMMOMMOMMMMM 
 OMMMMOOMMMMOOOMMOOOS        S     :O8OPdMOMMMOMOMMOOMMMMO 
:OMMMMOOMMOMMOOMbTObTb.     :S;   .PdOPdMOOMMMMMOMMOMMMMMO;
MOOMMMMOMMOMMOOMMMOObTSSg._.SSS._.PdOPdMOOMMMMOMMMMOMMMMOOM
MMOMMMMOMMMOMMOOMMbT8bTSSSSSSSSSPd8OPdOOOMMMMOOMMMMOMMMOOMM
MMOMMMOMMMMMOMMOOMMMbT8bTSSSSSPd88PdOOOOMMMMOOMMMMMMMMOOMMM
");
                    break;
                case Quit.OutOfMoney:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(@"You tried to short that other trader, his group beat you up and took your schmeckles, ship and goods.....
  ___  _____                          
 .'/,-Y'     '~-.                     
 l.Y             ^.                   
 /\               _\_      'Doh!'     
i            ___/'   '\               
|          /'   '\   o !              
l         ]     o !__./               
 \ _  _    \.___./    '~\             
  X \/ \            ___./             
 ( \ ___.   _..--~~'   ~`-.           
  ` Z,--   /               \          
    \__.  (   /       ______)         
      \   l  /-----~~' /              
       Y   \          /               
       |    'x______.^                
       |           \                  
       j            Y                 

");
                    break;
                case Quit.DontQuit:
                    throw new NotImplementedException("Shouldn't be quitting with DontQuit reason");
            }
        }
    }
}
