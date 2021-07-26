using System;
using System.Linq;

namespace SampleTest2.ACA
{
    class Program
    {
        /// <summary>
        /// String
        /// Print all the duplicates and their counts in the input string
        /// </summary>

        static void Main(string[] args)
        {
            Console.Write("Input TEXT! - ");
            string text = Console.ReadLine();

            Console.WriteLine("LINQ:");
            FindDuplicateItemsWithLINQ(text);

            Console.WriteLine("NORMAL:");
            FindDuplicateItems(text);
        }


        public static void FindDuplicateItemsWithLINQ(string text)
        {
            var query = text.GroupBy(x => x)
                            .Where(y => y.Count() > 1)
                            .Select(k => k.Key)
                            .ToList();

            var count = text.GroupBy(x => x)
                            .Where(y => y.Count() > 1)
                            .Select(k => k.Count())
                            .ToList();

            var num = query.Count;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{query[i]} - Count: {count[i]}");
            }
        }

        public static void FindDuplicateItems(string text)
        {
            int count = 1;
            char current = ' ';
            bool check = false;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        count++;
                        current = text[j];
                        check = true;
                        text = text.Remove(j, 1);
                        j--;
                    }
                }
                if (check)
                {
                    Console.WriteLine($"{current} - Count: {count}");
                }
                check = false;
                count = 1;
            }
        }
    }
}