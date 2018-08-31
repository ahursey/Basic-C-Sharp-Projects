using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "David", "Henry", "Kyle", "Jason" };

            Console.WriteLine("Please enter some text to add to the list of names.");
            string text = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " " + text);
            }

            Console.WriteLine("Please enter a number of iterations to have completed.");
            int iterations = Convert.ToInt16(Console.ReadLine());

            for (int k = 1; k <= iterations; k++)
            {
                Console.WriteLine("This will print as many times as the number you entered.");
            }

            List<string> alphaList = new List<string>();
            alphaList.Add("A");
            alphaList.Add("B");
            alphaList.Add("C");
            alphaList.Add("D");
            alphaList.Add("E");
            alphaList.Add("F");

            Console.WriteLine("Enter a letter to see if it exists in the list of letters.");
            string letter = Console.ReadLine();
            if(alphaList.Contains(letter))
            {
                Console.WriteLine("Yes, " + letter + " does exist in the set at index " + alphaList.FindIndex(s => s.Equals(letter)) + ".");
            }
            else
            {
                Console.WriteLine("Sorry, " + letter + " does not exist in the set.");
            }

            List<string> stringList = new List<string>();
            stringList.Add("David");
            stringList.Add("Henry");
            stringList.Add("Kyle");
            stringList.Add("Jason");
            stringList.Add("Alex");
            stringList.Add("Robert");
            stringList.Add("Al");
            stringList.Add("Albert");

            List<int> partOfSearch = new List<int>();
            List<int> notPartOfSearch = new List<int>();

            Console.WriteLine("Enter a name to see if it exists in the list of names.");
            string searchTerm = Console.ReadLine();
            for(int j = 0; j < stringList.Count; j++)
            {
                if (stringList[j].Contains(searchTerm))
                    
                {
                    partOfSearch.Add(j);
                }
                else
                {
                    notPartOfSearch.Add(j);
                }
            }

            if(notPartOfSearch.Count == stringList.Count)
            {
                Console.WriteLine("Your search term does not exist in the list of names.");
            }
            else
            {
                string found = string.Join(", ", partOfSearch.ToArray());
                Console.WriteLine("Your search term \"" + searchTerm + "\" was found at index " + found + ".");

            }

            Console.ReadLine();
        }
    }
}
