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
            for (int contador = 1; contador < 5; contador++)
            {
                Console.WriteLine("Contador: "+contador);
            }
            Console.WriteLine("\n Contador de 2 em 2 = \n ");
            for (int contador = 1; contador <= 5; contador+=2)
            {
                
                Console.WriteLine("Contador: " + contador);
            }

            Console.ReadKey();
        }
    }
}
