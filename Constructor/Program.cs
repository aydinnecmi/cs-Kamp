using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Customer customer1 = new Customer(1,"aydın","as","bursa");
            Console.WriteLine(customer1.City);
        }
    }

    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName,string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;


        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string City { get; set; }

    }
}
