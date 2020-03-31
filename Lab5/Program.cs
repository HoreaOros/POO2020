using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContBancar c1 = new ContBancar("John");
            ContBancar c2 = new ContBancar("Jane");

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            try
            {
                c1.Depune(100M);
            }
            catch(InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c1.Depune(200M);
            }
            catch(InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                c1.Retrage(150M);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NotEnoughFundsException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                c1.Retrage(250M);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotEnoughFundsException e)
            {
                Console.WriteLine(e.Message);
            }


            // try to rob the bank
            BankRobber br = new BankRobber("Johnny Villain", c1);
            br.RobBank(100);
            Console.WriteLine(br);


            c1.PrintExtrasDeCont();

        }
    }
}
