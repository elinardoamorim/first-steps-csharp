﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - Condicionais Parte 2");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;

            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }


            Console.WriteLine("Para finalizar a execução, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
