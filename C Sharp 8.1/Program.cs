using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_8._1
{
    class Program
    {
        static char LowerCase(char character)
        {
            int newChar = Convert.ToInt32(character) + 32;
            Char = Convert.ToChar(newChar);
            return newChar;
        }

        static void Main(string[] args)
        {
        }
    }
}
