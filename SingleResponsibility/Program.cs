using System;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();


            PersonInformation person = PersonDataCapture.Capture();

            bool isUserValid = PersonCheck.PersonValidation(person);
             
            if(isUserValid == false)
            {
               
                return;
            }

            Messages.CompleteMessage(person);

            Messages.SuccessfullMessage();
          
        }
    }
}
