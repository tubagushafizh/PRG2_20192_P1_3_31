using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_3_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = Convert.ToInt16(Console.ReadLine());
            for(int i = 1;i <= N;N--)
            {
                if(N != 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tingal {1}", N, N - 1);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tingal induknya", N);
                }
            }
        }
    }
}
