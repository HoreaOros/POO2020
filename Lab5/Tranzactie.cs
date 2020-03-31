using System;
namespace Lab5
{
    public enum TranType
    {
        Depune,
        Retrage,
        Nedefinit
    }
    public enum Status
    {
        Succes,
        Esec, 
        Nedefinit
    }
        
    public class Tranzactie
    {
        private decimal suma;
        private DateTime data;
        private TranType tip;
        private int id;
        private Status status;

        public Tranzactie(decimal suma, TranType tip, int id, Status status)
        {
            this.suma = suma;
            data = DateTime.Now;
            this.tip = tip;
            this.id = id;
            this.status = status;
        }

        public Status Status 
        { 
            get 
            { 
                return status; 
            }
            set
            {
                status = value;
            }
        }
        public override string ToString()
        {
            return $"[ID: {id}, Data: {data}, Suma: {suma}, {tip.ToString().ToUpper()}, {status.ToString().ToUpper()}]";
        }
    }
}