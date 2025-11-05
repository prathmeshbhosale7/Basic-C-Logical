namespace ConsoleApp5
{
    internal class Swap_numbers
    {
        static void Main()
        {
            //Swap number with Anti-Cyclic form

            int no1, no2, no3, swap;

            Console.Write("Enter First Number: ");
            no1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            no2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            no3 = int.Parse(Console.ReadLine());


            swap = no1;
            no1 = no3;
            no3 = no2;
            no2 = swap;

            //Console.WriteLine("\nResult of after swapping: \n\n" + no1 + "\n" + no2);


            Console.WriteLine("\nResult of after swapping: \n\n" + no1 + "\n" + no2 + "\n" + no3);
        }
    }
}
