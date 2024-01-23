using System;
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
            metodo();
            Console.ReadLine();
        }

        static void metodo(String nome)
        {
            Console.WriteLine("Olá "+ nome +", qual é a boa? Feliz por te ver.");
            Console.WriteLine("Deu certo o Rolê.");
        }
    }
}
