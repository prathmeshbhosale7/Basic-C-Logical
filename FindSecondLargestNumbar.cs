namespace Find_second_largsdt_number_in_array
{
    internal class FindSecondLargestNumbar
    {
        static void Main()
        {
            int max1, max2;

            int[] arr = { 12, 34, 53, 101, 23, 60, 37, 85, 41, 83, 46, 30 };

            max1 = max2 = arr[0];

            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > max1)       //if arr[i] is bigger than max1 then if block call and save max1 value in max2 and max1 get arr[i] bigger value
                {
                    max2 = max1;
                    max1 = arr[i]; 
                }
                else if (arr[i]>max2)                   // if arr[i] is small than recent value of max1 then else block called and max2 store arr[i] value
                { 
                    max2 = arr[i];
                }
            }

            Console.WriteLine("Maximum value 1:" + max1);
            Console.WriteLine("Maximum value 2:" + max2);
        }
    }
}
