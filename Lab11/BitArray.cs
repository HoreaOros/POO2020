//using System.Collections;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    internal class BitArray: IEnumerable<bool>
    {
        private byte[] value;
        private int _length;
        public BitArray(int u)
        {
            _length = u;
            value = new byte[_length / 2 + 1];
        }

        public BitArray(byte[] arr)
        {
            _length = 8 * arr.Length;
            value = (byte[])arr.Clone();
        }

        public int Length 
        { 
            get
            {
                return _length;
            }
        }
        public bool this[int index]
        {
            get
            {
                BoundsCheck(index);
                int idx = index / 8;
                int offset = index % 8;
                int result = (value[idx] >> offset) & 1;
                // 0 1 2 3 4 5 6 7 | 8 9 10 11 12 13 14 15 | 16  ... 
                // 0 1 0 0 1 0 0 0 | 1 1 0  0  1  1 ...............
                return result == 1 ? true : false;
            }
            set
            {
                // TODO 
                // modifice un bit 
                BoundsCheck(index);
                int idx = index / 8;
                int offset = index % 8;
                // ....
            }
        }

        private void BoundsCheck(int index)
        {
            if (index < 0 || index >= Length)
                throw new ArgumentOutOfRangeException("Indexul este in afara limitelor");

        }

        public IEnumerator<bool> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                sb.Append(this[i]?"1":"0");
            }
            return sb.ToString();
        }
    }
}
