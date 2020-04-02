using System;
using System.IO;

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            LR a = new LR("input.txt");
            // data = 6, 3, 1, 2, 6, 10,  7, 11, 16
            // L    = 6, 6, 6, 6, 6, 10, 10, 11, 16
            // R    = 1, 1, 1, 2, 6,  7,  7, 11, 16
            // varianta ineficienta de rezolvare. 
            //int[] v = { 6, 3, 1, 2, 6, 10, 7, 11, 16 };
            //int contor = 0;
            //for (int i = 1; i < v.Length - 1; i++)
            //{
            //    bool ok = true;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (v[i] < v[j])
            //        {
            //            ok = false;
            //        }
            //    }

            //    for (int k = i + 1; k < v.Length - 1; k++)
            //    {
            //        if (v[i] > v[k])
            //        {
            //            ok = false;
            //        }
            //    }
            //    if (ok)
            //    {
            //        contor++;
            //    }
            //}
            a.ReadData();
            a.ProcessData();
            a.ShowResults();
        }
    }
}
