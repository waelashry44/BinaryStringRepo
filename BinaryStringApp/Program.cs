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
            string result = $"Is Good Binary String : {count.IsGoodBinaryString(input)}";
            Console.WriteLine(result);
        }
    }
}
