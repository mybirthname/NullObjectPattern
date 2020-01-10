using NullObjectPattern;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write mobile phone company");
            string company = Console.ReadLine();

            MobileRepository repository = new MobileRepository();
            var mobile = repository.GetPhoneByCompany(company);
        }
    }
}
