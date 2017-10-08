using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public static class HashMethod
    {
        static string[] Hash = { "ab","ac","ad","ae","af","ag"}; // n개의 array형태 버킷
        
        public static string HashTable(this string hash)
        {
            string solution = "";
            solution = Hash[0];
            return solution;
        }
        static void Main(string[] args)
        {
            string s= "";
            string hashValue = s.HashTable();
            Console.Write("값 입력 : ");
            s = Console.ReadLine();
            Console.WriteLine($"{hashValue}", hashValue);
        }
    }

}
