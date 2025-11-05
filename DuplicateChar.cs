namespace Duplicate_element_in_array
{
    internal class DuplicateChar
    {
        static void Main()
        {
            string str, empty = "";

            string dup = "";

            Console.Write("Enter String: ");
            str = Console.ReadLine();

            foreach(char c in str)
            {
                if (!empty.Contains(c))
                {
                    empty += c;
                }
                else
                {
                    dup += c;
                }

            }

            Console.Write("\nRemove Duplicate Char: " + empty + "\n");
            Console.Write("\nDuplicate Char is: " + dup + "\n");

        }
    }
}
