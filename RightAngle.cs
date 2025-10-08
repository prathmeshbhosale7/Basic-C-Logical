namespace RightAngleStarStructure
{
    internal class RightAngle
    {
        static void Main()
        {
            Console.Write("How Many Rows You Want: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j >= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
