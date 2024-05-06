﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Octa.ClassesEMetodos
{

    class Carro
    {
        // Atributos
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro("I3","Toyota",2012);
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"Carro: {carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            Console.ReadLine();
        }
    }
}
