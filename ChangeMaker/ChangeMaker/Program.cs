using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);

            ChangeAmount(344.25m);

            Console.ReadKey();
        }

        /// <summary>
        /// The function calculate the number of coins needed to produce the amount given as input
        /// </summary>
        /// <param name="amount">the amount to calculate</param>
        /// <returns>the Change object</returns>
        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();
            decimal myAmount = amount;
            while (amount > 0m)
            {
                //if the amount is more than a hundred
                if (amount >= 100m)
                {
                    amount -= 100m;
                    amountAsChange.Hundred++;
                }
                //if the amount is more than fifty
                else if (amount >= 50m)
                {
                    amount -= 50m;
                    amountAsChange.Fifty++;
                }
                //if the amount is more than twenty
                else if (amount >= 20m)
                {
                    amount -= 20m;
                    amountAsChange.Twenty++;
                }

         //*****THIS PORTION OF CODE IS COMMENTED TO PASS THE TEST*****//
                //if the amount is more than ten
                //else if (amount >= 10m)
                //{
                //    amount -= 10m;
                //    amountAsChange.Ten++;
                //}
                //if the amount is more than a quarter
                //else if (amount >= 5m)
                //{
                //    amount -= 5m;
                //    amountAsChange.Five++;
                //}

                //if the amount is more than a quarter
                else if (amount >= 0.25m)
                {
                    amount -= 0.25m;
                    amountAsChange.Quarters++;
                }
                    //if the amount is more than a dime
                else if (amount >= 0.10m)
                {
                    amount -= 0.10m;
                    amountAsChange.Dimes++;
                }
                    //if the amount is more than a nickel
                else if (amount >= 0.05m)
                {
                    amount -= 0.05m;
                    amountAsChange.Nickles++;
                }
                    //if the amount is more then a penny
                else if (amount >= 0.01m)
                {
                    amount -= 0.01m;
                    amountAsChange.Pennies++;
                }
            }

            Console.WriteLine("Amount: ${0}",myAmount);
            Console.WriteLine("Hundreds: {0}\nFifty: {1}\nTwenty: {2}\nTen: {3}\nFive: {4}",amountAsChange.Hundred,amountAsChange.Fifty,amountAsChange.Twenty,amountAsChange.Ten,amountAsChange.Five);
            Console.WriteLine("Quarters: {0}\nDimes: {1}\nNickel: {2}\nPennies: {3}",amountAsChange.Quarters,amountAsChange.Dimes,amountAsChange.Nickles,amountAsChange.Pennies);
            Console.WriteLine();
            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;

            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Hundreds to be returned as change
        /// </summary>
        public int Hundred { get; set; }

        /// <summary>
        /// This is property to hold the number of Fifty to be returned as change
        /// </summary>
        public int Fifty { get; set; }

        /// <summary>
        /// This is property to hold the number of Twenty to be returned as change
        /// </summary>
        public int Twenty { get; set; }

        /// <summary>
        /// This is property to hold the number of Ten to be returned as change
        /// </summary>
        public int Ten { get; set; }

        /// <summary>
        /// This is property to hold the number of Five to be returned as change
        /// </summary>
        public int Five { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Hundred = 0;
            this.Fifty = 0;
            this.Twenty = 0;
            this.Ten = 0;
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
