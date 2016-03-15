using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConvert
{
    class Start
    {
        String playState = "yes";
        String LineBreak = Environment.NewLine;
        Select menuChoice = new Select();

        public void startCalc() {
            while (playState.Equals("yes"))
            {
                menuChoice.menu();
                menuChoice.choice();
                Console.WriteLine("Would you like to convert another number or numeral?" + LineBreak
                    + "'Yes', convert another." + LineBreak
                    + "'No', I'm done." + LineBreak);
                playState = Console.ReadLine();
                playState = playState.ToLower();
                Console.WriteLine(LineBreak);
            }Console.WriteLine("Thank you for using Dan's conversion tool." + LineBreak
                + "Goodbye."); Console.ReadLine();
        }
    }
}
