namespace SumDivMulSub_Maths
{
    internal class Maths
    {
        static void Main()
        {
            int no1, no2, Add, Mul, Sub;
            float Div;

            Console.Write("Enter First Number: ");
            no1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter First Number: ");
            no2 = int.Parse(Console.ReadLine());

            Add = no1 + no2;

            Console.Write("\nAddition is : " + Add + "\n\n");

            Mul = no1 * no2;

            Console.Write("\nMultiplication is : " + Mul + "\n\n");

            Div = (float)no1 / no2;         // Remainder show with / symbol and Quotient show with %

            Console.Write("\nDivision is : " + Div + "\n\n");

            Sub = no1 - no2;

            Console.Write("\nSubstraction is : " + Sub + "\n\n");
        }
    }
}
