using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Profile
{
    public class pkxd
    {
        public static int type { get; set; }
        public static int user { get; set; }
        public static int function { get; set; }
        public static int profile { get; set; }

        public pkxd(int te, int ur, int fn, int pe)
        {
            type = te;
            user = ur;
            function = fn;
            profile = pe;
        }
    }
}
