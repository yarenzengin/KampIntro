using System;

namespace Constructors
{
    //1 class ı new lediğimizde çalışır
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "yaren",LastName ="zengin",City="İstanbul"  };
            //=
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2,"derin","demiroğ","ankara");//method mantığı

            Console.WriteLine(customer2.FirstName);


        }

    }
    class Customer
    {
        //default constr. = parametresiz cons.
        public Customer()
        {

        }
         
        public Customer(int Id , string firstName, string lastName ,string city)
        {
            Console.WriteLine("yapıcı blok çalıştı");
            //çalışmasını istediğimiz kodları yazıyoruz
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            City = city;


        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
