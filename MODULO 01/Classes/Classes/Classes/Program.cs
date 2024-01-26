using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carro carro = new carro();
            carro.cor = "branco";
            carro.roda = "preta";

            Console.ReadLine();
        }
    }

    class carro
    {
        public String cor;
        public String roda;

        public void motor()
        {
            Console.WriteLine("1500 CV");
        }

        public void dormir()
        {
            Console.WriteLine("Zzzzz ");
        }
    }
}
