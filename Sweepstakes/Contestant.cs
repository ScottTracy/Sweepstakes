using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName = "";
        public string lastName;
        public string email;
        public int registration;
        public Dictionary<string, string> info = new Dictionary<string, string>();

        public string GetUserInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public void GetFirstName()
        {
            firstName = GetUserInput("What is your first name?");
        }
        public void GetLastName()
        {
            lastName = GetUserInput("What is your last name?");
        }
        public void GetEmail()
        {
            email = GetUserInput("What is your E-mail address?");
        }
        public void GetInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
        }
        public void MakeDictionary()
        {
            info.Add("First name", firstName);
            info.Add("Last name", lastName);
            info.Add("E-mail", email);
            info.Add("Registration number", registration.ToString());
        }


        
    }
}
