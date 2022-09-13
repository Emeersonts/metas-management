using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SobreNome { get; set; }
        public DateTime Datacadastro { get; set; }
        public bool Ativo { get; set; }
        public decimal Verba { get; set; }
        public Cliente(String nome, String sobrenome, String email)
        {
            Nome = nome;
            SobreNome = sobrenome;
            Email = email;

        }

    }
  
}
