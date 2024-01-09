using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* ESTRUTURA WHILE
             * 
            int c = 0;
            while (c < 10)
            {
                Console.WriteLine("Valor do contador: " + c);
                c++;
            }
            */

            // ESTRUTURA DO WHILE

            int c = 0;
            do
            {
                Console.WriteLine("\nValor do contador: " + c);
                c++;
            } while (c < 10);


            Console.ReadLine();
        }
    }
}
