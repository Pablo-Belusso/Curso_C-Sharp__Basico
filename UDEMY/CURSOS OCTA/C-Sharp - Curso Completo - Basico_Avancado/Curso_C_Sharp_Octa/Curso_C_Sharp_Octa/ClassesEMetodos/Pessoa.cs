﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Octa.ClassesEMetodos
{
    class Pessoa
    {
        // Atributos
        public string Nome;   
        public int Idade;

        public string Apresentar() {
            return string.Format($"Ola! Me Chamo {Nome} e tenho idade {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine();
        }
    }
}