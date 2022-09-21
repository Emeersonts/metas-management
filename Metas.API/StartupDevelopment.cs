using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metas.API
{
    public class StartupDevelopment :Startup
    {
        public StartupDevelopment(IConfiguration configuration) :base (configuration)
        {
            
        }
        
    }
}
