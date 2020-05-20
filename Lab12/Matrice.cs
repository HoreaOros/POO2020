using System;
using System.Text;

namespace Lab12
{
    public class Matrice: ICloneable
    {
        private static readonly Random rnd = new Random();
        private readonly int linii;
        private readonly int coloane;
        private int[,] data;

        public Matrice(int linii, int coloane)
        {
            this.linii = linii;
            this.coloane = coloane;
            data = new int[linii, coloane];
        }
        public int Linii { get => linii; }
        public int Coloane { get => coloane; }


        public int this[int linie, int coloana]
        {
            get
            {
                if (linie < 0 || coloana < 0 || linie >= Linii || coloana >= Coloane)
                    throw new ArgumentOutOfRangeException();
                return data[linie, coloana];
            }
            set
            {
                if (linie < 0 || coloana < 0 || linie >= Linii || coloana >= Coloane)
                    throw new ArgumentOutOfRangeException();
                data[linie, coloana] = value;
            }
        }

        public void RandomInit(int min, int max)
        {
            for (int i = 0; i < Linii; i++)
            {
                for (int j = 0; j < Coloane; j++)
                {
                    this[i, j] = rnd.Next(min, max + 1);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Linii; i++)
            {
                for (int j = 0; j < Coloane; j++)
                {
                    sb.AppendFormat("{0,3}", this[i, j]);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        // TODO: implementare <corecta> a metodei Equals
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public object Clone()
        {
            Matrice result = new Matrice(Linii, Coloane);

            //result.data = (int[,])this.data.Clone();

            for (int i = 0; i < Linii; i++)
            {
                for (int j = 0; j < Coloane; j++)
                {
                    result[i, j] = this[i, j];
                }
            }

            return result;
        }

        public static Matrice operator*(Matrice m1, Matrice m2)
        {
            if (m1.Coloane != m2.Linii)
            {
                throw new InvalidOperationException("Numarul de coloane a operandului din stanga nu este egal cu numarul de linii a opeandrului din dreapta");
            }
            Matrice result = new Matrice(m1.Linii, m2.Coloane);

            for (int i = 0; i < m1.Linii; i++)
            {
                for (int j = 0; j < m2.Coloane; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < m1.Coloane; k++)
                    {
                        suma += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = suma;
                }
            }
            return result;
        }

        // TODO supraincarcarea operatului + si - (operatorii binari);


        public static bool operator==(Matrice m1, Matrice m2)
        {
            if (m1.Linii != m2.Linii || m1.Coloane != m2.Coloane)
            {
                throw new InvalidOperationException("Matricile nu pot fi comparate");
            }
            for (int i = 0; i < m1.Linii; i++)
            {
                for (int j = 0; j < m1.Coloane; j++)
                {
                    if (m1[i, j] != m2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Matrice m1, Matrice m2)
        {
            return !(m1 == m2);
        }
        
    }
}