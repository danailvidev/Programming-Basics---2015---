using System;

namespace _02.Print_Company_Information
{
    class PrintCompanyInformation
    {
        /*
        A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
        Write a program that reads the information about a company and its manager and prints it back on the console.
        */
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companySite = Console.ReadLine();

            string managerFName = Console.ReadLine();
            string managerLName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();
            string managerFullName = managerFName + " " + managerLName;

            Console.WriteLine($"[Company Name:{companyName}, Address:{companyAddress}, Phone:{companyPhone}, Fax:{companyFax}, WebSite:{companySite}]");
            Console.WriteLine($"[Manager Name:{managerFullName}, Age:{managerAge}, Phone:{managerPhone}]");

        }
    }
}
