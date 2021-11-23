using System;

namespace C_Sharp_8._4
{
    class Program
    {
        static char AnyCase(char letter)
        {
            char SLetter = letter ^= ' ';
            return SLetter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase:");
            string phrase = Console.ReadLine();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (((phrase[i] > 64) & (phrase[i] < 91)) | ((phrase[i] > 96) & (phrase[i] < 123)))
                {
                    char letter = phrase[i];
                    char SLetter = AnyCase(letter);
                    Console.Write(SLetter);
                }
                else
                {
                    Console.Write(phrase[i]);
                }
            }
        }
    }
}
