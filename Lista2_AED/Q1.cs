/* Lista2_AED - Questão1 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_AED
{
    internal class Q1
    {
        static int Exponencial(int x,int y)
        {
            int result;

            if (y == 1)
            {
                result = x;
                Console.WriteLine(result);
            }
            else
            {
                result = x * Exponencial(x,y-1);
                Console.WriteLine(result);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Exponencial(3, 3);
        }
    }
}
