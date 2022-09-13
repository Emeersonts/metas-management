using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class ColaboradorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Datacadastro { get; set; }
    }
}
