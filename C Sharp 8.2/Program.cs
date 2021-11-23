using System;

namespace C_Sharp_8._2
{
    class Program
    {
        static char UpperCase(char letter)
        {
            char ULetter = Convert.ToChar(Convert.ToInt32(letter) & 223);
            return ULetter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a lower case letter");
            char letter = Convert.ToChar(Console.ReadLine());
            char ULetter = UpperCase(letter);
            Console.WriteLine(ULetter);
        }
    }
}
