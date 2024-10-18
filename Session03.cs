namespace LeVuNgocGiang_Exercise
{
    internal class Session03
    {
        public static void Main(string[] args)
        {
            //Question_01();
            
            Question_02();


            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        /// <summary>
        /// convert celsius to kelvin and fahrenheit
        /// </summary>
        public static void Question_01()

        {
            Console.WriteLine("Enter celsius degree: ");
            int c = int.Parse(Console.ReadLine());

            int k = c + 273;
            int f = c * (18 / 10) + 32;

            Console.WriteLine($"Kelvin = {k} Fahrenheit = {f}");


        }

        public static void Question_02()
        {
            const double P = Math.PI;
            Console.WriteLine("Enter radius");

            int r = int.Parse(Console.ReadLine());

            double a = Math.Pow(r,2);
            double b = Math.Pow(r, 3);

            double s = (4 / 3) * P * a;
            double v = (4 / 3) * P * b;

            Console.WriteLine($@"Srface: {s}
Volume: {v}");



        }

        public static void Question_03() 
        {

            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int add = a + b;
            int s = a - b;
            int mul = a * b;
            int d = a * b;

            Console.WriteLine($@"tong 



        }

    }
}
