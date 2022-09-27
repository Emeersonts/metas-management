using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class Notificacao
    {
        public int IDNOTIFICACAO { get; set; }
        public string DESCRICAO { get; set; }
        public string TITULO { get; set; }
        public DateTime PRAZO { get; set; }
        public DateTime DATAPOSTAL { get; set; }
    }
}
