using System;
using System.Text;

namespace Assignment_3._1_Question_1
{
    public class Program
    {
        public static string MakeNumbers()
        {

            /*
            Write a method that returns a string of even numbers greater 
            than 0 and les than 100 using StringBuilder class
            */

            //modulus? - nah
            //static StringBuilder (int capacity, int maxCapacity);
            //StringBuilder thing per example
            StringBuilder alltheevenNumbers = new ();

            //Make loop for numbers 0-100
            for (int i = 2; i < 100; i+= 2) 
                //kept having issues with calling off the same variable
                //apparently had another tab open calling Main() causing conflict
            {
            //Make spaces btw #;s
            alltheevenNumbers.Append(i).Append(" ");            
            }

            //make string instead of int
            return alltheevenNumbers.ToString();
        }

        public static void Main()
        //print 
        {
        Console.WriteLine("Check out all these even numbers!");
        Console.WriteLine("");
        //How to wrap text?
        string result = MakeNumbers();
        Console.WriteLine(result);
        }
        
    }
}
