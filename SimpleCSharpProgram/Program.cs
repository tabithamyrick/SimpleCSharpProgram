using System;
using System.Collections.Generic;

namespace SimpleCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates new List of Drink Objects to Enumurate with the foreach loop
            List<Drink> DrinkList = new List<Drink>();

            //Instantiates the new Objects with params passed for property setting
            Juice juice = new Juice("Orange", false);
            Soda soda = new Soda("Pepsi", true);
            Beer beer = new Beer("Budwiser", true, 0.05);

            //adds the new Drink objects to the enumerable list
            DrinkList.Add(juice);
            DrinkList.Add(beer);
            DrinkList.Add(soda);


            //prints each drink object details selected from the DrinkList List
            foreach (Drink drink in DrinkList)
            {
                Console.Write(drink.Name + ", " + drink.Description + ". ");
            }
        }
    }
}
