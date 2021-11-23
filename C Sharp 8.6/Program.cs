using System;

namespace C_Sharp_8._6
{
    class Program
    {
        static void Encrypt()
        {
            bool valid1 = false;
            bool valid2 = false;
            int key1 = 0;
            int key2 = 0;
            Console.WriteLine("Enter the phrase");
            string phrase = Console.ReadLine();
            while (!valid1)
            {
                Console.WriteLine("Enter the first key between 1 and 255:");
                key1 = Convert.ToInt32(Console.ReadLine());
                if ((key1 <= 255) & (key1 >= 1))
                {
                    valid1 = true;
                }
            }
            while (!valid2)
            {
                Console.WriteLine("Enter the second key between 1 and 255:");
                key2 = Convert.ToInt32(Console.ReadLine());
                if ((key2 <= 255) & (key2 >= 1))
                {
                    valid2 = true;
                }
            }

            string EPhrase = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char SLetter = Convert.ToChar(Convert.ToInt32(phrase[i]) ^ key1);
                    EPhrase += SLetter;
                }
                else
                {
                    char SLetter = Convert.ToChar(Convert.ToInt32(phrase[i]) ^ key2);
                    EPhrase += SLetter;
                }
            }
            Console.WriteLine(EPhrase);
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Encrypt a message");
            Console.WriteLine("2. Decrypt a message");
            Console.WriteLine("3. Exit program");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Encrypt();
                    break;
                case 2:
                    Encrypt();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Enter 1, 2, or 3");
                    Menu();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
