using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class PersonDataCapture
    {
        public static PersonInformation Capture()
        {
            Messages.RegisterMessage();

            PersonInformation personInformation = new PersonInformation();

            Messages.QuestionMessages("Name");
            personInformation.Name = Console.ReadLine();

            Messages.QuestionMessages("SurName");
            personInformation.Surname = Console.ReadLine();

            Messages.QuestionMessages("Address");
            personInformation.Address = Console.ReadLine();

            Messages.QuestionMessages("Phone");
            personInformation.PhoneNumber = Console.ReadLine();

            return personInformation;

        }
    }
}
