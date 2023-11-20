using System;
using System.Globalization;

namespace CalculoMinNotaseMoedas {
    internal class Program {
        static int retornaQuantidade(double valor, double notaMoeda) {
            return (int)(valor / notaMoeda);
        }

        static void Main(string[] args) {
            double valor;
            Console.WriteLine("Informe o valor: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
            double[] moedas = { 1, 0.5, 0.25, 0.1, 0.05, 0.01 };

            Console.WriteLine("NOTAS E MOEDAS:");

            foreach (uint nota in notas) {
                if (valor >= nota) {
                    int quantidade = retornaQuantidade(valor, nota);
                    Console.WriteLine($"{quantidade} nota(s) de R${nota}.00");
                    valor -= quantidade * nota;
                }
            }

            foreach (float moeda in moedas) {
                if (valor >= moeda) {
                    int quantidade = retornaQuantidade(valor, moeda);
                    Console.WriteLine($"{quantidade} moeda(s) de R${moeda.ToString("F2", CultureInfo.InvariantCulture)}");
                    valor -= quantidade * moeda;
                }
            }
        }
    }
}
