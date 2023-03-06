using System.Diagnostics;

namespace Classwork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------TASK_ONE-------------------------

            Console.WriteLine("Amount (AZN) : ");
            double amount_azn_ = Int32.Parse(Console.ReadLine());


            if (amount_azn_ >= 25000)
            {
                Console.WriteLine("There are not that many funds in the bank");
            }
            else
            {

                if (amount_azn_ >= 1000)
                {
                    Console.WriteLine("Plase write you full name : ");
                    string full_name_ = Console.ReadLine();


                    double currencydollar = 1.70;
                    double currencyeur = 1.81;
                    double currencyrub = 0.023;



                    double azn_to_usd_ = amount_azn_ / currencydollar;
                    double azn_to_eur_ = amount_azn_ / currencyeur;
                    double azn_to_rub_ = amount_azn_ / currencyrub;


                    Console.WriteLine("United States Dollar(USD) : ");
                    Console.WriteLine(azn_to_usd_);

                    Console.WriteLine("Euro (EUR) : ");
                    Console.WriteLine(azn_to_eur_);

                    Console.WriteLine("Russian ruble (RUB) : ");
                    Console.WriteLine(azn_to_rub_);
                }
                else
                {
                    Console.WriteLine("Sorry we can not translate that.");
                }

            }


            //----------------------------TASK_TWO-------------------------

            Console.WriteLine("Budget : ");
            double budget = Int64.Parse(Console.ReadLine());

            double to_ministry_of_defense_ = budget * 20 / 100;
            double to_minisrty_of_high_technologies_ = budget * 10 / 100;
            double remaining_budget_ = budget - to_ministry_of_defense_ - to_minisrty_of_high_technologies_;

            Console.WriteLine("To the Ministry of Defense : ");
            Console.WriteLine(to_ministry_of_defense_);

            Console.WriteLine("To the Ministry of High Technologies : ");
            Console.WriteLine(to_minisrty_of_high_technologies_);

            Console.WriteLine("Remaining budget : ");
            Console.WriteLine(remaining_budget_);

            //----------------------------TASK_THREE-------------------------

            Console.Write("Company : ");
            string first_shoe_ = Console.ReadLine();
            Console.Write("Number of shoes : ");
            int first_shoe_count_ = Int32.Parse(Console.ReadLine());
            Console.Write("Price per one ($) : ");
            double first_shoe_price_ = Int32.Parse(Console.ReadLine());
            Console.Write("Price of all together($) :");
            double first_total_ = first_shoe_count_ * first_shoe_price_;
            Console.WriteLine(first_total_);


            Console.Write("Company : ");
            string second_shoe_ = Console.ReadLine();
            Console.Write("Number of shoes : ");
            int second_shoe_count_ = Int32.Parse(Console.ReadLine());
            Console.Write("Price per one ($) : ");
            double second_shoe_price_ = Int32.Parse(Console.ReadLine());
            Console.Write("Price of all together($) :");
            double second_total_ = second_shoe_count_ * second_shoe_price_;
            Console.WriteLine(second_total_);


            Console.Write("Company : ");
            string third_shoe_ = Console.ReadLine();
            Console.Write("Number of shoes : ");
            int third_shoe_count_ = Int32.Parse(Console.ReadLine());
            Console.Write("Price per one ($) : ");
            double third_shoe_price_ = Int32.Parse(Console.ReadLine());
            Console.Write("Price of all together($) :");
            double third_total_ = third_shoe_count_ * third_shoe_price_;
            Console.WriteLine(third_total_);
        }
    }
}