using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArmstrongNumber
{
    internal class Armstrong
    {
        static void Main()
        {
            int num, temp, sum = 0, rem;

            Console.WriteLine("Enter a Number: ");
            num = int.Parse(Console.ReadLine());

            int digit = num.ToString().Length;

            temp = num;

            while(num > 0)
            {
                rem = num % 10;
                sum += (int)Math.Pow(rem, digit);
                num = num / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong");
            }
        }
    }
}
