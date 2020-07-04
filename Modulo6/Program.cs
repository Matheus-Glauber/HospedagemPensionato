using Modulo6.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int QuantidadeDeQuartos = 10;

            //Console.WriteLine("--== Pensionato Da Dona ==--");

            //Console.Write("Quantos quartos serão alugados? -> ");
            //int NumeroDeQuartos = int.Parse(Console.ReadLine());

            //Hospede[] ListaDeQuartos = new Hospede[QuantidadeDeQuartos];

            //for (int i = 0; i < NumeroDeQuartos; i++)
            //{
            //    Console.Write("Digite o nome do hóspede: ");
            //    string Nome = Console.ReadLine();

            //    Console.Write("Digite o email do hóspede: ");
            //    string Email = Console.ReadLine();

            //    Console.Write("Digite o número do quarto desejado: ");
            //    int Quarto = int.Parse(Console.ReadLine());

            //    Console.WriteLine(" ");

            //    ListaDeQuartos[Quarto] = new Hospede(Nome, Email);
            //}

            //Console.WriteLine("Quartos Ocupados: ");

            //for (int i = 0; i < QuantidadeDeQuartos; i++)
            //{
            //    if (ListaDeQuartos[i] != null)
            //    {
            //        Console.WriteLine(i + ": " + ListaDeQuartos[i].Nome + ", " + ListaDeQuartos[i].Email);
            //    }
            //}

            //Console.WriteLine(Calculator.Sum(10, 20, 30, 40));

            //int N = 10;
            //Calculator.Triplicar(ref N);
            //Console.WriteLine(N);

            //int N2 = 10;
            //int Dobrado;
            //Calculator.Dobrar(N2, out Dobrado);
            //Console.WriteLine($"O dobro de: {N2}, é = {Dobrado}");

            Console.Write("Quantos Funcionários Deseja Cadastrar? ");
            int NumeroRegistros = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            List<Funcionario> ListaFuncionario = new List<Funcionario>();

            for (int i = 0; i < NumeroRegistros; i++)
            {
                Console.WriteLine($"Cadastro do funcionário {i+1}");
                
                Console.Write("ID: ");
                int ID = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Salário: ");
                double Salario = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");                             

                ListaFuncionario.Add(new Funcionario(ID, Nome, Salario));
            }

            Console.Write("Digite o ID de qual funcionário vai receber a porcentagem: ");
            int IdAumento = int.Parse(Console.ReadLine());

            Funcionario Func = ListaFuncionario.Find(x => x.Id == IdAumento);
            if (Func != null)
            {
                Console.Write("Digite a porcentagem a ser aumentada: ");
                double Acrescimo = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Func.AcrescimoDeSalario(Acrescimo);
            }
            else
            {
                Console.WriteLine("O ID informado não existe no sistema!");
                Console.WriteLine(" ");
            }

            Console.WriteLine("--==Lista de Funcionários==--");
            foreach (var funcinario in ListaFuncionario)
            {
                Console.WriteLine(funcinario.ToString());
            }

        }
    }
}
