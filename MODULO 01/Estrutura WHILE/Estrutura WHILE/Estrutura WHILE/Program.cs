using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (c < 10)
            {
                Console.WriteLine("Valor do contador: " + c);
                c++;
            }
            Console.ReadLine();
        }
    }
}
