using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamento_2
{
    class Program
    {
            static void Main(string[] args)
            {
            double capital;
            double taxa;
            double tempo;
            Console.WriteLine("Insira o capital: ");
            capital = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a taxa de juros (%): ");
            taxa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o tempo do financiamento em mêses: ");
            tempo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Soma: " + CalcularJuros(capital, taxa, tempo));

            Console.ReadLine();
            }

            public static double CalcularJuros(double capital, double taxa, double tempo)  // Função CalcularJuros
            {

            double resultado = (capital/100) * taxa;  //Cálculo 

            return resultado;
            }
    }
}

