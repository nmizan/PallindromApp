using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pallindrumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Enter a Text");
            s = Console.ReadLine();
            string rev="";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];

            }

            Console.WriteLine("Reverse is " +rev);
            if (rev.Equals(s) == true)
            {
                Console.WriteLine("pallindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            }
            Console.Read();
        }
    }
}
