using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            const string impermenance = "Some things never change....";
            Console.WriteLine(impermenance);
            Console.ReadLine();

            var trial = new DaisyChain(22, "testUser");
            Console.WriteLine(trial.uniqueID);
            Console.ReadLine();


        }
    }
}
