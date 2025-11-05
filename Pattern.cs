namespace Demo2
{
    internal class Pattern
    {
        static void Main()
        {
            int rows;
            Console.Write("How many rows you want: ");
            rows = int.Parse(Console.ReadLine());

            // Right Angle Triangle

            for (int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            // Mirror Right Angle Triangle

            for (int i = 1; i <= rows; i++)
            {
                for(int j = i; j < rows; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            // Pyramid Pattern

            for (int i = 1; i <= rows; i++)
            {
                for(int j = i; j < rows; j++)
                {
                    Console.Write(' ');
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                }

                for(int l = i; l > 1; l--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            // Same Row Same Column Pattern Pyramid

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows ; j++)
                {
                    Console.Write(' ');
                }

                for(int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}