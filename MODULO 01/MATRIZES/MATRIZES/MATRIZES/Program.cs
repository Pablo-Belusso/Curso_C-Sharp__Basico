using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            nome[0] = "Pablo";
            nome[1] = "Maria";
            nome[2] = "Marcia";
            nome[2] = "Tânia";

            for (int elementoMatriz = 0; elementoMatriz < nome.Length; elementoMatriz++)
            {
                Console.WriteLine(nome[elementoMatriz]);
                Console.WriteLine(nome.Length);

            }

            
            Console.ReadKey();
        }
        
    }
}
