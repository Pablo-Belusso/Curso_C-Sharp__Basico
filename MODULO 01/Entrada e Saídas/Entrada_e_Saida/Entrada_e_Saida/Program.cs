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

            StreamWriter texto = File.AppendText("Arquivo.txt");

            TextReader textoReader = new StreamReader("Arquivo.txt");
            Console.WriteLine(textoReader.ReadLine());
            textoReader.Close();

            Console.ReadLine();
        }
    }
}
