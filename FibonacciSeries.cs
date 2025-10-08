namespace Fibonacci_Series
{
    internal class FibonacciSeries
    {
        static void Main()
        {
            int firstNo = 0, secondNo = 1, nextNo, len;

            Console.Write("Enter the number of elements in the Fibonacci series: ");
            len = int.Parse(Console.ReadLine());
            
            if(len < 2)
            {
                Console.WriteLine("Please enter a number greater than or equal to 2.");
            }
            else
            {
                Console.Write(firstNo + " " + secondNo + " ");

                for (int i = 2; i < len; i++)
                {
                    nextNo = firstNo + secondNo;
                    Console.Write(nextNo + " ");
                    firstNo = secondNo;
                    secondNo = nextNo;
                }
            }
        }
    }
}
