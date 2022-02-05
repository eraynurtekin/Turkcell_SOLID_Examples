using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class PersonCheck
    {
        public static bool PersonValidation(PersonInformation person)
        {
            

            if (string.IsNullOrEmpty(person.Name))
            {
                Messages.DisplayErrorMessage("Name");
                Messages.EndApplication();
                return false;
            }
            if (string.IsNullOrEmpty(person.Surname))
            {
                Messages.DisplayErrorMessage("Surname");
                Messages.EndApplication();
                return false;
            }
            if (string.IsNullOrEmpty(person.Address))
            {
                Messages.DisplayErrorMessage("Address");
                Messages.EndApplication();
                return false;
            }

            return true;

        }

    }
}
