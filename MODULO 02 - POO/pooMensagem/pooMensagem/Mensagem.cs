﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //private String TextoMensagem;

        

        //public String getTextoMensagem()
        //{
        //    return this.TextoMensagem; // se quiser não usar o "this" tbm vai funcionar
        //}

        //public void setTextoMensagem(String valor)
        //{
        //    this.TextoMensagem = valor.ToUpper();
        //}

        private String textoMensagem;

        public String TextoMensagem
        { 
            get // Pega valor da propriedade
            {  
                return textoMensagem; 
            } 

            set // Definir o valor para uma propriedade
            {
                textoMensagem = value.ToUpper(); 
            } 
        
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

    }

}
