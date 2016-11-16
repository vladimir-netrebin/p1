using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            uint i;
            int n;
            uint f;
            i = 0;
            string str;
            str = Console.ReadLine();
            n = int.Parse(str);
            a = new int[n];
            for (i = 0; i < a.Length; i++ )
            {
                str = Console.ReadLine();
                a[i] = int.Parse(str);
            }
            for (f = 0; f < a.Length; f++)
            {
                Console.Write(a[f] + " ");
            }
            int min = int.MaxValue;
            for (uint x = 0; x < a.Length; x++)
            {
                if (min > a[x])
                {
                    min = a[x];
                }
            }
            Console.Write(min);
            Console.ReadLine();
        }
    }
}
