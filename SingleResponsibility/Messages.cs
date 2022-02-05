using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome Our Presantation");
        }
        public static void RegisterMessage()
        {
            Console.WriteLine("Please tell your Name,Surname,Adress,City,Telephone Number and Country!");
        }
        public static void QuestionMessages(string fieldname)
        {
            Console.WriteLine($"What is your {fieldname} ?");
        }
        public static void SuccessfullMessage()
        {
            Console.WriteLine("Your register is done !");
        }

        public static void CompleteMessage(PersonInformation person)
        {
            Console.WriteLine($"Your username is {person.Name} {person.Surname}");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }
        public static void DisplayErrorMessage(string fieldname)
        {
            Console.WriteLine($"{fieldname} field cannot be empty");
        }
    }
}
