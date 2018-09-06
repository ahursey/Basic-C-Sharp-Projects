using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an integer value.");
            int value = Convert.ToInt32(Console.ReadLine());

            MathOp result = new MathOp(value);
            MathDivide result2 = new MathDivide(value);
            MathSquare result3 = new MathSquare(value);
          
            Console.WriteLine(result.x);
            Console.WriteLine(result2.y);
            Console.WriteLine(result3.z);
            Console.ReadLine();
   
        }
    }
}
