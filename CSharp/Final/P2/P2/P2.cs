using System;
using System.Text.RegularExpressions;

namespace P2
{
    class P2
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("This program reads a string and then allows a user to replace, reverse, concatenate, or remove from it.");
            Console.Write("\nPlease enter your string: ");
                str = Console.ReadLine();

            instructions(str);    
        }

        public static void instructions(string str)
        {
            Console.WriteLine("\n\nWhat would you like to do with your string? (Press the corresponding letter)");
            Console.WriteLine("A. Replace characters in the string.");
            Console.WriteLine("B. Reverse the string.");
            Console.WriteLine("C. Concatenate the string with another string.");
            Console.WriteLine("D. Remove letters from the string.");
            Console.WriteLine("E. Quit program.");
            char choice = Console.ReadKey().KeyChar;

            if (choice.Equals('a') || choice.Equals('A'))
                replaceStr(str);
            if (choice.Equals('b') || choice.Equals('B'))
                reverseStr(str);
            if (choice.Equals('c') || choice.Equals('C'))
                concatenateStr(str);
            if (choice.Equals('d') || choice.Equals('D'))
                removeStr(str);
            if (choice.Equals('e') || choice.Equals('E'))
                return;
            else
                instructions(str);
            
        }

        public static void replaceStr(string str)
        {
            Console.Write("\n\nPlease type the substring you would like to replace: ");
                string substring = Console.ReadLine();
            Console.Write("\nPlease type what to replace it with: ");
                string replacement = Console.ReadLine();
            
            Regex newStr = new Regex(substring);
            
            Console.Write("\nYour string is now: " + newStr.Replace(str, replacement));
            instructions(str);
        }

        public static void reverseStr(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            Console.Write("\n\nYour reversed string is: ");

            for (int i = 0; i < charArray.Length; i++)
                Console.Write(charArray[i]);

            instructions(str);
        }

        public static void concatenateStr(string str)
        {
            string newStr;

            Console.Write("\n\nPlease enter a string to concatenate: ");
                newStr = Console.ReadLine();

            Console.Write("\nYour new string is: " + str + newStr);
            instructions(str);
        }

        public static void removeStr(string str)
        {
            Console.Write("\n\nPlease type the substring you would like to remove: ");
            string substring = Console.ReadLine();
            
            Regex newStr = new Regex(substring);

            Console.Write("\nYour string is now: " + newStr.Replace(str, ""));
            instructions(str);
        }
    }
}
