﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Entre com a sua idade: ");
            String idade = Console.ReadLine();

            metodo(nome, idade);
            Console.ReadLine();
        }

        static void metodo(String nome, String idade)
        {
            Console.WriteLine("Olá "+ nome +", sua idade é: "+ idade +" anos.");
            
        }
    }
}
