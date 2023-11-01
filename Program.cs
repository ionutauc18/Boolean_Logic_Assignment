using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // this line below will print "Car Insurance Application"
            Console.WriteLine("Car Insurance Application");
            // this line below will ask the user the question "What is your age?"
            Console.WriteLine("What is your age?");
            // this line below lets the user ask the question above by typing his age
            int age = Convert.ToInt32(Console.ReadLine());
            // this line below will ask the user the question "Have you ever had a DUI?" and makes the user to type "Yes" or "No"
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            // this line below lets the user ask the question by typing "Yes" or "No" even if it is writen with an uppercase letter or no 
            string hadDUI = Console.ReadLine().ToLower();
            // this line below makes the program compare the users answer and if it is anything then "yes" will not qualify him for a car insurance
            bool dui = hadDUI == "yes";
            // this line below will ask the user the question "How many speeding tickets do you have?"
            Console.WriteLine("How many speeding tickets do you have?");
            // this line below lets the user ask the question above by typing how many speeding tickets he has
            int haveTickets = Convert.ToInt32(Console.ReadLine());
            // this line below prints the question "Qualified?"
            Console.WriteLine("Qualified?");
            // this line below makes a boolean logic comparison between the users answers and the rules the program has to qualify the user
            bool qualified = (age > 15 && !dui && (haveTickets <= 3));
            // this line below will print the decision of the program with "True" or "False" for qualifying for a car insurance by comparing the users answers and the rules the program has
            Console.WriteLine(qualified);
            // this line will let the user see the Command Line program open so he can read the questions and answer them
            Console.ReadLine();
             
        }
    }
}
