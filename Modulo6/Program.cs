using Modulo6.Models;
using System;

namespace Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuantidadeDeQuartos = 10;

            Console.WriteLine("--== Pensionato Da Dona ==--");

            Console.Write("Quantos quartos serão alugados? -> ");
            int NumeroDeQuartos = int.Parse(Console.ReadLine());

            Hospede[] ListaDeQuartos = new Hospede[QuantidadeDeQuartos];

            for (int i = 0; i < NumeroDeQuartos; i++)
            {
                Console.Write("Digite o nome do hóspede: ");
                string Nome = Console.ReadLine();

                Console.Write("Digite o email do hóspede: ");
                string Email = Console.ReadLine();

                Console.Write("Digite o número do quarto desejado: ");
                int Quarto = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                ListaDeQuartos[Quarto] = new Hospede(Nome, Email);
            }

            Console.WriteLine("Quartos Ocupados: ");

            for (int i = 0; i < QuantidadeDeQuartos; i++)
            {
                if (ListaDeQuartos[i] != null)
                {
                    Console.WriteLine(i + ": " + ListaDeQuartos[i].Nome + ", " + ListaDeQuartos[i].Email);
                }
            }

            Console.WriteLine(Calculator.Sum(10, 20, 30, 40));
        }
    }
}
