using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5noemberi.Dictionary
{
    internal class CLassStudents
    {
        public void Execute()
        {
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
            dictionary.Add("7A", new string[3] { "giorgi", "ramazi", "gabrieli" });
            dictionary.Add("10G", new string[4] { "sandro", "aleqsadnre", "dachi", "mariami" });
            dictionary.Add("12B", new string[2] { "anastasia", "apoloni" });
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} has {item.Value.Length} students");
            }
        }
    }
}
