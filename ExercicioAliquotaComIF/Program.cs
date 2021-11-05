using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAliquotaComIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Alíquota com IF(Exercicio Opcional)");

            double salario = 2750.50;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("O IR é de 7.5% e pode deduzir R$ 142.");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("O IR é de 15% e pode deduzir R$ 350.");
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636.");
            }

            Console.WriteLine("Para finalizar a execução, tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
