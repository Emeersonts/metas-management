using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class RepresentanteDTO
    {
        public int IDREPRESENTANTE { get; set; }
        public string NOMEREPRESENTANTE { get; set; }
        public int IDSUPLENTE { get; set; }
        public string NOMESUPLENTE { get; set; }
        public int IDGESTOR { get; set; }
        public string NOMEGESTOR { get; set; }
    }
}
