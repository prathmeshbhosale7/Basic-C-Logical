namespace Prime_Number
{
    internal class MinMax
    {
        static void Main()
        {
            int max, min;
            Console.Write("How many numbers you want: ");
            int size = int.Parse(Console.ReadLine());

            int[] num = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter Number {0}: ", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }


            max = num[0];
            min = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }

                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            Console.Write("\nMaximum Number is: " + max);
            Console.Write("\nMinimum Number is: " + min);

        }
    }
}
