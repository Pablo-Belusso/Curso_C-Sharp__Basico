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
            int idade = 19;

            if (idade > 18)
            {
                Console.WriteLine("Maior de idade");
            } else { 
                Console.WriteLine("Menor de idade"); 
            }
            Console.ReadKey();
        }
    }
}
