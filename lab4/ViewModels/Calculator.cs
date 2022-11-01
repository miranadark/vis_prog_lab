using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visual_programming_lab4.Models;

namespace visual_programming_lab4.ViewModels
{
	internal class Calculator
	{
        static public string Calc(string number1, string number2, string command)
        {
            if (command == "+") return ((new RomanNumberExtend(number1) + new RomanNumberExtend(number2)).ToString());
            if (command == "-") return ((new RomanNumberExtend(number1) - new RomanNumberExtend(number2)).ToString());
            if (command == "*") return ((new RomanNumberExtend(number1) * new RomanNumberExtend(number2)).ToString());
            return (new RomanNumberExtend(number1) / new RomanNumberExtend(number2)).ToString();

        }
    }
}
