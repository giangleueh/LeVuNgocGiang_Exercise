namespace LeVuNgocGiang_Exercise

{
    internal class Session02


    {
        public static void Main1(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }



        /// <summary>
        /// to Add/Sum two numbers
        /// </summary>
        public static void Question_01()
        {
            Console.WriteLine("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} * {b} = {product}");
        }




        /// <summary>
        ///  to Swap Values of Two Variables
        /// </summary>
        public static void Question_02()
        {
            Console.WriteLine("Enter a number x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number y = ");
            int y = int.Parse(Console.ReadLine());

            int m = x;
            x = y; y = m;
            Console.WriteLine($"So x moi la {x}, So y moi la {y}");
        }




        /// <summary>
        /// to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.WriteLine("Enter a decimal number a = ");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter a decimal number b = ");
            decimal b = decimal.Parse(Console.ReadLine());

            decimal multiply = a * b;

            Console.WriteLine($"{a} * {b} = {multiply}");
        }





        /// <summary>
        /// to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            const double feet = 0.3048;
            Console.WriteLine("Enter your feet");
            double a = double.Parse(Console.ReadLine());

            double meter = feet * a;

            Console.WriteLine($"Your meter is {meter} m");
        }




        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.WriteLine("Choose 1: convert Celsius to Fahrenheit, 2: convert Fahrenheit to Celsius");
            String choose = Console.ReadLine();
            if (choose == "1")
            {

                Console.WriteLine("Enter celsius");
                float c = float.Parse(Console.ReadLine());
                float f = c * (9 / 5) + 32;
                Console.WriteLine($"Fahrenheit temperature is {f} F");
            }
            else
            {
                Console.WriteLine("Enter fahrenheit");
                float f = float.Parse(Console.ReadLine());
                float c = f * (5 / 9) - 32;
                Console.WriteLine($"Celsius temperature is {c} C");
            }


        }




        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06() 
        {
        
        int x = sizeof(int);
            Console.WriteLine($"Size of data type int la: {x}");
        
        
        }





        /// <summary>
        /// to Print ASCII Value 
        /// </summary>
        public static void Question_07() 
        {

            Console.WriteLine("Enter one character");
            Char inputchar = char.Parse(Console.ReadLine());
            
            int ascii = (int)inputchar;

            Console.WriteLine($"The ASCII value of {inputchar} : {ascii}");


        }





        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08() 
        {
           
            Console.WriteLine("Nhap ban kinh: ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a * Math.PI;
            Console.WriteLine($"Circle area is {area}");


        }



        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        public static void Question_09() 
        {

            Console.WriteLine("Nhap canh hinh vuong: ");
            double a = double.Parse(Console.ReadLine());

            double area = a * a;
            Console.WriteLine($"Square area is {area}");


        }



        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        public static void Question_10() 
        {

            Console.WriteLine("Enter days");
            int days = int.Parse(Console.ReadLine());
            int year = days / 365;
            int day_week = days - year * 365;
            int week = day_week / 7;
            int d = day_week % 7;
            Console.WriteLine($"{days} days including {year} years, {week} weeks, {d} days");

        
        
        }
    }
}