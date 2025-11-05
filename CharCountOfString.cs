namespace Character_count_in_string
{
    internal class CharCountOfString
    {
        static void Main()
        {
            string str;
            Console.WriteLine("Enter a String: ");
            str = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (var pair in charCount)
            {
                Console.WriteLine(pair.Key + ":" + pair.Value);
            }
        }
    }
}
