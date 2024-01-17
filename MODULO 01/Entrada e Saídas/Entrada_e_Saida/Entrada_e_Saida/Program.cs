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
            TextWriter texto = new StreamWriter("Arquivo.txt");
            texto.WriteLine("E aeeeee!");
            texto.Close(); 
        }
    }
}
