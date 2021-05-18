using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
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
        public static string PalindromerTwo(string mainString)
        {
            string reverseStringTwo = Reverser(mainString);
            Console.WriteLine(reverseStringTwo);
            if (Equals(mainString, reverseStringTwo))
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
                    UserStringTwo(customStringOne);
                    break;
                case "-":
                    break;
                default:
                    break;
            }
        }
        public static void UserStringTwo(string customStringOne)
        {
            Console.WriteLine("Введите вторую строку");
            string stingPatternTwo = @"\.+?|\,+?|\ +?|\-+?|\:+?";
            string inputStringTwo = Console.ReadLine();
            string customStringTwo = inputStringTwo.ToLower();
            int startIndex;
            customStringTwo = (Regex.Replace(customStringTwo, stingPatternTwo, string.Empty));
            Console.WriteLine(inputStringTwo + " - " + PalindromerOne(customStringTwo));
            if (customStringOne.Contains(customStringTwo))
            {
                startIndex = customStringOne.IndexOf(customStringTwo);
                Console.WriteLine("Первая строка содержит вторую начиная с " + (startIndex + 1) + " символа");
            }
            else
            {
                Console.WriteLine("Первая строка не содержит вторую строку");
            }
            int c = (int)Console.ReadKey().KeyChar;
            Console.WriteLine(c);

        }

    }
}
