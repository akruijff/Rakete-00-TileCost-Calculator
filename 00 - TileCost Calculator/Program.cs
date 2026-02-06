namespace _00___TileCost_Calculator
{
    internal class Program
    {
        const int SQUARE_FEET_PER_HOUR = 20;
        const int PRICE_PER_HOUR = 86;
        const int OPTION_RECTANGLE = 1;
        const int OPTION_TRIANGLE = 2;

        static void Main(string[] args)
        {
            SecondTask(args);
        }

        static void FirstTask(string[] args)
        {
            Console.WriteLine("Please enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int surface = width * length;
            int cost = surface * PRICE_PER_HOUR / SQUARE_FEET_PER_HOUR;
            Console.WriteLine($"The surface is: {surface}");
            Console.WriteLine($"The cost is: ${cost}");
        }

        static void SecondTask(string[] args)
        {
            Console.WriteLine("Please pick a shape:");
            Console.WriteLine($"{OPTION_RECTANGLE} - Rectangle");
            Console.WriteLine($"{OPTION_TRIANGLE} - Triangle");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (selection)
            {
                case OPTION_RECTANGLE:
                    PerformCalculationForRectangle();
                    break;
                case OPTION_TRIANGLE:
                    PerformCalculationForTriangle();
                    break;
            }
        }

        static void PerformCalculationForRectangle()
        {
            Console.WriteLine("Please enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int surface = width * length;
            int cost = surface * PRICE_PER_HOUR / SQUARE_FEET_PER_HOUR;
            Console.WriteLine($"The surface is: {surface}");
            Console.WriteLine($"The cost is: ${cost}");
        }

        static void PerformCalculationForTriangle()
        {
            Console.WriteLine("Please enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int surface = width * length;
            int cost = surface * PRICE_PER_HOUR / SQUARE_FEET_PER_HOUR / 2;
            Console.WriteLine($"The surface is: {surface}");
            Console.WriteLine($"The cost is: ${cost}");
        }

        // At this point I would refactor
    }
}
