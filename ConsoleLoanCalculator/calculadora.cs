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

            if (!ValidarQuantidadeParcelas(tempo))
            {
                return;
            }

            var parcela = CalcularJuros(capital, taxa, tempo);

            Console.WriteLine("Valor da prestação ao mês: R$" + parcela + " em " + tempo + "X");  // Output

            Console.ReadLine();
        }

        private static bool ValidarQuantidadeParcelas(double tempo)
        {
            if (tempo < 12 || tempo < 48)
            {
                Console.WriteLine("Quantidade de parcelas Inválidas");         // Output de tempo inválidos
                return false;
            }
            return true;
        }

        public static double CalcularJuros(double capital, double taxa, double tempo)  // Função CalcularJuros
        {
            double resultado = (((capital / 100) * taxa) + (capital / tempo));  //Cálculo da taxa

            return resultado;
        }
    }
}

