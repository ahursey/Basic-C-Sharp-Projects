using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject3
{
    public class integerClass
    {

        public void integerMod(int x)
        {
            this.x = x + 12;
        }

        public void integerMod(decimal y)
        {
            this.y = y / 10;
        }

        public void integerMod(string z)
        {
            int w = Int32.Parse(z);
            this.w = w * 5;
        }

        public int x { get; set; }
        public decimal y { get; set; }
        public string z { get; set; }
        public int w { get; set; }

    }
}
