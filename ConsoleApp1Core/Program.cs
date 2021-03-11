using System;
using System.Dynamic;

namespace ConsoleApp1Core
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic customer = new ExpandoObject();
            customer.Name = "Ross";

            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Name.GetType());

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
