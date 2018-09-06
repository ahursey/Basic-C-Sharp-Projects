using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass1
{
    public class MathOp
    {
        public MathOp(int x)
        {
            this.x = x * 5;
        }
        public int x { get; set; }
    }

    public class MathDivide
    {
        public MathDivide(int y)
        {
            this.y = y / 5;
        }
        public int y { get; set; }
    }

    public class MathSquare
    {
        public MathSquare(int z)
        {
            this.z = z * z;
        }
        public int z { get; set; }
    }
}
