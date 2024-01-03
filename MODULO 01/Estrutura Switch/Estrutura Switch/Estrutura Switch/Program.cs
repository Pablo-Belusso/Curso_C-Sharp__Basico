using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String dia;

            Console.WriteLine("Entre com um dia da semana");
            dia = Console.ReadLine();

            switch(dia) // SWITCH = Escolha:
            {
                case "Domingo":
                    Console.WriteLine("Primeiro dia da semana");
                    break;

                case "Segunda":
                    Console.WriteLine("Segundo dia da semana");
                    break;

                case "Terça":
                    Console.WriteLine("Terceiro dia da semana");
                    break;

                case "Quarta":
                    Console.WriteLine("Quarto dia da semana");
                    break;

                case "Quinta":
                    Console.WriteLine("Quinto dia da semana");
                    break;

                case "Sexta":
                    Console.WriteLine("Sexto dia da semana");
                    break;

                case "Sabado":
                    Console.WriteLine("Último dia da semana");
                    break;

                default: Console.WriteLine("Dia incorreto. Digite Novamente.")

            }

            Console.ReadKey();
        }
    }
}
