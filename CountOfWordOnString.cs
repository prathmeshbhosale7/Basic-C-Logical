namespace Word_Count_of_string
{
    internal class CountOfWordOnString
    {
        static void Main()
        {
            string str;
            int count = 1, len = 0;

            Console.WriteLine("Enter String:");
            str = Console.ReadLine();

            while (len <= str.Length - 1)
            {
                if (str[len] == ' ' || str[len] == '\n' || str[len] == '\t')
                {
                    count++;
                }
                len++;
            }

            Console.WriteLine("Count of word: " + count);
            Console.ReadLine();

        }
    }
}
