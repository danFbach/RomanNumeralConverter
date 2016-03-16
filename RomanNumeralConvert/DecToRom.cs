using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConvert
{   class DecToRom
    {   int number;
        int numberTemp;
        String LineBreak = Environment.NewLine;
        String Roman = "";
        public void ToRoman()
        {       Roman = "";
                Console.Write(LineBreak + "Please enter the numberTemp from 1 to 10,000 that" + LineBreak
                    + "you would like converted to Roman Numeral." + LineBreak + LineBreak);
                number = int.Parse(Console.ReadLine());
                numberTemp = number;
                if (numberTemp >= 1 || numberTemp <= 10000)
                {
                while (numberTemp >= 10000)     {Roman += "x";      numberTemp -= 10000;}
                while (numberTemp >= 9000)      {Roman += "Mx";     numberTemp -= 9000;}
                while (numberTemp >= 5000)      {Roman += "v";      numberTemp -= 5000;}
                while (numberTemp >= 4000)      {Roman += "Mv";     numberTemp -= 4000;}
                while (numberTemp >= 1000)      {Roman += "M";      numberTemp -= 1000;}
                while (numberTemp >= 900)       {Roman += "CM";     numberTemp -= 900;}
                while (numberTemp >= 500)       {Roman += "D";      numberTemp -= 500;}
                while (numberTemp >= 400)       {Roman += "CD";     numberTemp -= 400;}
                while (numberTemp >= 100)       {Roman += "C";      numberTemp -= 100;}
                while (numberTemp >= 90)        {Roman += "XC";     numberTemp -= 90;}
                while (numberTemp >= 50)        {Roman += "L";      numberTemp -= 50;}
                while (numberTemp >= 40)        {Roman += "XL";     numberTemp -= 40;}
                while (numberTemp >= 10)        {Roman += "X";      numberTemp -= 10;}
                while (numberTemp >= 9)         {Roman += "IX";     numberTemp -= 9;}
                while (numberTemp >= 5)         {Roman += "V";      numberTemp -= 5;}
                while (numberTemp >= 4)         {Roman += "IV";     numberTemp -= 4;}
                while (numberTemp >= 1)         {Roman += "I";      numberTemp -= 1;}

                Console.WriteLine(LineBreak + "You've entered " + number + " and it equals " + Roman + " in Roman Numerals." + LineBreak);
            }
        }
    }
}