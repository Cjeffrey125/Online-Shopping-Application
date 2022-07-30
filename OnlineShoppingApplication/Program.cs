
using System;
using System.Collections.Generic;
using CartData;
using CartProcess;


namespace UI

{

    public static class Program
    {


        public static void Main(string[] args)
        {
            TableLayout.Sign();

            bool usingProgram = true;

            while (usingProgram)
            {
                switch (userInterface().ToLower())
                {
                    case "add":
                        TableLayout.CallTable();
                        addingItem();
                        break;

                    case "show":
                        displayItems();

                        break;

                    case "cancel":
                        ClearCart();
                        break;

                    case "remove":
                        GetDataToDelete();
                        break;

                    case "checkout":
                        displayItems();
                        payment();
                        Logics.AmountToPay();
                        DataLayer.SavingFinalOrder();
                        usingProgram = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input!!");
                        break;
                }
            }
        }


        public static string userInterface()
        {
            Console.Clear();
            Console.WriteLine("Welcome to our Online Shopping Application! ");

            Console.WriteLine();
            Console.WriteLine("1. Browse and buy products");
            Console.WriteLine("2. View shopping cart");
            Console.WriteLine("3. Remove all items on your cart");
            Console.WriteLine("4. Checkout all your items");

            Console.WriteLine();
            Console.WriteLine("Type 'add' to check items.");
            Console.WriteLine("Type 'show' to view your cart.");
            Console.WriteLine("Type 'remove' to remove an item.");
            Console.WriteLine("Type 'cancel' to empty your cart.");
            Console.WriteLine("Type 'checkout' to checkout all your items");

            Console.Write("\nWhat would you like to do: ");
            string userResponse = Console.ReadLine();
            return userResponse;
        }
        private static void addingItem()
        {
            Console.WriteLine();
            Console.Write("What item would you like to add? ");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {

                case "apple":
                    Console.Write("How many pieces of apples do you want to buy? ");
                    break;
                case "banana":
                    Console.Write("How many kilos of banana do you want to buy? ");
                    break;
                case "mango":
                    Console.Write("How many kilos of mango do you want to buy? ");
                    break;
                case "ampalaya":
                    Console.Write("How many kilos of ampalaya do you want to buy? ");
                    break;
                case "cabbage":
                    Console.Write("How many kilos of cabbage do you want to buy? ");
                    break;
                case "potato":
                    Console.Write("How many kilos of potato do you want to buy? ");
                    break;
                case "chicken":
                    Console.Write("How many kilos of chicken do you want to buy? ");
                    break;
                case "beef":
                    Console.Write("How many kilos of beef do you want to buy? ");
                    break;
                case "pork":
                    Console.Write("How many kilos of pork do you want to buy? ");
                    break;
                case "potatochips":
                    Console.Write("How many packs of potato chips do you want to buy? ");
                    break;
                case "yogurt":
                    Console.Write("How many pieces of yogurt do you want to buy? ");
                    break;
                case "cheesepuffs":
                    Console.Write("How many packs of cheese puffs do you want to buy? ");
                    break;
                case "water":
                    Console.Write("How many bottles of water do you want to buy? ");
                    break;
                case "milk":
                    Console.Write("How many cartons of milk do you want to buy? ");
                    break;
                case "juice":
                    Console.Write("How many sachets of juice do you want to buy? ");
                    break;
                default:
                    Console.Write("How many do you want to buy? ");
                    break;
            }
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (Logics.itemValidator(userInput) == true)
            {
                Logics.savingItem(userInput, quantity);
            }
            else if (Logics.itemValidator(userInput) == false)
            {
                Console.Clear();
                Console.WriteLine("Sorry for the Inconvenience.\n");
                string notAvail = (userInput + " - This item is currently not available.");
                Console.WriteLine(notAvail);
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
            }
        }

        private static void displayItems()
        {
            Console.Clear();
            Console.WriteLine();

            TotalNumberofItems();

            List<string> dataContent = DataLayer.showItems();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Items\t\tQuantity\tSub-total (PHP)");
            Console.ResetColor();
            foreach (var data in dataContent)
            {
                Console.WriteLine($"{data.ToUpper()}");
            }
            TotalItems();
            Console.WriteLine("\nPress Enter to Continue.");
            Console.ReadLine();

        }

        public static void payment()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Select The Mode of Payment: ");
            Console.WriteLine("1. Cash on Delivery");
            Console.WriteLine("2. Credit Card Payment");
            Console.WriteLine();

            Console.Write("Input the Number of your Choice : ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                userInfo();
                Console.WriteLine("The items will be delivered at the given address");
                Console.ReadLine();
            }
            else if (option == "2")
            {
                Console.Clear();
                List<string> userCredit = new List<string>();
                Console.WriteLine();
                Console.Write("Input Your Credit Card Number: ");
                string credit = Console.ReadLine();
                userCredit.Add("Credit Card: " + credit);
                DataLayer.order(userCredit);
                userInfo();
                Console.WriteLine("The items will be delivered at the given address");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect Input!!");
            }
        }

        public static void userInfo()
        {
            Console.Clear();
            Console.WriteLine();

            List<string> userInfo = new List<string>();
            Console.Write("Enter Your Fullname: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Contact Number: ");
            string contact = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            string address = Console.ReadLine();

            userInfo.Add("Name: " + name);
            userInfo.Add("Contact Number: " + contact);
            userInfo.Add("Address: " + address);
            userInfo.Add("");
            DataLayer.order(userInfo);
        }

        public static void TotalNumberofItems()
        {
            var LineCount = ("Your total cart item(s) is: " + Logics.numberOfItems());
            Console.WriteLine(LineCount);
            Console.WriteLine();
        }

        public static string TotalItems()
        {
            Console.WriteLine();
            string totalAmount = ("The total amount is : " + Logics.ComputingItems());
            Console.WriteLine(totalAmount);

            return totalAmount;
        }

        public static void ClearCart()
        {
            DataLayer.RemoveCarts();
            Console.Clear();
            Console.WriteLine("Your cart has been emptied");
            Console.Write("Press Enter to continue ");
            Console.ReadLine();
        }

        private static void GetDataToDelete()
        {
            Console.Clear();
            
            displayItems();
            Console.Write("Enter the Item to be removed: ");
            string dataTobeDeleted = Console.ReadLine();

            if (DataLayer.DeleteDataInFile(dataTobeDeleted))
            {
                Console.Clear();
                Console.WriteLine($"Successfully deleted {dataTobeDeleted} from the cart.");
                Console.Write("Press Enter to continue ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error deleting data from file. Either data or the file is not existing.");
            }
        }
    }
}



