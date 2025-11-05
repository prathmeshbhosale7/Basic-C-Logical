namespace Demo
{
    internal class Demo
    {
        static void Main()
        {

            Console.Write("How many number you type: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter Number {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even Number :");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    //Console.WriteLine(arr[i]);
                    Console.WriteLine(arr[i] + " is Even");
                }
                else
                {
                    Console.WriteLine(arr[i] + " is Odd");
                }
            }

            //Console.WriteLine("Odd Number :");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            // you want seperate list of 


            //---------------Checked with Default Value---------------


            //int[] num = { 11, 25, 36, 4, 55, 68, 99, 64, 67, 3, 45 };

            //for(int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //        Console.WriteLine(num[i] + " is Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine(num[i] + " is Odd");
            //    }
            //}

        }
    }
}
