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
            //Variáveis input
            double capital;
            double taxa;
            double tempo;
            Console.Write("Insira o capital: ");
            capital = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a taxa de juros (%): ");
            taxa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o tempo do financiamento em mêses: ");
            tempo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor da prestação ao mês: R$" + CalcularJuros(capital, taxa, tempo) + " em " + tempo + "X");  // Output

            Console.ReadLine();
        }
        public static double CalcularJuros(double capital, double taxa, double tempo)  // Função CalcularJuros
        {
            double resultado = (((capital / 100) * taxa)+(capital / tempo));  //Cálculo da taxa
          
            return resultado;
        }
    }
}

