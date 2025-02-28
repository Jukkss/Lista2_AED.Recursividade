/* Lista2_AED - Questão4 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4
{
    internal class Q4
    {
        static int MDC(int x, int y)
        {
            int result;
            if (x == y)
            {
                result = x;
                Console.WriteLine(result);
                return result;
            }
            else
            {
                result = MDC(x - y, y);
                return result;
            }

        }
        static void Main(string[] args)
        {
            MDC(8, 2);
        }
    }
}
