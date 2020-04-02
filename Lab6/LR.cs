using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// https://www.pbinfo.ro/probleme/2623/lr
namespace LR
{
    class LR
    {
        private int n;
        private int[] data;
        private int[] L, R;
        private string filename;

        public void ShowResults()
        {
            for (int i = 1; i < data.Length - 1; i++)
            {
                if (data[i] == L[i] && L[i] == R[i])
                {
                    Console.WriteLine(data[i]);
                }
            }
        }

        public void ProcessData()
        {
            L = new int[data.Length];
            R = new int[data.Length];

            int maxim = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > maxim)
                {
                    maxim = data[i];
                }
                L[i] = maxim;
            }

            int minim = data[data.Length - 1];
            for (int j = data.Length - 1; j >= 0; j--)
            {
                if (data[j] < minim)
                {
                    minim = data[j];
                }
                R[j] = minim;
            }
        }

        public void ReadData()
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                line = sr.ReadLine();

                n = int.Parse(line);

                line = sr.ReadLine();
                string[] tokens;
                char[] seps = { ' ', ',', ';' };
                tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

                data = new int[tokens.Length];
                n = tokens.Length;
                int i = 0;
                foreach (var item in tokens)
                {
                    data[i++] = int.Parse(item);
                }
            }
        }

        public LR(string filename)
        {
            this.filename = filename;
        }
    }
}
