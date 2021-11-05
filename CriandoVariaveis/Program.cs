using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - Criando Variaveis");

            int idade;
            idade = 32;
            Console.WriteLine(idade);
            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + " anos!");

            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
