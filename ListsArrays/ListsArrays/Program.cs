using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] childrenArray = { 0, 2, 4, 6 };
            string[] incomeArray = { "thousands", "millions", "billions", "trillions" };
            List<string> houseList = new List<string>();
            houseList.Add("mansion");
            houseList.Add("apartment");
            houseList.Add("shack");
            houseList.Add("house");

            Console.WriteLine("Let me predict your future! \nPlease, choose a number between 1 and 4.");
            int firstNum = Convert.ToInt16(Console.ReadLine());
            bool guess = false;

            do
            {
                switch (firstNum)
                {

                    case 1:
                        Console.WriteLine("Thank you. Please choose again between 1 and 4.");
                        guess = true;
                        break;

                    case 2:
                        Console.WriteLine("Thank you.Please choose again between 1 and 4..");
                        guess = true;
                        break;

                    case 3:
                        Console.WriteLine("Thank you.Please choose again between 1 and 4..");
                        guess = true;
                        break;

                    case 4:
                        Console.WriteLine("Thank you.Please choose again between 1 and 4..");
                        guess = true;
                        break;

                    default:
                        Console.WriteLine("Response not between 1 and 4. Try again.");
                        firstNum = Convert.ToInt16(Console.ReadLine());
                        break;

                }
            }   while (!guess);

            int secondNum = Convert.ToInt16(Console.ReadLine());
            bool guess2 = false;

            do
            {
                switch (secondNum)
                {

                    case 1:
                        Console.WriteLine("Thank you. Please choose again between 1 and 4.");
                        guess2 = true;
                        break;

                    case 2:
                        Console.WriteLine("Thank you.Please choose again between 1 and 4..");
                        guess2 = true;
                        break;

                    case 3:
                        Console.WriteLine("Thank you.Please choose again between 1 and 4..");
                        guess2 = true;
                        break;

                    case 4:
                        Console.WriteLine("Thank you.Please choose again between 1 and 4..");
                        guess2 = true;
                        break;

                    default:
                        Console.WriteLine("Response not between 1 and 4. Try again.");
                        secondNum = Convert.ToInt16(Console.ReadLine());
                        break;

                }
            } while (!guess2);

            int thirdNum = Convert.ToInt16(Console.ReadLine());
            bool guess3 = false;

            do
            {
                switch (thirdNum)
                {

                    case 1:
                        Console.WriteLine("Thank you.");
                        guess3 = true;
                        break;

                    case 2:
                        Console.WriteLine("Thank you.");
                        guess3 = true;
                        break;

                    case 3:
                        Console.WriteLine("Thank you.");
                        guess3 = true;
                        break;

                    case 4:
                        Console.WriteLine("Thank you.");
                        guess3 = true;
                        break;

                    default:
                        Console.WriteLine("Response not between 1 and 4. Try again.");
                        thirdNum = Convert.ToInt16(Console.ReadLine());
                        break;

                }
            } while (!guess3);

            firstNum = firstNum - 1;
            secondNum = secondNum - 1;
            thirdNum = thirdNum - 1;

            Console.WriteLine("You will live in a(n) " + houseList[firstNum] + " and have " + childrenArray[secondNum] + " children with " + incomeArray[thirdNum] + " of dollars.");
            Console.ReadLine();


            }
        }
    }

