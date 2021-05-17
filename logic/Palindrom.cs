using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace palindrom.logic
{
    class Palindrom
    {
        public static string Reverser(string inputString)
        {
            char[] arChar = inputString.ToCharArray();
            Array.Reverse(arChar);
            return new string(arChar);
        }
        public static string PalindromerOne(string mainString)
        {
            string reverseStringOne = Reverser(mainString);
            Console.WriteLine(reverseStringOne);
            if (Equals(mainString, reverseStringOne))
            {
                return "Палиндром";
            }
            else
            {
                return "Не палиндром";
            }
        }
        public static void UserStringOne()
        {
            Console.WriteLine("Введите первую строку");
            string stingPatternOne = @"\.+?|\,+?|\ +?|\-+?|\:+?";
            string inputStringOne = Console.ReadLine();
            string customStringOne = inputStringOne.ToLower();
            customStringOne = (Regex.Replace(customStringOne, stingPatternOne, string.Empty));
            Console.WriteLine(inputStringOne + " - " + PalindromerOne(customStringOne) +
                "\nВвести еще строку?");
            Console.WriteLine("Нажмите + или -");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "+":
                    UserStringTwo();
                    break;
                case "-":
                    break;
                default:
                    break;
            }
        }
        public static void UserStringTwo()
        {
            Console.WriteLine("Введите вторую строку");
            string stingPatternTwo = @"\.+?|\,+?|\ +?|\-+?|\:+?";
            string inputStringTwo = Console.ReadLine();
            string customStringTwo = inputStringTwo.ToLower();
            customStringTwo = (Regex.Replace(customStringTwo, stingPatternTwo, string.Empty));
            Console.WriteLine(inputStringTwo + " - " + PalindromerOne(customStringTwo));
        }

    }
}
