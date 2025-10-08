namespace MirrorRightAngle
{
    internal class MirrorRightAngle
    {
        static void Main()
        {
            int rows;
            Console.Write("How Many Rows You Want: ");
            
            rows = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rows; i++)
            {
                for(int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");

            }
        } 
    }
}
