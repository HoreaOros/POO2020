using System;

namespace Lab5
{
    internal class BankRobber
    {
        private string robber;
        private ContBancar cont;
        decimal loot = 0;

        public BankRobber(string v, ContBancar cont)
        {
            this.robber = v;
            this.cont = cont;
        }

        public void RobBank(decimal suma)
        {
            if (suma <= cont.sold)
            {
                loot += suma;
                cont.sold -= suma; // e posibil doar daca sold este public sau internal in ContBancar
            } 
        }
        public override string ToString()
        {
            return $"{robber}, loot = {loot}";
        }
    }
}