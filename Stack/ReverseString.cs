using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5noemberi.Stack
{
    internal class ReverseString
    {
        public void Execute()
        {
            Stack<char> stack = new Stack<char>();
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                stack.Push(item);
            }
            Console.Write("Reversed string: ");
            foreach(char item in stack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
