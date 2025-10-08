namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("How many numbers you want: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter Number {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine()); 
            }



            foreach(int num in arr)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine(num + " is Even");
                }
                else
                {
                    Console.WriteLine(num + " is Odd");
                }
            }
        }
    }
}
