using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioUbilla3A
{
    public class Ejercicio9
    {
        public void Ejer9()
        {
            int c1 = 1, c2 = c1 + 1, c3 = c2 + 1;
            while(c3<=15)
            {
                for (int h = 0; h <= 12; h++)
                {
                    Console.Write("{0} x {1} = {2}\t", c1, h, c1 * h);
                    Console.Write("{0} x {1} = {2}\t", c2, h, c2 * h);
                    Console.Write("{0} x {1} = {2}\t", c3, h, c3 * h);
                    Console.Write("\n");
                }
                c1=c1+3;
                c2 = c1 + 1; c3 = c2 + 1;
                Console.WriteLine("\n \n");
            }
            Console.ReadKey();
        }
    }
}
