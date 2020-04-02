using System;
using System.Text;
using System.Collections.Generic;
namespace Lab5
{
    internal class ContBancar
    {
        private int id;
        private string titular;
        // **********************************
        internal decimal sold; // !!! soldul trebuie sa fie private, altfel poate fi modificat in mod neautorizat
        // **********************************
        private static int count = 0;
        private List<Tranzactie> tranzactii;
        public ContBancar(string titular)
        {
            id = ++count;
            this.titular = titular;
            sold = 0M;
            tranzactii = new List<Tranzactie>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append($"ID: {id}, ");
            sb.Append($"Titular: {titular}, ");
            sb.Append($"Sold: {sold}");
            sb.Append("]");
            return sb.ToString();
        }

        public void Retrage(decimal suma)
        {
            Tranzactie tran = new Tranzactie(suma, TranType.Retrage, id, Status.Nedefinit);
            if (suma <= 0)
            {
                tran.Status = Status.Esec;
                tranzactii.Add(tran);
                throw new InvalidAmountException("suma care se retrage trebuie sa fie mai mare ca zero");
            }
            else if (suma > sold)
            {
                tran.Status = Status.Esec;
                tranzactii.Add(tran);
                throw new NotEnoughFundsException("s-a incercat sa se retraga o suma mai mare decat soldul. descoperirea de cont nu este permisa.");
            }
            else
            {
                tran.Status = Status.Succes;
                tranzactii.Add(tran);
                sold -= suma;
            }
        }

        public void PrintExtrasDeCont()
        {
            Console.WriteLine($"Extras de cont din data/ora {DateTime.Now}");
            foreach (var item in tranzactii)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Depunem o suma in cont
        /// </summary>
        /// <param name="suma">suma depusa</param>
        /// <exception cref="InvalidAmountException"></exception>
        public void Depune(decimal suma)
        {
            Tranzactie tran = new Tranzactie(suma, TranType.Depune, id, Status.Nedefinit);
            if (suma <= 0)
            {
                tran.Status = Status.Esec;
                tranzactii.Add(tran);
                throw new InvalidAmountException("suma care se depune trebuie sa fie mai mare ca zero");
            }
            else
            {
                tran.Status = Status.Succes;
                tranzactii.Add(tran);
                sold += suma;
            }
        }
    }
}