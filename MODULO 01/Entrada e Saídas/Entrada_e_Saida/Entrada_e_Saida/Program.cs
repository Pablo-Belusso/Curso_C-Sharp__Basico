using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entrada_e_Saida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um arquivo:
            /*
            TextWriter texto = new StreamWriter("Arquivo.txt");
            texto.WriteLine("E aeeeee Pablo Belusso!");
            texto.WriteLine(39);
            texto.Close(); 
            */

            Console.WriteLine("Informe o seu nome: ");
            String nome = Console.ReadLine();
            
            Console.WriteLine("Informe o seu telefone: ");
            String telefone = Console.ReadLine();

            StreamWriter texto = File.AppendText("Arquivo.txt");
            texto.WriteLine("Olá mini mundo!");
            texto.Close();

            TextReader textoReader = new StreamReader("Arquivo.txt");
            Console.WriteLine(nome +", "+ telefone);
            textoReader.Close();

            Console.ReadLine();
        }
    }
}
