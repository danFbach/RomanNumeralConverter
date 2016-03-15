using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConvert
{
    class Select
    {
        DecToRom DTR = new DecToRom();
        RomToDec RTD = new RomToDec();
        int selection;
        public int menu() {
            Console.WriteLine("Would you like to convert a \n"
                + "1) Decimal to a Roman Numeral? \n"
                + "2) Roman Numeral to a Decimal?   ");
            selection = int.Parse(Console.ReadLine());
            return selection;
        }
        public int choice() { 
            switch (selection)
            {   

                case 1:
                    DTR.ToRoman();
                    selection = 0;
                    return selection;
                    ;
                case 2:
                    RTD.ToDecimal();
                    selection = 0;
                    return selection;
                    ;
            }    return selection;
        }
    }
}
