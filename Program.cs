
using System;
using System.Collections.Generic;

namespace convenience_store
{
    class program
    
    {
        static void Main(string[] args)
        {
          /*
            int day = 4;
            switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
      }    */
            
            //instantiate random object
            Random random;
            random = new Random();

            //your money
            int wallet = random.Next(1, 15) + 4;

            //items to buy
            List<string> menu = new List<string> { "food - $3", "soda - $1", "beer - $2", "cigs - $5\n " };


            
            Console.WriteLine("walk into store \n reset game");     
          string day = Console.ReadLine();
            switch (day) 
      {
        case "reset game":
          Console.WriteLine("Monday"); //new game
          break;
        case "walk into store":
          Console.WriteLine("Tuesday"); //walk in
          Console.WriteLine("welcome to corner store 8!");
            Console.WriteLine("\ntoday you have " + wallet + " dollars \nplease type item you would like to buy from the list \n ");
           foreach (string item in menu)

            {
                Console.WriteLine(item);
            }
          //break;
      }
            //display menu
            /*foreach (string item in menu)

            {
                Console.WriteLine(item);
            }*/


            while (wallet > 0)
            //item user choice
            {
                
                string s = Console.ReadLine();

                if (s == "food")
                {
                    wallet -= 3;
                    Console.WriteLine("you bought food for 3 dollars \nyou have " + wallet + " dollars left\n ");
                }
                else if (s == "soda")
                {
                    wallet -= 1;
                    Console.WriteLine("you bought soda for 1 dollar \nyou have " + wallet + " dollars left\n ");
                }
                else if (s == "beer")
                {
                    wallet -= 2;
                    Console.WriteLine("you bought beer for 2 dollars \nyou have " + wallet + " dollars left\n ");
                }
                else if (s == "cigs")
                {
                    wallet -= 5;
                    Console.WriteLine("you bought cigs for 5 dollars \nyou have " + wallet + " dollars left\n ");
                }
                else
                {
                    Console.WriteLine("thanks for you business!");
                    break;
                }
            }
                         
           

            Console.WriteLine("goodbye!"); 
            Console.ReadKey();
        }
        
    }
    
}
