using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryStringTask
{
    public class GoodBinary
    {
        public bool IsGoodBinaryString(List<char> str, int n)
        {
            int CountOfOne = 0;
            int CountOfZero = 0;
            bool res = false;
            CountOfOne = str.Count(s => s == '1');
            CountOfZero = str.Count(s => s == '0');
            if (CountOfOne != CountOfZero)
            {
                res = false;
                return res;
            }

            for (int i = 0; i < n; i++)
            {
                List<char> pref = str.Take(i + 1).ToList();
                CountOfOne = pref.Count(s => s == '1');
                CountOfZero = pref.Count(s => s == '0');
                if (CountOfOne < CountOfZero)
                {
                    res = false;
                    return res;
                }
            }
            res = true;
            return res;
        }
    }
}
