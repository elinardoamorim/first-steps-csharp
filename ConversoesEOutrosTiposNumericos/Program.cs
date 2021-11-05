using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - Conversões e outros tipos numericos");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            long idade = 13000000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.WriteLine("Para finalizar a execução, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
