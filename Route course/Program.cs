using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace Route_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            ////1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question2
            ////2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0. 
            //int[,] shelfCopies = {
            //{ 3, 5 },
            //{ 1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question3
            ////3-Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main
            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}
            //PrintWelcomeMessage();
            #endregion

            #region Question4
            ////4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code"
            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question5
            ////5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why? 
            //static void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            #endregion

            #region Question6
            ////6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?
            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //}
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            #endregion

            #region Question7
            //7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5
            //static void AddBonusPagesByRef(ref int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            #endregion

            #region Question8
            ////8-Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward.
            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Question9
            //9-Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it 1 and print the price if found
            static bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }

                price = 0;
                return false;
            }
            if (TryGetPrice("Clean Code", out double bookPrice))
            {
                Console.WriteLine($"Price found: {bookPrice}"); // Output: Price found: 25.5
            }
            #endregion
        }
    }
}
     
