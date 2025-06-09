using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                if (denominator == 0)
                {
                    throw new DivideByZeroException("You cannot divide by zero.");
                }

                int result = numerator / denominator;
                Console.WriteLine("Result: {numerator} / {denominator} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input must be a valid integer. " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Math Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed. Thank you!");
            }
        }
    }
}
