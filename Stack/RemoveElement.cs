using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5noemberi.Stack
{
    internal class RemoveElement
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
            Console.WriteLine();
            Console.Write("Enter element to remove: ");
            int element = int.Parse(Console.ReadLine());
            List<int> tempList = new List<int>();
            while (stack.Count > 0)
            {
                int item = stack.Pop();
                if (item != element)
                {
                    tempList.Add(item);
                }
            }
            foreach (int item in tempList)
            {
                stack.Push(item);
            }
            Console.Write("Stack after removing element: ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
