using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassProject4
{
    public class optionalClass
    {

        public void optionalModifier(int x, int y = 0)
        {
            this.x = x * 10;
            this.y = y + 10;
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}
