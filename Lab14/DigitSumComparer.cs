using System;
using System.Collections.Generic;

namespace Lab14
{
    internal class DigitSumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int digitSumX, digitSumY;
            digitSumX = DigitSum(x);
            digitSumY = DigitSum(y);
            if (digitSumX < digitSumY)
            {
                return -1;
            }
            else if (digitSumX > digitSumY)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else if (x > y)
            {
                return 1;
            }
            else
                return 0;
        }

        private int DigitSum(int x)
        {
            if (x == 0)
                return 0;
            else
                return x % 10 + DigitSum(x / 10);
        }
    }
}