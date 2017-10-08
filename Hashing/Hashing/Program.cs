using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public static class ExtensionMethods
    {
        static int[] Hash = { 1122, 22342, 5233415, 65677654 };
        public static int GetMyHash(this String hash)
        {
            int hashcode = 0;
            for (int i = 0; i < hash.Length; i++)
                hashcode += Hash[i] * (hash[i] - 'a');
            return hashcode;
        }
        static void Main(string[] args)
        {
            string hello = "hello";
            int hashCode = hello.GetMyHash();
            Console.WriteLine(hashCode);
        }
    }
}
