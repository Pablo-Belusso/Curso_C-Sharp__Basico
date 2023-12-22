using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a sua idade:");

            int idade = Convert.ToInt16(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");

                if (idade >= 60)
                {
                    Console.WriteLine("Você é idoso");
                }

            } else { 
                Console.WriteLine("Menor de idade"); 
            }
            Console.ReadKey();
        }
    }
}
