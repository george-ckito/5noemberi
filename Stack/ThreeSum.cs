using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5noemberi.Stack
{
    internal class ThreeSum
    {
        public void Execute()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(10);
            stack.Push(8);
            stack.Push(1);
            stack.Push(31);
            stack.Push(23);
            Console.Write("Original Stack (reversed): ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            int sum = 0;
            while (stack.Count > 3)
            {
                stack.Pop();
            }
            foreach (int item in stack)
            {
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of first three elements: " + sum);

        }
    }
}
