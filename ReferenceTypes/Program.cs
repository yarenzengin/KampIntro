using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int ,decimal,float,wnum,boolean = value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("sayi 1 : " + sayi1);
           
            ////array , class, interface reference type
            //int[] sayilar1 = new int[] {1,2,3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 10000;
            //Console.WriteLine("Sayılar[0]" + sayilar1[0] );


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "yaren";

            person2 = person1;//adres eşitlemesi yapıyorsun
            person1.FirstName = "büşra";

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "eray";
            customer.CreditCardNumber = "4958454";
            Employee employee = new Employee();
            employee.FirstName = "şevval";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            //boxing yaptık
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

        }

    }//person cust.ında employee nin de adresini tutuyor
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
    }
    //base class : person 
    class Customer:Person//müşteri bir kişidir(miras aldığın sınıfın adresini atabilirsin)
    {
        public string  CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    //aynı kodu farklı nesneler ile çalıştırabiliyoruz
    class PersonManager
    {
        public void Add(Person person)//hem person ı hem  customer ı hem employee yi gönderebilirz
        {
            Console.WriteLine(person.FirstName
                );
        }
    }
}
