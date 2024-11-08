using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeVuNgocGiang_Exercise
{
    internal class Session05
    {
        public static void Main1(string[] args)
        {
            //Question01();
            //Question02();
            //Question03();
            //Question04_1();
            //Question04_2();
            //Question05();
            Question06();
        }




        // find the maximum of three numbers.
        static int Max2num(int a, int b)
        {
            return a > b ? a : b;

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

            int max = Max3nums(a, b, c);
            Console.WriteLine($"Maximum number is {max}");
        }

        //calculate the factorial of a number

        private static void Question02()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }
        static int Factorial(int num)
        {
            int result = 1;
            if (num < 0)
            {
                return 0;
            }
            else if (num == 0 || num == 1)
            {
                return result;
            }
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }




        // takes a number as a parameter and checks whether the number is prime or not.
        private static void Question03()
        {
            Console.WriteLine("enter number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Prime(num));
        }

        static bool Prime(int num)
        {
            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }



        //print all prime numbers that less than a number
        private static void Question04_1()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            PrintPrime(num);
        }

        static void PrintPrime(int num)
        {

            for (int i = 2; i < num; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            return;
        }

        static bool IsPrime(int n)
        {
            if (n < 1)
                return false;
            for (int i = 2; i <= (n / 2); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }





        //print the first N prime numbers
        private static void Question04_2()
        {
            Console.WriteLine("Enter the quantity of prime number u wanna check:");
            int num = int.Parse(Console.ReadLine());
            PrintfirstNprime(num);
        }

        static bool PrintfirstNprime(int num)
        {

            int count = 0;
            int n = 2;
            while (count < num)
            {
                if (isPrime(n))
                {
                    Console.Write(n + " ");
                    count += 1;
                }
                n++;

            }
            return count == num;

        }

        static bool isPrime(int n)
        {
            for (int i = 2; i <= (n / 2); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }


        //check whether a number is "Perfect" or not, print all perfect number that less than 1000
        private static void Question05()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            if (Perfect(num))
            {
                Console.WriteLine($"{num} is perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not perfect number");
            }

            Console.WriteLine("Perfect numbers less than 1000:");
            for (int numb = 1; numb < 1000; numb++)
            {
                if (Lessthan1000perfect(numb))
                {
                    Console.WriteLine(numb);
                }
            }

        }

        static bool Perfect(int num)
        {
            int sum = 0;
            if (num < 1)
            {
                return false;
            }
            for (int i = 1; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;


        }

        static bool Lessthan1000perfect(int number)
        {
            int tong = 0;

            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    tong += i;
                }
                
            }
            return tong == number;
        }

        //check whether a string is a pangram or not
        static void Question06()
        {
            Console.WriteLine("Enter a string to check if it's a pangram:");
            string input = Console.ReadLine();

            if (Pangram(input))
            {
                Console.WriteLine("The string is a pangram.");
            }
            else
            {
                Console.WriteLine("The string is not a pangram.");
            }
        }

       
        static bool Pangram(string input)
        {
           
            input = input.ToLower();

            
            bool[] alphabetFlags = new bool[26];

            
            foreach (char c in input)
            {
                
                if (c >= 'a' && c <= 'z')
                {
                    
                    alphabetFlags[c - 'a'] = true;
                }
            }

            
            foreach (bool flag in alphabetFlags)
            {
                if (!flag)
                {
                    
                    return false;
                }
            }

            
            return true;
        }
    }

}

