using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Profile
{
    public class pkxd
    {
        public static int user { get; set; }
        public static int function { get; set; }
        public static string language { get; set; }
        public static int profile { get; set; }
        public static int type { get; set; }

        public pkxd(int ur, int fn, string le, int pe, int te)
        {
            user = ur;
            function = fn;
            language = le;
            profile = pe;
            type = te;
        }
    }
}
