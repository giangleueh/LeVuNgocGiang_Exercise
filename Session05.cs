using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeVuNgocGiang_Exercise
{
    internal class Session05
    {
       public static void Main(string[] args)
        {
            //Question01();
            Question02();

        }




        // find the maximum of three numbers.
        static int Max2num(int a, int b)
            {
                return a >b ?a : b;

            }

            static int Max3nums(int a, int b, int c)
            {
                return Max2num(a, Max2num(b, c));

            }

        private static void Question01()
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int c = int.Parse(Console.ReadLine());

            int max = Max3nums (a, b, c);
            Console.WriteLine($"Maximum number is {max}");
        }

        //calculate the factorial of a number

        static int fac(int num)
        {
            int result = 1;
            if (num <0)
            {
                return 0;
            }
            else if (num ==0 || num == 1)
            {
                return 1;
            }
            for (int i = 2; i < num; i++)
            {
                result *= i;
            }
            return result;
        }


        private static void Question02()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int result = fac(num);
            if (result == 0)
            {
                Console.WriteLine("There is no factorial of this number");
            }
            Console.WriteLine($"The result is {result}");
        }

        // takes a number as a parameter and checks whether the number is prime or not.
        static bool Prime (int num)
        {
            for (int i = 0; i < (num /2); i++)
            {
                if (num % 2 == 0)
                {
                    return false;
                }
                return true;
            }
        }

        private static void Question03()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse (Console.ReadLine());
            
            if (false);
            { Console.WriteLine($"{num} is not prime"); }
            Console.WriteLine($"{num} is prime");
        }

        //print all prime numbers that less than a number








        //print the first N prime numbers


        //check whether a number is "Perfect" or not, print all perfect number that less than 1000


        //check whether a string is a pangram or not
    }
}
