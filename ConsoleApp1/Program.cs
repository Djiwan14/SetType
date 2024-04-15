using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Implement the set type which contains integers. Represent the set as a sequence of its
            elements.Implement as methods: 
            1. inserting an element,
            2. removing an element, 
            3. returning whether the set is empty, 
            4. returning whether the set contains an element, 
            5. returning a random element without removing it from the set, 
            6. returning the sum of the numbers in the set(suggestion: store the sum and update it when the set changes), 
            7. printing the set.    
            
            A set can store every element only once*/
            string input = "";
            Set numbers = new Set();
            do
            {
                Display();
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please enter value: ");
                        string member = Console.ReadLine();
                        bool success = int.TryParse(member, out int value);
                        if (success)
                        {
                            numbers.Add(value);
                            numbers.Write();
                        }
                        else
                        {
                            notInt();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Please enter value: ");
                        member = Console.ReadLine();
                        success = int.TryParse(member, out value);
                        if (success)
                        {
                            numbers.Delete(value);
                            numbers.Write();
                        }
                        else
                        {
                            notInt();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Is the set empty? {0}", numbers.CheckIsEmpty());
                        break;
                    case "4":
                        Console.WriteLine("Please enter value: ");
                        member = Console.ReadLine();
                        success = int.TryParse(member, out value);
                        if (success)
                        {
                            numbers.CheckIfIn(value);
                            Console.WriteLine("Is the number {0} in our set? {1}", value, numbers.CheckIfIn(value));
                            numbers.Write();
                        }
                        else
                        {
                            notInt();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Random number from our set is {0}", numbers.GetRandomNumber());
                        break;
                    case "6":
                        Console.WriteLine("Sum of all elements in the set is equal to : {0}", numbers.GetSum());
                        break;
                    case "7":
                        numbers.Write();
                        break;
                    default:
                        Console.WriteLine("You entered invalid number");
                        break;
                }
                
            } while (!input.Equals("0")) ;
        }
        public static void Display()
        {
            Console.WriteLine("Hello User! You have the possibility to interact with the set.");
            Console.WriteLine("1. Please enter 1 to insert an element into it");
            Console.WriteLine("2. Please enter 2 to remove an element from it.");
            Console.WriteLine("3. Please enter 3 to see if the element is empty.");
            Console.WriteLine("4. Please enter 4 to see if the set contains an element.");
            Console.WriteLine("5. Please enter 5 to get the random element from it without removing it from the set.");
            Console.WriteLine("6. Please enter 6 to get the sum of all elements of a set.");
            Console.WriteLine("7. Please enter 7 to print the set");
            Console.WriteLine("0. Please enter 0 to quit the program.");
            Console.WriteLine("Please enter the operation's number: ");
        }
        public static void notInt()
        {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input is not number, please try again!");
                Console.ForegroundColor = ConsoleColor.White;
        }
}
}