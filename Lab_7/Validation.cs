using System;
using System.Text.RegularExpressions;

namespace Lab_7
{
    class Validation
    {
        public static void ValidateNames(string input)
        {
            if(Regex.IsMatch(input, @"(^[A-Z]{1}[A-z]{0,29}$)"))
            {
                Console.WriteLine("Name is valid!\n");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!\n");
            }
        }
        public static void ValidateEmails(string input)
        {
            if(Regex.IsMatch(input, @"(^[A-z|0-9]{5,30}@{1}[A-z|0-9]{5,10}\.{1}[A-z|0-9]{2,3})"))
            {
                Console.WriteLine("Email is valid!\n");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!\n");
            }
        }
        public static void ValidatePhone(string input)
        {
            if(Regex.IsMatch(input, @"([0-9]{3}-{1}[0-9]{3}-{1}[0-9]{4})"))
            {
                Console.WriteLine("Phone is valid!\n");
            }
            else
            {
                Console.WriteLine("Sorry, phone is not valid!\n");
            }
        }
        public static void ValidateDate(string input)
        {
            if(Regex.IsMatch(input, @"^([012][0-9]|3[01])\/{1}([0][0-9]|1[0-2])\/{1}([0-9]{4})"))
            {
                Console.WriteLine("Date is valid!\n");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid!\n");
            }
        }
        public static void ValidateHTML(string input)
        {
            if (Regex.IsMatch(input, @"<{1}(\w+)>{1}(.*)(<{1}\/{1}(\1)>{1})"))
            {
                Console.WriteLine("HTML is valid!\n");
            }
            else
            {
                Console.WriteLine("Sorry, HTML is not valid!\n");
            }
        }
    }
}
