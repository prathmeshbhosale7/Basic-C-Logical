namespace Palindrom
{
    internal class Palindrom
    {
        static void Main()
        {
            string str, palindrom = "";

            Console.WriteLine("Enter a string: \n");
            str= Console.ReadLine();

            for(int i = str.Length - 1; i >= 0; i--)
            {
                 palindrom += str[i];
            }

            //Console.WriteLine(palindrom);

            if(str == palindrom)
            {
                Console.Write("\nEnter String is Palindrom\n\n");
            }
            else
            {
                Console.Write("\nEnter String is Not Palindrom\n\n");
            }
        }
    }
}
