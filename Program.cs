using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* pattern
            int x, y;
            for(x=1; x<=6; x++)
            {
                for (y=1; y<=x; y++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Wap to print 1,12,123,... in row

            for (int i =1; i<=5; i++)
            {
                for (int j= 1; j<= i; j++)
                {
                    Console.Write("" + (j));
                }
                Console.WriteLine("");
            }
            for (int k=4; k>=0; --k)
            {
                for(int j=1; j<= k; j++)
                {
                    Console.Write("" + (k));
                }
                Console.WriteLine();
            }
            //numbers row

            int p, q, r, s;
            Console.WriteLine("Enter nos. of row to print:");
            p = Convert.ToInt32(Console.ReadLine());

            for (q= 0; q<=p; q++)
            {
                s = 1;
                for (r = q; p <= p  - 1; r++)
                    Console.Write("");
                for (r = 0;r <= q; r++)
                {
                    Console.Write("{0}", q);
                    s= (s * (q - r) / (r + 1));
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //pattern 5,54,543,5432,54321

            {
                int t = 5;
                while (t >= 1)
                {
                    int u = 5;
                    while (u >= t)
                    {
                        Console.Write(u);
                        u--;

                    }
                    t--;
                    Console.WriteLine();
                }
                Console.Read();
            }

            
            
        }
    }
}
