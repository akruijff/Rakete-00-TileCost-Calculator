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
            int selection = GetShapeSelection(args);

            int surface = 0;
            switch (selection)
            {
                case OPTION_RECTANGLE:
                    surface = PerformCalculationForRectangle();
                    break;
                case OPTION_TRIANGLE:
                    surface = PerformCalculationForTriangle();
                    break;
            }
            WriteCost(surface);
        }

        static int GetShapeSelection(string[] args)
        {
            Console.WriteLine("Please pick a shape:");
            Console.WriteLine($"{OPTION_RECTANGLE} - Rectangle");
            Console.WriteLine($"{OPTION_TRIANGLE} - Triangle");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return selection;
        }

        static int PerformCalculationForRectangle()
        {
            Console.WriteLine("Please enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return width * length;
        }

        static int PerformCalculationForTriangle()
        {
            Console.WriteLine("Please enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return width * length / 2;
        }

        static void WriteCost(int surface)
        {
            int cost = surface * PRICE_PER_HOUR / SQUARE_FEET_PER_HOUR;
            Console.WriteLine($"The surface is: {surface}");
            Console.WriteLine($"The cost is: ${cost}");
        }
    }
}
