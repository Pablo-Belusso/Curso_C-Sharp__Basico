using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -- Operadores Aritméticos  " +, -, *, /"
             
            double v1 = 2; 
            int v2 = 7;

            Console.WriteLine(v1 + v2);
            Console.WriteLine(v1 - v2);
            Console.WriteLine(v1 / v2);
            Console.WriteLine(v1 * v2);
            */


            // -- INCREMENTO, DECREMENTO, OPERAÇÕES RESUMIDAS  
            /*
            int contador = 2;

            Console.WriteLine("Valor atual: " + contador);
            contador++;
            Console.WriteLine("Valor novo: " + contador);

            Console.WriteLine("Valor atual: " + contador);
            contador--;
            Console.WriteLine("Valor novo diminuído: " + contador);

            Console.WriteLine("Valor atual: " + contador);
            contador += 5;
            Console.WriteLine("Valor novo + 5: " + contador);

            Console.WriteLine("Valor atual: " + contador);
            contador *= 2;
            Console.WriteLine("Valor novo * 2: " + contador);

            Console.ReadKey();
            */

            // OPERADORES RELACIONAIS

            // -- IQUALDADE ==

            //Console.WriteLine("Os número são iguais: " + (3==3));

            // -- DIFERENTE !=

            //Console.WriteLine("Os número são diferentes: " + (6 != 3));

            // -- MAIOR >

            //Console.WriteLine("O primeiro é maior que segundo: " + (6 > 3));

            // -- MENOR <

            //Console.WriteLine("O primeiro é menor que segundo: " + (6 < 3));

            // -- MAIOR ou IGUAL >=

            //Console.WriteLine("O primeiro é maior ou igual que segundo: " + (6 >= 3));

            // -- MENOR ou IGUAL <=

            //Console.WriteLine("O primeiro é menor ou igual que segundo: " + (6 <= 3));



            // OPERADORES LÓGICOS

            // AND (e) = &&

            Console.WriteLine("&& - Os número são iguais: " + (3 == 3 && 5 == 5));

            // OR (ou) = ||

            Console.WriteLine("|| - Os número são iguais: " + (3 == 7 || 5 == 8 || 1 > 9));

            // NOT (não) = !

            Console.WriteLine("! - Os número são iguais: " + !(3 == 3));

            Console.ReadKey();



        }
    }
}
