using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class ReverseString
    {
        static void Main()
        {
            string str, reverse = "";

            Console.WriteLine("Enter String:");
            str = Console.ReadLine();
                                                                // Hello 
            for (int i = str.Length - 1; i >= 0; i--)           // 01234       
            {
                reverse += str[i];  
            }
            Console.WriteLine(reverse);

        }
    }
}
