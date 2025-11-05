namespace SwapStringWithoutThirdVariable
{
    internal class SwapStringWithoutThirdVariable
    {
        static void Main()
        {
            string str1, str2;

            Console.Write("Enter str1: ");
            str1 = Console.ReadLine();

            Console.Write("Enter str2: ");
            str2 = Console.ReadLine();

            str1 += str2;

            str2 = str1.Substring(0, str1.Length - str2.Length);

            str1 = str1.Substring(str2.Length);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
