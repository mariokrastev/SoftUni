using System;

class PrintCompanyInfo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Company Name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company Adress: ");
        string companyAdress = Console.ReadLine();
        Console.WriteLine("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax Number: ");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Website: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager First Name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager Last Name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Manager Age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Manager Phone Number: ");
        string managerNumber = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: " + companyAdress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerNumber + " )");



    }
}

