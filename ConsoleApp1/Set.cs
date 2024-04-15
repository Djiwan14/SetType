using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Set
    {
        private List<int> numbers = new List<int>();
        private int sum;
        public Set()
        {

        }

        // inserting an element
        public void Add(int number)
        {
            if (!(numbers.Contains(number)))
            {
                this.sum += number;
                numbers.Add(number);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number is already in the set!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // removing an element
        public void Delete(int number)
        {
            if (numbers.Contains(number))
            {
                numbers.Remove(number);
                this.sum -= number;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No such number in the set!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        //checking whether the set is empty
        public bool CheckIsEmpty()
        {
            if (numbers.Count == 0){
                return true;
            }
            else{
                return false;
            }
        }
        // checking if the set contains particular element
        public bool CheckIfIn(int number)
        {
            if (numbers.Contains(number)) return true;
            else return false;
        }
        // returning random number from the set
        public int GetRandomNumber() {
            try
            {
                var random = new Random();
                int index = random.Next(numbers.Count);
                return numbers[index];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return 0;
            }
        }
        // getting sum of the elements of set
        public int GetSum()
        {
            return this.sum;
        }
        public void Write()
        {
            Console.WriteLine("Values of the set : ");
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n");
        }
    }
}
