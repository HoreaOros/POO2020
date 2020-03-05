using System;

namespace Lab2
{
    class Rational
    {
        private int numarator, numitor;
        
        public Rational(): this(0, 1)
        {

        }
        public Rational(int numarator): this(numarator, 1)
        {
            
        }

        public Rational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
            System.Console.WriteLine("Am creat un numar rational");
        }

        public Rational Subtract(Rational r2)
        {
            Rational result = new Rational();

            result.numitor = numitor * r2.numitor;
            result.numarator = numarator * r2.numitor - numitor * r2.numarator;

            return result.Reduce();
        }

        public Rational Multiply(Rational r2)
        {
            Rational result = new Rational();

            result.numitor = numitor * r2.numitor;
            result.numarator = numarator * r2.numarator;


            return result.Reduce();
        }

        public Rational Divide(Rational r2)
        {
            return this.Multiply(r2.Inverse()).Reduce();
        }

        private Rational Inverse()
        {
            return new Rational(this.numitor, this.numarator);
        }

        public Rational Power(int k)
        {
            Rational result = new Rational();

            result.numarator = (int)Math.Pow(numarator, k);
            result.numitor = (int)Math.Pow(numitor, k);

            return result.Reduce();
        }

        public Rational Add(Rational r2)
        {
            Rational result = new Rational();
            /*
            a/b + c/d = (a * d + b * c) / (b * d) 
             */
            
            result.numitor = numitor * r2.numitor;
            result.numarator = numarator * r2.numitor + numitor * r2.numarator;


            return result.Reduce();
        }
        public override string ToString()
        {
            return string.Format("[{0} / {1}]", numarator, numitor);
        }
        private Rational Reduce()
        {
            int d;

            d = Util.gcd(Math.Abs(numarator), Math.Abs(numitor));


            return new Rational(numarator / d, numitor / d);
        }
    }
}