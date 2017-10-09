using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine("Hello Welcome to the Onboarding Application..!");

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine("Your first name is" + " " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Your Last name is" + " " + user.LastName);
            Console.WriteLine("Awesome! your full name is" + " " + user.FirstName +" " + user.LastName);

            user.Email = AskQuestion("What is your email id?");
            Console.WriteLine("Your Email Id is" + " " + user.Email);

            user.IsAccountOwner = AskBoolQuestion("Are you the current owner?");
            Console.WriteLine("you are the current owner: " + " " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber("What is your 4 digit-pin?", 4);
            Console.WriteLine("Awesome..! You entered:  " + " " + user.PinNumber);

            user.AType = AskAccountType("What is your Account Type?");
            Console.WriteLine("Your Account Type is"+" "+user.AType);
            Console.ReadLine();
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnswered = false;
            var responseBool = false;
            while (!hasAnswered)
            {
                var response = AskQuestion(question + "(y/n)");
                if (response == "y")
                {
                    responseBool = true;
                    hasAnswered = true;
                }
                else 
                {
                    responseBool = false;
                    hasAnswered = true;
                }
            }
            return responseBool;
        }

        static string AskPinNumber(string question, int length)
        {
            string numberString = null;
            while (numberString == null)
            {
                var response = AskQuestion(question);
                if (response.Length == length && Int32.TryParse(response, out int possibleResponse))
                {
                    numberString = response;
                }
            }
            return numberString;
        }

        static AccountType AskAccountType(string question)
        {
            AccountType? answer = null;
            while (answer == null)
            {
                var response = AskQuestion(question);
                if (Enum.TryParse(response, out AccountType result))
                {
                    answer = result;
                }
            }

            return (AccountType) answer;
        }
    }
}
