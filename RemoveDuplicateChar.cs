namespace RemoveDuplicateChar
{
    internal class RemoveDuplicateChar
    {
        static void Main()
        {
            string str, emptyStr = "";

            //Console.WriteLine("Enter a string: ");
            //str = Console.ReadLine();

            //for(int i = 0; i < str.Length; i++)
            //{
            //    if (!emptyStr.Contains(str[i]))
            //    {
            //        emptyStr += str[i];
            //    }
            //}

            //Console.Write("\nString is: " + emptyStr + "\n\n");


            string[] arr = new string[5];
            string[] empty = new string[5];
            string dup = "";

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a string {0}: ",i + 1);
                arr[i] = Console.ReadLine();
            }

            for(int j = 0; j < arr.Length; j++)
            {
                if (!empty.Contains(arr[j]))
                {
                    empty[j] = arr[j];
                }
                else
                {
                    dup += arr[j];
                }
            }

            foreach(string str1 in empty)
            {
                Console.Write(str1 + " ");
            }

            //Console.Write(empty);
            Console.Write(dup);


            //Console.WriteLine("Enter a string: ");
            //str = Console.ReadLine();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!emptyStr.Contains(str[i]))
            //    {
            //        emptyStr += str[i];
            //    }
            //}

            //Console.Write("\nString is: " + emptyStr + "\n\n");
        }
    }
}
