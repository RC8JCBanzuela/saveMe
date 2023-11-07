using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace biddingSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey do you want to sell something on the auction y/n? : ");
            string choices = Console.ReadLine();

            if (choices == "y" || choices == "Y")
            {
                Console.WriteLine("Great! please enter the information needed.");

                Console.Write("Name: ");
                string newSeller = Console.ReadLine();

                Console.Write("Item: ");
                string nameOfItem = Console.ReadLine();

                Console.Write("Price: ");
                int priceOfItem = Convert.ToInt32(Console.ReadLine());

                Seller seller = new Seller(newSeller, priceOfItem, nameOfItem);

                //This is where the seller will have the role
            UserStart:
                Console.Write("Nice the item that you've put is listed on the auction is there any buyer that are interested to buy y/n?: ");
                string userChoices = Console.ReadLine();

                if (userChoices == "y" || userChoices == "Y")
                {

                    //Information of the Seller1 is displayed
                    Console.WriteLine("This is the product of " + newSeller + " and enter the needed information to start the auction.");
                    Console.Write("Item: " + nameOfItem + "\n" + " Price: " + priceOfItem + "\n" + "Owner: " + newSeller + "\n");

                    //First bidder(if effective)
                    Console.Write("Name: ");
                    string nameOfUser = Console.ReadLine();

                    Console.Write("Bid: ");
                    int budgetBid = Convert.ToInt32(Console.ReadLine());

                    User user = new User(nameOfUser, budgetBid);

                    if (budgetBid > priceOfItem)
                    {
                        Console.WriteLine("The highest bid as of today is " + nameOfUser + " Bid: " + budgetBid);

                        //If a new buyer has a higher offer
                        Console.Write("Is there any higher offer y/n?: ");
                        string choices3 = Console.ReadLine();

                        if (choices3 == "y" || choices3 == "Y")
                        {
                            goto BiddingStation;
                        }
                        else
                        {
                            Console.WriteLine("Congratulations to the highest bidder!");
                            Console.WriteLine("The admin will end the auction system");
                            goto Admin;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid input!");
                    }

                BiddingStation:
                    Console.Write("Name: ");
                    string nameUserTwo = Console.ReadLine();

                    Console.Write("Bid: ");
                    int budgetbidTwo = Convert.ToInt32(Console.ReadLine());

                    User user2 = new User(nameUserTwo, budgetbidTwo);

                    if (budgetbidTwo > budgetBid)
                    {
                        Console.WriteLine("The highest bid as of today is " + nameUserTwo);
                    }
                    else if (budgetbidTwo < budgetBid)
                    {
                        Console.WriteLine(nameOfUser + " is still the highest");
                    }
                    else
                    {
                        Console.WriteLine("enter a valid input");
                    }

                //Admin 
                Admin:

                    Console.Write("Name: ");
                    string AdminName = Console.ReadLine();

                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    if (AdminName == "admin" && password == "adminPass")
                    {
                        Environment.Exit(0);
                    }
                }

                //If the buyer change his or her mind
                else if (userChoices == "n" || userChoices == "N")
                {
                    Console.Write("Are you sure? press 1 for yes: ");
                    int userChoice = Convert.ToInt32(Console.ReadLine());

                    if (userChoice == 1)
                    {
                        goto UserStart;
                    }
                }
                else Console.WriteLine("Invalid input!");

            }
            else if (choices == "n" || choices == "N")
            {
                Console.WriteLine("Ok you can tap any key to close the program");
            }
            else Console.WriteLine("Invalid input!");

            Console.ReadKey();
        }
    }
}
