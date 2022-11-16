using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class FormGestorStatusDTO
    {
        public int QTPAGINA { get; set; }
        public int TOTALREGISTRO { get; set; }
        public IEnumerable<GestorStatusDTO> Listform { get; set; }
    }
}
