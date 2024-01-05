using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrurtura_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int contador = 1; contador < 5; contador++)
            {
                Console.WriteLine("Contador: "+contador);
            }

            Console.WriteLine("\n Contador de 2 em 2 = \n ");

            for (int contador = 1; contador <= 5; contador+=2)
            {
                
                Console.WriteLine("Contador: " + contador);
            }

            Console.WriteLine("\n Contador decremento = \n ");

            for (int contador = 10; contador >= 1; contador--)
            {

                Console.WriteLine("Contador: " + contador);
            }
            */

            // TABUADA construída em FOR:

            Console.WriteLine(" TABUADA DE MULTIPLICAÇÃO");

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++) {
                    Console.WriteLine(x + " * " + y + " = " + x * y);
                }

                Console.WriteLine("Multiplicado por " + x);
            }

            Console.ReadKey();
        }
    }
}
