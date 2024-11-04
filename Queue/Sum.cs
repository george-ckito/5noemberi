using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5noemberi.Quene
{
    internal class Sum
    {
        public void Execute()
        {
            Queue<int> quene = new Queue<int>();
            quene.Enqueue(4);
            quene.Enqueue(10);
            quene.Enqueue(8);
            quene.Enqueue(1);
            quene.Enqueue(31);
            quene.Enqueue(23);
            Console.Write("Original Quene: ");
            foreach (var item in quene)
            {
                Console.Write(item + " ");
            }
            int sum = 0;
            while (quene.Count > 3)
            {
                quene.Dequeue();
            }
            foreach (int item in quene)
            {
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of first three elements: " + sum);
        }
    }
}
