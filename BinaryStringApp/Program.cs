using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryStringTask
{
    class Program
    {

        static void Main(string[] args)
        {
            GoodBinary count = new GoodBinary();
            string input = Console.ReadLine();
            List<char> str = input.ToCharArray().ToList();
            int n = str.Count;
            string result = string.Format("Is Good Binary String : {0}", count.IsGoodBinaryString(str, n));
            Console.WriteLine(result);
        }
    }
}
