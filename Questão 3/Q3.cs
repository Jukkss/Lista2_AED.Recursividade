/* Lista2_AED - Questão3 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class Q3
    {
        static void Binário(int x)
        {
            int rest;
            if (x >= 1)
            {
                Binário(x / 2);
                rest = x % 2;
                Console.Write(rest);
            }
        }
        static void Main(string[] args)
        {
            Binário(10);
        }
    }
}
