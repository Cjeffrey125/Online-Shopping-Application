using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartProcess;

namespace UI
{
    public class TableLayout
    {

        public static void Sign()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t\t\t   ***      **      **  **     ******    **      **   ******");
            Console.WriteLine("\t\t\t\t **   **    ****    **  **	 **      ****    **   **");
            Console.WriteLine("\t\t\t\t**     **   **  **  **  **	 **      **  **  **   ****");
            Console.WriteLine("\t\t\t\t **   **    **    ****  **	 **      **    ****   **");
            Console.WriteLine("\t\t\t\t   ***	    **      **  *****  ******    **      **   ******");
            Console.WriteLine();

            Console.WriteLine("\t\t\t ****    **   **     ***     ******   ******   ******  **      **      *****");
            Console.WriteLine("\t\t\t**   **  **   **   **   **   **   *   **    *    **    ****    **    **    ");
            Console.WriteLine("\t\t\t  ***    *******  **     **  ******   ******     **    **  **  **   **    ***");
            Console.WriteLine("\t\t\t**   **  **   **   **   **   **       **         **    **    ****    **    **");
            Console.WriteLine("\t\t\t ****    **   **     ***     **       **       ******  **      **      *****");
            Console.WriteLine();

            Console.WriteLine("\t\t   ***    ******  ****** **     ******   ******      ***    ******  ******    *****     **     **");
            Console.WriteLine("\t\t **   **  **   *  **   * **       **    **         **   **    **      **    **     **   ****   **");
            Console.WriteLine("\t\t** * * ** ******  ****** **       **    **        ** * * **   **      **    **     **   **  ** **");
            Console.WriteLine("\t\t**     ** **      **     ****** ******   ******  **       **  **    ******    *****     **    ***");


            Console.WriteLine("\n\t\t\t\t\t           Press Enter Key To Continue!!");
            Console.ReadLine();
        }

        public static void CallTable()
        {


            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Select items from below: ");
            Console.WriteLine();

            Console.WriteLine(Layouts.PrintRow);
            PrintLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Layouts.PrintRow("Fruits", "Price");
            Console.ResetColor();
            PrintLine();
            Layouts.PrintRow("Apple", "15 PHP per piece");
            Layouts.PrintRow("Banana", "55 PHP per kilo");
            Layouts.PrintRow("Mango", "155 PHP per kilo");
            PrintLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Layouts.PrintRow("Vegetables", "Price");
            Console.ResetColor();
            PrintLine();
            Layouts.PrintRow("Ampalaya", "60 PHP per piece");
            Layouts.PrintRow("Cabbage", "55 PHP per kilo");
            Layouts.PrintRow("Potato", "50 PHP per kilo");
            PrintLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Layouts.PrintRow("Meat", "Price");
            Console.ResetColor();
            PrintLine();
            Layouts.PrintRow("Chicken", "200 PHP per piece");
            Layouts.PrintRow("Beef", "400 PHP per kilo");
            Layouts.PrintRow("Pork", "350 PHP per kilo");
            PrintLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Layouts.PrintRow("Snacks", "Price");
            Console.ResetColor();
            PrintLine();
            Layouts.PrintRow("Potato Chips", "50 PHP per pack");
            Layouts.PrintRow("Yogurt", "80 PHP per piece");
            Layouts.PrintRow("Cheese Puffs", "30 PHP per pack");
            PrintLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Layouts.PrintRow("Beverages", "Price");
            Console.ResetColor();
            PrintLine();
            Layouts.PrintRow("Water", "20 PHP per bottle");
            Layouts.PrintRow("Milk", "85 PHP per carton");
            Layouts.PrintRow("Juice", "30 PHP per sachet");
            PrintLine();
        }

        public static void PrintLine()
        {
            Console.WriteLine(new string('-', Layouts.tableWidth));
        }

    }
}
