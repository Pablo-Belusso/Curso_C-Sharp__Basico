﻿using System;
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

            int idade = 19;

            if (idade > 18 && idade < 10)
            {
                Console.WriteLine("Maior de idade");
            } else { 
                Console.WriteLine("Menor de idade"); 
            }
            Console.ReadKey();
        }
    }
}
