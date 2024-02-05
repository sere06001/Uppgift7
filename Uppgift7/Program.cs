using System;
using System.Collections.Generic;
namespace uppgift7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings1 = { "a", "b", "b", "c", "hej" };
            string[] strings2 = { "hej", "a", "a", "b", "programmering" };
            foreach (string gemensamtOrd in FinnsIBåda(strings1, strings2))
            {
                Console.WriteLine(gemensamtOrd);
            }
            Console.ReadKey();
        }
        static List<string> FinnsIBåda(string[] a, string[] b)
        {
            List<string> list = new List<string>();
            foreach (string s in a)
            {
                foreach (string s2 in b)
                {
                    if (s == s2 && !list.Contains(s))
                    {
                        list.Add(s2);
                    }
                }
            }
            return list;
        }
    }
}