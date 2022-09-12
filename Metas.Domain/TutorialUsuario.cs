using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class TutorialUsuario
    {
        public int IDTUTORIAL { get; set; }
        public int IDUSUARIO { get; set; }
        public int IDPERFIL { get; set; }
        public TutorialUsuario(int idperfil)
        {
            IDPERFIL = idperfil;
        }
    }
}
