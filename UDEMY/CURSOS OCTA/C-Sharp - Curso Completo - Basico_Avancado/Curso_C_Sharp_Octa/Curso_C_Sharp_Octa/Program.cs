using System;
using System.Collections.Generic;
using Curso_C_Sharp_Octa.Fundamentos;
using Curso_C_Sharp_Octa.ClassesEMetodos;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Membros.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}