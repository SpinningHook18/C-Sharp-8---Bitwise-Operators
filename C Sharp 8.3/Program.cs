using System;

namespace C_Sharp_8._3
{
    class Program
    {
        static char SwitchCase(char letter)
        {
            char SLetter = Convert.ToChar(Convert.ToInt32(letter) ^ 32);
            return SLetter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter:");
            char letter = Convert.ToChar(Console.ReadLine());
            char SLetter = SwitchCase(letter);
            Console.WriteLine(SLetter);
        }
    }
}
