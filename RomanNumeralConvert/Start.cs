using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConvert
{
    class Start
    {
        int playState = 0;
        Select menuChoice = new Select();

        public void startCalc() {
            while (playState == 0)
            {
                menuChoice.menu();
                menuChoice.choice();
                Console.WriteLine("Would you like to convert another number or numeral?"
                    + "0) Yes, convert another."
                    + "1) No, I'm done.");
                playState = int.Parse(Console.ReadLine());
            }
        }
    }
}
