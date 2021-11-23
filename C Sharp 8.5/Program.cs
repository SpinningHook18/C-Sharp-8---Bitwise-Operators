using System;

namespace C_Sharp_8._5
{
    class Program
    {
        static string Encrypt(string phrase, int key)
        {
            string EPhrase = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                char SLetter = Convert.ToChar(Convert.ToInt32(phrase[i]) ^ key);
                EPhrase += SLetter;
            }
            return EPhrase;
        }
        static void Main(string[] args)
        {
            bool valid = false;
            Console.WriteLine("Enter a phrase");
            string phrase = Console.ReadLine();
            int key = 0;
            while (!valid)
            {
                Console.WriteLine("Enter a key between 1 and 255:");
                key = Convert.ToInt32(Console.ReadLine());
                if ((key <= 255) & (key >= 1))
                {
                    valid = true;
                }
            }
            string EPhrase = Encrypt(phrase, key);
            Console.WriteLine(EPhrase);
        }
    }
}
