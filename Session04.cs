using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace LeVuNgocGiang_Exercise
{
    internal class Session04
    {
        public static void Main(string[] args)
        {

            //Question_01()
            //Question_02()
            //Question_03()
            //Question_04()
            //Question_05()
            //Question_06()
            //Question_07()
            //Question_08()
            //Question_09()
            //Question_010()
            //Question_011()
            Question_12();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }



        public static void Question_01()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;

            Console.WriteLine($@"{a} + {b} = {c}
{a} - {b} = {d}
{a} * {b} = {e}
{a} / {b} = {f}");

        }







        

        public static void Question_02()
        {

            Console.WriteLine("Nhap y: ");
            int y = int.Parse(Console.ReadLine());
            for (y = -5; y <= 5; y++)
            {
                double a = Math.Pow(y, 2) + (2 * y) + 1;
                Console.WriteLine($"y = {y}, x = ({y})^2 + 2*{y} + 1 = {a}");
            }



        }


//speed in kilometers per hour(km/h) and miles per hour(miles/h)
        public static void Question_03()

        {
            Console.WriteLine("Enter distance in km: ");
            double Km = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter hours: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seconds: ");
            int s = Convert.ToInt32(Console.ReadLine());


            double total = h + (m / 60.0) + (s / 3600.0);


            double Kmph = Km / total;


            double Mph = Kmph * 0.621371;

            Console.WriteLine($"Speed: {Kmph} km/h | {Mph} miles/h");

        }



        public static void Question_04()
        {

            Console.WriteLine("Enter radius:");
            int r = int.Parse(Console.ReadLine());
            double sur = 4 * Math.PI * Math.Pow(r, 2);
            double v = (4 / 3) * Math.PI * Math.Pow(r, 3);

            Console.WriteLine($"Surface = {sur} and Volume = {v}");
        }

        public static void Question_05()

        {
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();


            if ("aeiouAEIOU".IndexOf(input) >= 0)
            {
                Console.WriteLine($"{input} is a vowel.");
            }

            else if (char.IsDigit(input))
            {
                Console.WriteLine($"{input} is a digit.");
            }

            else
            {
                Console.WriteLine($"{input} is other symbol.");
            }
        }


        /// <summary>
        /// check whether a triangle is Equilateral, Isosceles or Scalene
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine("Nhap canh thu nhat:");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh thu hai:");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh thu ba:");
            int s3 = int.Parse(Console.ReadLine());

            if (s1 == s2 && s2 == s3)
            {
                Console.WriteLine("This triangle is Equilateral");
            }

            else if (s1 == s3 || s2 == s3 || s1 == s2)
            {
                Console.WriteLine("This triangle is Isosceles");
            }

            else
            {
                Console.WriteLine("This triangle is Scalene");
            }
        }



        /// <summary>
        /// read 10 numbers and find their average and sum
        /// </summary>
        public static void Question_07()
        {
            int sum = 0;
            double average;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i}:");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            average = sum / 10;

            Console.WriteLine($"Tong 10 so la {sum}");
            Console.WriteLine($"Trung binh 10 so la {average}");
        }



        /// <summary>
        /// display the multiplication table of a given integer
        /// </summary>
        public static void Question_08()
        {
            Console.WriteLine("trinh bay bang cuu chuong may:");
            int so = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int kq = so * i;
                Console.WriteLine($"{so} * {i} = {kq}");
            }



        }

        /// <summary>
        /// display a pattern like triangles with a number
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter the rows of triangle: ");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// display the n terms of harmonic series 
        /// </summary>
        public static void Question_010()
        {
            double sum = 0;
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                Console.Write($"1/{i}");
                if (i == num) break;
                {
                    Console.Write(" + ");
                }
                sum += 1.0 / i;

            }

            Console.Write($"= {sum}");
        }




        /// <summary>
        ///  find the ‘perfect’ numbers within a given number range
        /// </summary>
        public static void Question_011()
        {
            Console.Write("Enter start num: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end num: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"From {start} to {end} :");

            for (int i = start; i <= end; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfect(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            return sum == num;
        }


        /// <summary>
        /// determine whether a given number is prime or not
        /// </summary>
        public static void Question_12()
        {
            Console.WriteLine("Enter number:");
            int n= int.Parse(Console.ReadLine());
            int dem = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {  dem ++; 
                }
            }

            if (dem <= 2)
            { 
                Console.WriteLine($"{n} is a prime number"); 
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number");
            }
        }
    }
}
        
        

      

    

