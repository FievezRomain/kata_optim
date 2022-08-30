using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            List<KeyValuePair<int, String>> words = new List<KeyValuePair<int, String>>();

            int i = 0;
            string stringToTest;
            while (true)
            {
                stringToTest = newString();
                try
                {
                    if(words.Where(kvp => kvp.Value == stringToTest).Count() == 0)
                    {
                        words.Add(new KeyValuePair<int, String>(stringToTest.GetHashCode(), stringToTest));
                        if (hash.ContainsKey(stringToTest.GetHashCode()))
                        {
                            hash[stringToTest.GetHashCode()] = hash[stringToTest.GetHashCode()] + 1;
                            if (hash.Values.Contains(3))
                            {
                                break;
                            }
                        }
                        else
                        {
                            hash.Add(stringToTest.GetHashCode(), 1);
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }

            int collisionHash = stringToTest.GetHashCode();
            List<String> filter = words.Where(kvp => kvp.Key == collisionHash)
                           .Select(kvp => kvp.Value)
                           .ToList();
            Console.WriteLine("\"{0}\" and \"{1}\" and \"{2\" have the same hash code {3}", filter.ElementAt(0), filter.ElementAt(1), filter.ElementAt(2), collisionHash);
            Console.ReadLine();
        }
        public static String newString()
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
