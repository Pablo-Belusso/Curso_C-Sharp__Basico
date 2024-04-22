using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Octa.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
         // Classe             // Construtor
            Pessoa Sicrano = new Pessoa();  // Cria um novo objeto do tipo Pessoa
            Sicrano.Nome = "Pablo";
            Sicrano.Idade = 40;

            //Console.WriteLine($"{Sicrano.Nome} tem {Sicrano.Idade} anos.");

            Sicrano.ApresentarNoConsole();
            Sicrano.Zerar();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 33;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);

            Console.ReadLine();
        }
    }
}
