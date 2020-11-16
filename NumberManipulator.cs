using System;
using System.Collections.Generic;
using System.Text;

namespace SomeCovidShiit
{
    class NumberManipulator
    {
        public int FindMax(int first, int second)
        {
            int result;

            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
    }
}
