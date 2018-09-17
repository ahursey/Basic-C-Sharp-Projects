using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter some text to be saved to a text file.");

            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Log.txt", text);

            Console.ReadLine();
        }
    }
}
