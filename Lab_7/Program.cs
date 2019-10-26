using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Please enter a valid name: ");
            userInput = Console.ReadLine();
            Validation.ValidateNames(userInput);
            
            Console.Write("Please enter a valid email: ");
            userInput = Console.ReadLine();
            Validation.ValidateEmails(userInput);

            Console.Write("Please enter a valid phone: ");
            userInput = Console.ReadLine();
            Validation.ValidatePhone(userInput);

            Console.Write("Please enter a valid date: ");
            userInput = Console.ReadLine();
            Validation.ValidateDate(userInput);

            Console.Write("Please enter valid HTML Elements: ");
            userInput = Console.ReadLine();
            Validation.ValidateHTML(userInput);
        }
    }
}
