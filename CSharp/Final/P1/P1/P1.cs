using System;
using System.Collections.Generic;

namespace P1
{
    class P1
    {
        static void Main(string[] args)
        {
            int sentence;
            char ch;
            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;

            Console.WriteLine("This program will parse a sentence and count the number of each vowel. Please terminate sentences with a period ('.').");
            Console.Write("Please enter a sentence to find all vowels: ");

            do
            {
                sentence = Console.Read();
                ch = Convert.ToChar(sentence);

                if (ch.Equals('a') || ch.Equals('A'))
                    aCount++;
                if (ch.Equals('e') || ch.Equals('E'))
                    eCount++;
                if (ch.Equals('i') || ch.Equals('I'))
                    iCount++;
                if (ch.Equals('o') || ch.Equals('O'))
                    oCount++;
                if (ch.Equals('u') || ch.Equals('U'))
                    uCount++;
            }
            while (!ch.Equals('.'));

            Console.WriteLine("Your sentence contains: ");
            Console.WriteLine(aCount + " letter 'a'.");
            Console.WriteLine(eCount + " letter 'e'.");
            Console.WriteLine(iCount + " letter 'i'.");
            Console.WriteLine(oCount + " letter 'o'.");
            Console.WriteLine(uCount + " letter 'u'.");
            Console.ReadKey();
        }
    }
}
