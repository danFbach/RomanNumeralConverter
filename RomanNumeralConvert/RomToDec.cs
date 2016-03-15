using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConvert
{   class RomToDec
    {   String LineBreak = Environment.NewLine;
        String Roman = "";
        int number = 0;
        public void ToDecimal()
        {   number = 0;
            Console.Write("Please enter the Numeral from I to x(10,000) that" + LineBreak
                + "you would like converted to Roman Numeral." + LineBreak);
            Roman = Console.ReadLine();
            while (Roman.StartsWith("x")){number += 10000;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("Mx")){number += 9000;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("v")){number += 5000;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("Mv")){number += 4000;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("M")){number += 1000;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("CM")){number += 900;Roman = Roman.Remove(0, 2);}
            while (Roman.StartsWith("D")){number += 500;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("CD")){number += 400;Roman = Roman.Remove(0, 2);}
            while (Roman.StartsWith("C")){number += 100;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("XC")){number += 90;Roman = Roman.Remove(0, 2);}
            while (Roman.StartsWith("L")){number += 50;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("XL")){number += 40;Roman = Roman.Remove(0, 2);}
            while (Roman.StartsWith("X")){number += 10;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("IX")){number += 9;Roman = Roman.Remove(0, 2);}
            while (Roman.StartsWith("V")){number += 5;Roman = Roman.Remove(0, 1);}
            while (Roman.StartsWith("IV")){number += 4;Roman = Roman.Remove(0, 2);}
            while (Roman.StartsWith("I")){number += 1;Roman = Roman.Remove(0, 1);}
            Console.WriteLine(number + LineBreak);
	    }
    }
}
