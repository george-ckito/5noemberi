using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5noemberi.Dictionary
{
    internal class DictionaryAvarage
    {
        public void Execute()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("giorgi", 9);
            dictionary.Add("taso", 2);
            dictionary.Add("gabrieli", 8);
            dictionary.Add("ramazi", 2);
            dictionary.Add("luka", 5);
            dictionary.Add("vaniko", 7);

            int sum = 0;
            foreach (var item in dictionary)
            {
                sum += item.Value;
            }
            Console.WriteLine("Avarage: " + sum / dictionary.Count);
        }
    }
}
