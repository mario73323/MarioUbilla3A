using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioUbilla3A
{
    class Program
    {
        static void Main(string[] args)
        {

            seleccion();
            Console.ReadKey();
        }
        public static void seleccion()
        {
            Console.Clear();
            int c = 0;
            Console.WriteLine("ESCOJA UN EJERCICIO DE LOS SIGUIENTES DIGITANDO SU NUMERO \n O INGRESE 11 PARA SALIR");
            Console.WriteLine("\n\n1)EJERCICIO 1\t\t\t2)EJERCICIO 2\t\t\t3)EJERCICIO 3\n\n" +
                "4)EJERCICIO 4\t\t\t5)EJERCICIO 5\t\t\t6)EJERCICIO 6\n\n" +
                "7)EJERCICIO 7\t\t\t8)EJERCICIO 8\t\t\t9)EJERCICIO 9\n\n" +
                "10)EJERCICIO 10\t\t\t11)SALIR");
            c = Ingresar();
            switch (c)
            {
                case 1:
                    Console.Clear();
                    Ejercicio1 ejer1 = new Ejercicio1();
                    ejer1.Ejer1();
                    break;
                case 2:
                    Console.Clear();
                    Ejercicio2 ejer2 = new Ejercicio2();
                    ejer2.Ejer2();
                    break;
                case 3:
                    Console.Clear();
                    Ejercicio3 ejer3 = new Ejercicio3();
                    ejer3.Ejer3();
                    break;
                case 4:
                    Console.Clear();
                    Ejercicio4 ejer4 = new Ejercicio4();
                    ejer4.Ejer4();
                    break;
                case 5:
                    Console.Clear();
                    Ejercicio5 ejer5 = new Ejercicio5();
                    ejer5.Ejer5();
                    break;
                case 6:
                    Console.Clear();
                    Ejercicio6 ejer6 = new Ejercicio6();
                    ejer6.Ejer6();
                    break;
                case 7:
                    Console.Clear();
                    Ejercicio7 ejer7 = new Ejercicio7();
                    ejer7.Ejer7();
                    break;
                case 8:
                    Console.Clear();
                    Ejercicio8 ejer8 = new Ejercicio8();
                    ejer8.Ejer8();
                    break;
                case 9:
                    Console.Clear();
                    Ejercicio9 ejer9 = new Ejercicio9();
                    ejer9.Ejer9();
                    break;
                case 10:
                    Console.Clear();
                    Ejercicio10 ejer10 = new Ejercicio10();
                    ejer10.Ejer10();
                    break;
                case 11:
                    Console.WriteLine("\n \n \n \n HASTA LA PROXIMA");
                    break;
                default:
                    Console.WriteLine("No se ha escogido un ejercicio, digite una opcion valida");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    break;
            }
            if (c != 11)
                seleccion();

        }
        protected static int Ingresar()
        {
            Console.WriteLine("\n\nESCOJA EL EJERCICIO: ");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese una opcion valida");
                numero = Ingresar();
            }
            return numero;


        }
    }
}
