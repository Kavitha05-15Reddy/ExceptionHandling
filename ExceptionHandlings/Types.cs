using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    public class Types
    {
        public void Div()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Division of two numbers:" + (num1 / num2));
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occured:" + e.Message);
            }
            finally
            {
                Console.WriteLine("Sum of two numbers:" + (num1 + num2));
            }
        }
        //Write a C# program that prompts the user to input two numbers and divides them.
        //Handle an exception when the user enters non-numeric values.
        public void Exceptions()
        {
            double num1, num2;
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            try
            {
                num1 = double.Parse(input1);
                num2 = double.Parse(input2);

                if (num2 == 0)
                {
                    throw new Exception("Division by zero error.");
                }
                Console.WriteLine("Divsion of two numbers:" + (num1 / num2));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Write a C# program to implement a method that takes an integer as input and 
        //throws an exception if the number is negative. Handle the exception in the calling code.
        public void Negative()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num < 0)
                {
                    throw new Exception("Negative numbers are not allowed");
                }
                Console.WriteLine("you entered number:"+ num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Write a C# program that prompts the user to input a numeric integer and
        //throws an exception if the number is less than 0 or greater than 1000.
        public void Arguments()
        {
            try
            {
                Console.WriteLine("Enter the number:");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                if (num <= 0 || num >= 1000)
                {
                    throw new ArgumentOutOfRangeException("Number must be 0 and 1000");
                }
                Console.WriteLine("Your enterd number:" + num);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Write a C# program that implements a method that takes an array of integers as input and 
        //calculates the average value.Handle the exception if the array is empty.
        public double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array is empty cann't calculate average");
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
        //Write a C# program that reads a string from the user and converts it to an integer.
        //Handle the exception if the input cannot be parsed into an integer.
        public void Integer()
        {
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();
            try
            {
                int num = int.Parse(input);
                Console.WriteLine("Parsed Integer:" + num);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Inavalid input"+e.Message);
            }
        }
        //Write a C# program that creates a method that reads a date from the user in the format "dd/mm/yyyy" 
        //and converts it to a DateTime object.Handle an exception if the input format is invalid.
        public void Format()
        {
            DateTime date;
            Console.WriteLine("Enter the date:");
            string input = Console.ReadLine();
            try
            {
                date = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                Console.WriteLine("Parsed date: " + date.ToString("dd/MM/yyyy"));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Index()
        {
            string[] colors = { "red", "blue", "green", "yellow" };
            try
            {
                Console.WriteLine(colors[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
