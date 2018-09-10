using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject5
{
    public class DivisionBy2
    {
        public void Division(int x, out int y)
        {
            y = x / 2;
        }

        public static void Division(decimal w, out decimal z)
        {
            z = w / 2;
        }

        int x { get; set; }
        int y { get; set; }
        decimal w { get; set; }
        decimal z { get; set; }

    }
}
