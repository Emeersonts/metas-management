using Metas.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public   class LisTutorialDTO
    {
        public IEnumerable<Tutorial> ListTutorial { get; set; }
    }
}
