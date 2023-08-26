using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryStringTask
{
    public class GoodBinary
    {
        public bool IsGoodBinaryString(List<char> str)
        {
            int CountOfOne = 0;
            int CountOfZero = 0;
        
            for (int i = 0; i < str.Count; i++)
            {
                if (str[i] == '1')
                {
                    CountOfOne++;
                }
                else if (str[i] == '0')
                {
                    CountOfZero++;
                }
        
                if (CountOfOne < CountOfZero)
                {
                    return false;
                }
            }
        
            return CountOfOne == CountOfZero;
        }
    }
}
