using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stuName = { "Ashwin Oliver", "Cassie Newton", "Shawnie Salter", "Stephen Bolton", "Ralphy Loyd", "Jodi Cain", "Sumayyah Dalby", "Nabeela Houghton", "Aanya Schmitt", "Ivan Holt" };
            string[] stuHome = { "Mesa,Arizona", "Troy,Michigan", "New Orleans,Louisiana", "Flint,Michigan", "Washington,District of Colombia", "Roseville, Michigan", "Fresno, California", "Dallas, Texas", "Ann Arbor,Michigan", "Charlotte, North Carolina" };
            string[] stuFood = { "Apple Pie", "Apple Crumble", "Macoroni and Cheese", "Chicken", "Fried Shrimp", "Chili Con Carne", "Pizza", "Steak", "Tacos", "Kiwi" };
            string[] stuAge = { "19","23","21","28","25","24","30","20","28","29"};
            Console.WriteLine("Welcome to the class.");
            bool rep = true;
            while (rep)
            {
                int choice = GetNumChoice(stuName);
                PrintInfo(choice, stuName, stuHome, stuFood, stuAge);
                rep = GetYesNo("Would you like to ask about another student?");
                
            }
            Console.WriteLine("Have a good day  then.(Press any key to exit)");
            Console.ReadKey(true);
            

        }
        public static int GetNumChoice(string[] Name)
        {
            Console.WriteLine("What Student would you like to learn about?(Name or number 1-10)");
            string choice = Console.ReadLine();
            int result;
            bool isValid = int.TryParse(choice, out result);
            if (isValid && result > 0 && result < 11)
            {
                return result - 1;
            }
            else
            {

                for (int i = 0; i < 10; i++)
                {
                    if (Name[i] == choice)
                    {
                        return i;
                    }
                }
                Console.WriteLine("Sorry I didn't get that!");
                return GetNumChoice(Name);
            }
        }
        public static void PrintInfo(int i, string[] Name, string[] Home, string[] Food, string[] Age)
        {
            // provides name age, the hometown and/or fav food
            Console.WriteLine($"{Name[i]}, is {Age[i]} years old.");
            bool choice = GetChoice("Would you like to know their hometown or favorite food?");
            if (choice)
            { Console.WriteLine($"{Name[i]} is from {Home[i]}."); }
            else
            { Console.WriteLine($"{Name[i]} favorite food is {Food[i]}"); }
            bool rep = GetYesNo("Would you like more info?");
            if (rep)
            {
                if (!choice)
                { Console.WriteLine($"{Name[i]} is from {Home[i]}."); }
                else
                { Console.WriteLine($"{Name[i]} favorite food is {Food[i]}"); }
            }
        }
        public static bool GetYesNo(string message)
        {
            Console.WriteLine($"{message}(Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                return true;
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                return false;
            }
            else
            {
                return GetYesNo("Not Valid");
            }
        }
        public static bool GetChoice(string message)
        {
            Console.WriteLine($"{message}(A/B)");
            if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                return true;
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.B)
            {
                return false;
            }
            else
            {
                return GetYesNo("Not Valid");
            }
        }
    }
}
