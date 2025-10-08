namespace Average_of_Number
{
    internal class Average
    {
        static void Main()
        {
            float Average;
            int add = 0;
            Console.Write("How Many Numbers of Average You Want: ");

            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\nWrite No {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //  0123
            //  1234

            for(int i = 0; i < arr.Length; i++)
            {
                add += arr[i];
            }

            Console.WriteLine("\nAddition of input number is: " + add);

            Average = (float)add / arr.Length;

            Console.Write("\nAverage of Input Number is: " + Average + "\n");

        }
    }
}
