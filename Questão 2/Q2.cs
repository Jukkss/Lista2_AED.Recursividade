/* Lista2_AED - Questão1 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    internal class Q2
    {
        static int SomaIntervalos(int m, int n)
        {
            int result = m;
            if (m < n)
            {
                result += SomaIntervalos(m + 1, n);
                Console.WriteLine(result);
            }
            return result;
        }
        static void Main(string[] args)
        {
            SomaIntervalos(3, 9);
        }
    }
}
