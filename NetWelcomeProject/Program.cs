namespace NetWelcomeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            VarsLiteralsExample();
            Console.WriteLine(Sum(20, 30));
        }

        static void VarsLiteralsExample()
        {
            int number = 0;
            Int32 numberTwo;
            string str;

            const int MAX = 200;

            number = 123;
            number = -345;
            number = 0b0101111;
            number = 0x12A8E4FD;

            double x = 123.56;
            x = 123.45e-2;
            float y = 123.56F;
            decimal money = 56454.67M;

            char ch = '\x3214';
            ch = 'A';

            string helloStr = "hello";

            Console.WriteLine("Hello, World!");
            Console.Write("Hello, People!");
            Console.WriteLine("Hello, All!");

            Console.Write("Number = ");
            number = int.Parse(Console.ReadLine());
            //number = Convert.ToInt32(Console.ReadLine());
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
