using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Coffee
    {
        public enum CoffeeSize : byte
        {
            small = 1, medium = 3, large = 5
        }
        public static void Start()
        {
            try
            {
                CoffeeSize small = CoffeeSize.small;
                CoffeeSize medium = CoffeeSize.medium;
                CoffeeSize large = CoffeeSize.large;
                
                
                //Declaring all of my variables
                double emp1total; double emp2total; double emp3total; double emp4total; double emp5total;

                double emp1ot = 0; double emp2ot = 0; double emp3ot = 0; double emp4ot = 0; double emp5ot = 0;

                double emp1totalbeforeot = 0; double emp2totalbeforeot = 0; double emp3totalbeforeot = 0; double emp4totalbeforeot = 0; double emp5totalbeforeot = 0;

                //Ask for input
                Console.WriteLine("1. Press 1 to calculate sales");
                Console.WriteLine();
                Console.WriteLine("2. Press 2 to calculate payroll");
                Console.WriteLine();
                Console.WriteLine("3. Press 3 to close application");

                //Convert Input to int Answer
                int answer = Convert.ToInt32(Console.ReadLine());

                //If answer = 1 then ask for Coffee/Sandwiches
                if (answer == 1)
                {

                    Console.WriteLine("Enter the number of small coffes sold");
                    Int64 Small = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the number of medium coffes sold");
                    Int64 Medium = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the number of large coffes sold");
                    Int64 Large = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the number of Egg sandwiches sold");
                    Int64 Egg = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the number of Chicken sandwiches sold");
                    Int64 Chicken = Convert.ToInt64(Console.ReadLine());

                    //Declare Totals
                    double smalltotal = Small * (int)small;
                    double mediumtotal = Medium * (int)medium;
                    double largetotal = Large * (int)large;
                    double chickentotal = Chicken * 7.50;
                    double eggtotal = Egg * 5.50;

                    double smallcost = Small * .10;
                    double mediumcost = Medium * .15;
                    double largecost = Large * .20;
                    double chickencost = Chicken * 1.20;
                    double eggcost = Egg * .95;

                    //declare profit / costs / and sales
                    double totalsales = Add(smalltotal, mediumtotal, largetotal, eggtotal, chickentotal);
                    double totalcost = Add(smallcost, mediumcost, largecost, eggcost, chickencost);
                    double profit = totalsales - totalcost;
                    Console.WriteLine("The total Sales amount is $" + totalsales);
                    Console.WriteLine("The total costs is $" + totalcost);
                    Console.WriteLine("The total profit is $" + profit);

                    Console.ReadLine();
                    //return to start
                    Console.Clear();
                    Start();

                }

                // If answer is 2 then ask for every employees hours
                if (answer == 2)
                {

                    Console.WriteLine("Enter Employee 1 total hours");
                    double emp1hrs = Convert.ToDouble(Console.ReadLine());

                    //if less than 40 hrs
                    if (emp1hrs <= 40)
                    {
                        emp1totalbeforeot = emp1hrs * 12.50;
                    }
                    //if over 40 hrs / calulate OT
                    else if (emp1hrs > 40)
                    {
                        emp1ot = (emp1hrs - 40) * 18.75;
                        emp1totalbeforeot = 40 * 12.50;
                        emp1total = 40 * 12.50 + emp1ot;
                    }


                    Console.WriteLine("Enter Employee 2 total hours");
                    double emp2hrs = Convert.ToDouble(Console.ReadLine());

                    if (emp2hrs <= 40)
                    {
                        emp2totalbeforeot = emp2hrs * 12.50;
                    }

                    else if (emp2hrs > 40)
                    {
                        emp2ot = (emp2hrs - 40) * 18.75;
                        emp2totalbeforeot = 40 * 12.50;
                        emp2total = 40 * 12.50 + emp2ot;
                    }

                    Console.WriteLine("Enter Employee 3 total hours");
                    double emp3hrs = Convert.ToDouble(Console.ReadLine());

                    if (emp3hrs <= 40)
                    {
                        emp3totalbeforeot = emp3hrs * 12.50;
                    }

                    else if (emp3hrs > 40)
                    {
                        emp3ot = (emp3hrs - 40) * 18.75;
                        emp3totalbeforeot = 40 * 12.50;
                        emp3total = 40 * 12.50 + emp3ot;

                    }

                    Console.WriteLine("Enter Employee 4 total hours");
                    double emp4hrs = Convert.ToDouble(Console.ReadLine());

                    if (emp4hrs <= 40)
                    {
                        emp4totalbeforeot = emp4hrs * 12.50;
                    }

                    else if (emp4hrs > 40)
                    {
                        emp4ot = (emp4hrs - 40) * 18.75;
                        emp4totalbeforeot = 40 * 12.50;
                        emp4total = 40 * 12.50 + emp4ot;

                    }
                    Console.WriteLine("Enter Employee 5 total hours");
                    double emp5hrs = Convert.ToDouble(Console.ReadLine());

                    if (emp5hrs <= 40)
                    {
                        emp5totalbeforeot = emp5hrs * 12.50;
                    }

                    else if (emp5hrs > 40)
                    {
                        emp5ot = (emp5hrs - 40) * 18.75;
                        emp5totalbeforeot = 40 * 12.50;
                        emp5total = 40 * 12.50 + emp5ot;
                    }
                    // Calculate total OT / Standard pay / Total pay
                    double overtime = Add(emp1ot, emp2ot, emp3ot, emp4ot, emp5ot);
                    double basepay = Add(emp1totalbeforeot, emp2totalbeforeot, emp3totalbeforeot, emp4totalbeforeot, emp5totalbeforeot);
                    double total = overtime + basepay;
                    Console.WriteLine("Your standard pay roll is $" + basepay);
                    Console.WriteLine("Your overtime payroll is $" + overtime);
                    Console.WriteLine("Your total payroll is $" + total);
                    Console.ReadLine();
                    Console.Clear();
                    Start();

                }

                //if input is 3 then exit app
                if (answer == 3)
                {
                    Console.WriteLine("Thanks for stopping by!!!");
                    Console.ReadLine();
                }

                if (answer > 3)
                {
                    Console.WriteLine("Enter 1, 2, or 3!");
                    Console.WriteLine();
                    Start();

                }
            }

            //Exception handling
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.Clear();
                Start();
            }
        }

        //addition method
        public static double Add(double item1, double item2, double item3, double item4, double item5)
        {
            return item1 + item2 + item3 + item4 + item5;
        }
    }
}
    

