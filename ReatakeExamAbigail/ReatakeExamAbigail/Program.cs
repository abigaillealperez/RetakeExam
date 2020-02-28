using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatakeExamAbigail
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1("Abigail Leal Perez");

            Console.ReadLine();

            Problem2(55);
            Problem3("This is an example");
            Problem4();
            Problem5(2, 10, true);
            Problem6(sdate);
            DateTime sdate = new DateTime(2019, 06, 07);
       
            Problem7();
            Problem8();
            Problem9();
            Problem10();


            Console.ReadKey();

        }

        static void Problem1(string myName)
        {
            try
            {
                DateTime now = DateTime.Now;
                Console.WriteLine("  " + now);


            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }
        }

        static void Problem2(int val1)
        {
            try
            {
                if (val1 % 2 == 0)
                {
                    Console.WriteLine("Even");
                }

                else
                {
                    Console.WriteLine("Odd");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }
        }

        static void Problem3(string myNumbers)
        {
            try
            {
                Console.WriteLine(myNumbers.Length);

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }
        }

        static void Problem4()
        {
            try
            {
                int i;
                for (i = 1; i < 15; i++)
                {
                    Console.Write(i + " ");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }
        }

        static void Problem5(int num1, int num2, bool mult)
        {
            try
            {
                if (mult)
                {
                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine(num1 + num2);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }
        }

        static void Problem6(DateTime date)

        {

            Console.WriteLine(date.DayOfWeek);
            Console.ReadKey();

        }

        static void Problem7(int input)
        {
        
                if (input > 2100)
                {
                    Console.WriteLine("GREATER THAN");
                }
                else
                {
                    Console.WriteLine("LESS THAN");
                }
            }


        static void Problem8(int a, int b)
        {
            if (b > a)
            {
                return "TRUE";
            }
            else
            {
                return "FALSE";
            }
        }

        static void Problem9()
        {

        }


        }







    }
}
