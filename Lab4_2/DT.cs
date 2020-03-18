using System;

namespace Lab4_2
{
    public class DT
    {
        private int h, mm, ss, zi, luna, an;
        public DT(): base()
        {
            DateTime dt = DateTime.Now;

            h = dt.Hour;
            mm = dt.Minute;
            ss = dt.Second;
            zi = dt.Day;
            luna = dt.Month;
            an = dt.Year;
        }
        public DT(int an, int luna, int zi, int h, int mm, int ss)
        {
            // validarea datelor furnizate

            this.h = h;
            this.mm = mm;
            this.ss = ss;
            this.zi = zi;
            this.luna = luna;
            this.an = an;
        }

        // proprietate readonly
        public int Year 
        { 
            get
            {
                return an;
            }
            //set
            //{
            //    an = value;
            //}
        }

        public void AddYears(int y)
        {
            an += y;
        }

        // TODO
        // proprietati readonly pentru celelalte campuri

        public override string ToString()
        {
            return h.ToString() + ":" + mm.ToString() + ":" + ss.ToString() + " " + 
                zi.ToString() + "/" + luna.ToString() + "/" + an.ToString();
        }
    }
}