namespace Order_Array_Asce_Dsce
{
    internal class Order_Array_Asce_Dsce
    {
        static void Main()
        {
            int[] arr = { 5, 2, 8, 1, 4, 7, 6, 3 };
            int temp;

            // Ascending Order

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Ascending Order: " + "\n{ ");
            foreach(int no in arr)
            {
                Console.Write(no + " ");
            }
            Console.Write(" }\n\n");

            // Now sorting in descending order

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Descending Order: " + "\n{ ");
            foreach (int no in arr)
            {
                Console.Write(no + " ");
            }
            Console.Write(" }\n");


        }
    }
}
