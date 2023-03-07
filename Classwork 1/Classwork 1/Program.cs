using System.Diagnostics;

namespace Classwork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------TASK_ONE-------------------------


            Console.WriteLine("Plase write you full name : ");
            string full_name_ = Console.ReadLine();

            Console.WriteLine("Amount (AZN) : ");
            double amount_azn_ = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many currency will be used : ");
            int currencyCount = int.Parse(Console.ReadLine());

            while (currencyCount > 0)
            {
                Console.WriteLine("Please enter the currency : ");
                double currency = double.Parse(Console.ReadLine());
                double aznTo = amount_azn_ / currency;
                Console.WriteLine();
                Console.WriteLine("Result : ");
                Console.WriteLine(aznTo);
                currencyCount--;
            }

            //----------------------------TASK_TWO-------------------------

            Console.WriteLine("Budget : ");
            double budget = double.Parse(Console.ReadLine());
            Console.WriteLine("How many Ministry do you need : ");
            int ministryCount = int.Parse(Console.ReadLine());

            while (ministryCount > 0)
            {

                Console.WriteLine("Please write you ministry : ");
                string ministry = Console.ReadLine();

                Console.WriteLine("What percentage will go : ");
                double percentage = double.Parse(Console.ReadLine());
                double ministryBudget = budget * percentage / 100;

                Console.WriteLine(ministry + " : " + ministryBudget);
                ministryCount--;
                budget = budget - ministryBudget;
            }
            Console.WriteLine("Budget : " + budget);

            //----------------------------TASK_THREE-------------------------

            Console.WriteLine("How many Company do you need : ");
            int companyCount = int.Parse(Console.ReadLine());
            decimal resulttotal = 0;

            while (companyCount > 0)
            {
                Console.Write("Company : ");
                string shoe = Console.ReadLine();

                Console.Write("Number of shoes : ");
                decimal shoeCount = 0;

                while (true)
                {
                    Console.Write("Number of shoes : ");
                    shoeCount = decimal.Parse(Console.ReadLine());

                    if (shoeCount > 0 && shoeCount < 10)
                    {
                        break;
                    }
                }

                decimal shoePrice = 0;

                while (true)
                {
                    Console.WriteLine("Price per one ($) : ");
                    shoePrice = decimal.Parse(Console.ReadLine());

                    if (shoePrice > 50 && shoePrice < 500)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The price should be between 50 and 500!");
                    }
                }

                Console.Write("Total Price ($) : ");
                decimal total = shoeCount * shoePrice;

                Console.WriteLine(shoeCount * shoePrice);

                Console.WriteLine();
                Console.WriteLine();
                companyCount--;
                resulttotal = resulttotal + total;
            }
            Console.WriteLine();
            Console.WriteLine("Price of all together($) : ");
            Console.WriteLine(resulttotal);

            if (companyCount >= 5)
            {
                resulttotal = resulttotal * 15 / 100;
            }
            else if (companyCount >= 10)
            {
                resulttotal = resulttotal * 25 / 100;
            }
        }
    }
}