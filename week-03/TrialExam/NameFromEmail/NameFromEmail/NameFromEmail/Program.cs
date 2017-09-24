using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }
        public static string NameFromEmail(string EmailAddress)
        {
            EmailAddress = "elek.viz@exam.com";

            string FullName = EmailAddress.Substring(0, EmailAddress.IndexOf("@"));
            string Firstname = FullName.Substring(0, EmailAddress.IndexOf("."));
            string Lastname = FullName.Substring(FullName.IndexOf(".") + 1);                      

            string LastNameUpperCase = char.ToUpper(Lastname[0]) + Lastname.Substring(1);
            string FirstNameUpperCase = char.ToUpper(Firstname[0]) + Firstname.Substring(1);

            return LastNameUpperCase + " " + FirstNameUpperCase;
   
        }
    }
}