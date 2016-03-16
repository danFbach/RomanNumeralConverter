using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConvert
{   class RomToDec
    {   String LineBreak = Environment.NewLine;
        String Roman = "";
        String RomanTemp;
        int number = 0;
        public void ToDecimal()
        {
            number = 0;
            Console.Write("Please enter the Numeral from I to x(10,000) that" + LineBreak
                + "you would like converted to Roma1n Numeral." + LineBreak + LineBreak);
            Roman = Console.ReadLine();
            RomanTemp = Roman;
            while (RomanTemp.StartsWith("x"))       {number += 10000;   RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("Mx"))      {number += 9000;    RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("v"))       {number += 5000;    RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("Mv"))      {number += 4000;    RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("M"))       {number += 1000;    RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("CM"))      {number += 900;     RomanTemp = RomanTemp.Remove(0, 2);}
            while (RomanTemp.StartsWith("D"))       {number += 500;     RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("CD"))      {number += 400;     RomanTemp = RomanTemp.Remove(0, 2);}
            while (RomanTemp.StartsWith("C"))       {number += 100;     RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("XC"))      {number += 90;      RomanTemp = RomanTemp.Remove(0, 2);}
            while (RomanTemp.StartsWith("L"))       {number += 50;      RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("XL"))      {number += 40;      RomanTemp = RomanTemp.Remove(0, 2);}
            while (RomanTemp.StartsWith("X"))       {number += 10;      RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("IX"))      {number += 9;       RomanTemp = RomanTemp.Remove(0, 2);}
            while (RomanTemp.StartsWith("V"))       {number += 5;       RomanTemp = RomanTemp.Remove(0, 1);}
            while (RomanTemp.StartsWith("IV"))      {number += 4;       RomanTemp = RomanTemp.Remove(0, 2);}
            while (RomanTemp.StartsWith("I"))       {number += 1;       RomanTemp = RomanTemp.Remove(0, 1);}

            Console.WriteLine(LineBreak + "You entered " + Roman + " which equals " + number + " in decimal base10." + LineBreak);
	    }
    }
}
