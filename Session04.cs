

namespace LeVuNgocGiang_Exercise
{
    internal class Session04
    {
        public static void Main(string[] args)
        {
            Question_02();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
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

        public static void Question_03()

        {
            Console.WriteLine("Enter distance: ");
            double d =double.Parse(Console.ReadLine());
            double 

            Console.WriteLine("Enter hours: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter minutes: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter seconds: ");
            int s = int.Parse(Console.ReadLine());


        }

    }
}
