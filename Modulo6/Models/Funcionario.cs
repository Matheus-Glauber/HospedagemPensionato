using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;

namespace Modulo6.Models
{
    class Funcionario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public double Salario { get; private set; }

        private static double CEM = 100;

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void AcrescimoDeSalario(double porcentagem)
        {
            Salario = ((porcentagem / CEM) * Salario) + Salario;
        }
    }
}
