using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExcersise
{
    class Palindrom
    {
        public void main()
        {
            Console.WriteLine("enter the string");
            string input = Console.ReadLine(),rev="";

            for (int i = input.Length-1; i <= 0; i--)
            {
                rev += input[i];
            }
            Console.WriteLine(rev);
            if (input == rev)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is not a palindrome");
            }
        }
    }
}
