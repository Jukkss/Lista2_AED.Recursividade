/* Lista2_AED - Questão5 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    internal class Q5
    {
        static void Negativos(int[] vet, int n)
        {
            if (n >= 0)
            {
                if (vet[n] < 0)
                {
                    Console.WriteLine(vet[n]);
                }
                Negativos(vet, n-1);
            }
        }
        static void Main(string[] args)
        {
            int[] vet = { -1, 2, -3, 4, -5};
            Negativos(vet, vet.Length-1);
        }
    }
}
