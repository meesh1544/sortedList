using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace sortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int>ages = new SortedList<string, int>();
            ages.Add("Betsy", 12);
            ages.Add("Hazel", 6);
            ages.Add("Josie", 3);
            ages.Add("Hudson", 10);
            ages.Add("Jaxson", 11);

            Console.WriteLine("The sorted list contains:");
            foreach (KeyValuePair<string, int> ag in ages)
            {
                Console.WriteLine($"Key: = {ag.Key} Value: = {ag.Value}");
            }
            Console.WriteLine("What name would you like to delete?");
            string name = Console.ReadLine();
            ages.Remove(name);
            Console.WriteLine("What age would you like to delete?");
            string age = Console.ReadLine();
            ages.Remove(age);
            if (ages.ContainsKey(name))
                Console.WriteLine($"{name} is on the list");
            else
                if (ages.ContainsKey(age))
            {
                Console.WriteLine($"You can only enter one of the {age} ages");
            }
            else
            {
                ages.Remove(name);
                ages.Remove(age);
                Console.WriteLine($"{name} {age} have been removed");
            }
            Console.WriteLine("The new name and ages in the list are: ");
            foreach (KeyValuePair <string, int> ag in ages)
            {
                Console.WriteLine($"Key: = {ag.Key} Value: = {ag.Value}");
            }
        }
    }
}
