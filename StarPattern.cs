namespace Demo1
{
    internal class Demo
    {
        static void Main()
        {
            int rows;
            Console.Write("Home namy rows you want: ");
            rows = int.Parse(Console.ReadLine());

            // Right Angle Triangle Pattern

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            // Mirror Right Angle Triangle Pattern

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows - 1; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("\n");

            }

            // Pyramid Pattern


            for (int i = 1; i <= rows; i++) // Total rows of pyramid  
            {
                for (int j = 1; j <= rows - i; j++)         // Loop For Space
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++) //increase the value  
                {
                    Console.Write("*");
                }

                for (int l = i - 1; l >= 1; l--) //decrease the value  
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
