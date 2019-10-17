using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioUbilla3A
{
    public class Ejercicio7
    {
        public void Ejer7()
        {
            int c1 = 1, c2 = 100;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}\t{1}", c1, c2);
                c1++;
                c2--;
            }
            Console.ReadKey();
        }
    }
}
