using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo6.Models
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Hospede(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
