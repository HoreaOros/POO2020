using System;

namespace Lab2_2
{
    class Rational
    {
        private int numarator, numitor;

        public Rational(): this(0, 1)
        {
            Console.Write("Rational() -->> ");
        }

        public Rational(int numarator, int numitor)
        {
            Console.Write("Rational(int, int) -->> ");
            // this este o referinta la obiectul pentru care
            // a fost apelata metoda care exista doar in metodele instanta
            this.numarator = numarator;
            this.numitor = numitor;
            Console.WriteLine("Am creat un numar rational {0}", this);
        }

        public Rational Subtract(Rational r2)
        {
            Console.Write("Subtract -->> ");
            Rational result = new Rational();

            result.numitor = numitor * r2.numitor;
            result.numarator = numarator * r2.numitor - r2.numarator * numitor;

            return result.Reduce();
        }

        public Rational Multiply(Rational r2)
        {
            Console.Write("Multiply -->> ");
            Rational result = new Rational();

            result.numitor = numitor * r2.numitor;
            result.numarator = numarator *  r2.numarator;

            return result.Reduce();

        }

        public Rational Divide(Rational r2)
        {
            Console.Write("Divide -->> ");
            return this.Multiply(r2.Inverse()).Reduce();
        }

        public Rational Inverse()
        {
            Console.Write("Inverse -->> ");
            return new Rational(numitor, numarator);
        }

        public Rational Power(int k)
        {
            Console.Write("Power -->> ");
            return new Rational((int)Math.Pow(numarator, k), (int)Math.Pow(numitor,k));
        }


        public Rational(int v): this(v, 1)
        {
            Console.Write("Rational(int) -->> ");
        }

        public Rational Add(Rational r2)
        {
            Console.Write("Add -->> ");
            Rational result = new Rational();

            result.numitor = numitor * r2.numitor;
            result.numarator = numarator * r2.numitor + r2.numarator * numitor;



            return result.Reduce();
        }

        private Rational Reduce()
        {
            int d = Util.gcd(Math.Abs(numarator), Math.Abs(numitor));


            return new Rational(numarator / d, numitor / d);
        }

        public override string ToString()
        {
            return string.Format("[{0} / {1}]", numarator, numitor);
        }
    }
}