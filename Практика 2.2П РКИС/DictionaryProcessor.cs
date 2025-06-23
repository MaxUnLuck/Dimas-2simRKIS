using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР3РКИС
{
    public class DictionaryProcessor
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        private Random random = new Random();
        private readonly string[] sampleKeys = { "яблоко", "банан", "апельсин", "груша", "виноград", "лимон" };
        private readonly string[] sampleValues = { "красный", "желтый", "оранжевый", "зеленый", "фиолетовый", "желтый" };
        public void AddPair(string key, string value)
        {
            if (dictionary.ContainsKey(key))
            {
                throw new ArgumentException($"Ключ '{key}' уже существует");
            }
            dictionary.Add(key, value);
        }

        public void GenerateRandomPairs(int count)
        {
            dictionary.Clear();
            for (int i = 0; i < count; i++)
            {
                string key = sampleKeys[random.Next(sampleKeys.Length)] + (i > 0 ? i.ToString() : "");
                string value = sampleValues[random.Next(sampleValues.Length)];

                dictionary[key] = value;
            }
        }
        public Dictionary<string, string> GetDictionary()
        {
            return new Dictionary<string, string>(dictionary);
        }

        public Dictionary<string, int> FindDuplicateValues()
        {
            return dictionary.Values.GroupBy(v => v).Where(g => g.Count() > 1).ToDictionary(g => g.Key, g => g.Count());
        }
        public void Clear()
        {
            dictionary.Clear();
        }
    }
}

