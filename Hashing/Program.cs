using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTable
{
    public static class HashMethods
    {
        static int user = 0;
        static string[] Hash = { "aa", "ab", "ac", "ad" };

        public static string Search(this String hash)
        {
            string keyValue = "";
            keyValue = Hash[0];    
            return keyValue;
        }

        static bool Targetting(this string hash)
        {
            Console.WriteLine($"hash = {hash}");
            string target = "";
            Console.Write("target 입력 : ");
            target = Console.ReadLine();
            return hash == target; 
        }

      
        static void Main(string[] args)
        {
            if (user == 0)
            {
                Console.WriteLine("=====Search=====");
                string key = "";
                Console.Write("key값 입력: ");
                key = Console.ReadLine();
                string key_value = key.Search();
                Console.WriteLine(key_value);
                user++;
            }
            if (user == 1)
            {
                Console.WriteLine("=====Delete=====");
                List<string> delete = new List<string>(Hash);
                delete.RemoveAll(Targetting);
                Console.WriteLine("=====Result=====");
                foreach (var s in delete)
                    Console.WriteLine($"{s}");
            }
        }

    }
}