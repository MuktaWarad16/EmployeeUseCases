//using System;
//using System.Collections.Generic;

//namespace com
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            
//            List<Contact> lst = new List<Contact>();

//            Console.WriteLine("Enter First Name");
//            string firstName = Console.ReadLine();

//            Console.WriteLine("Enter Last Name");
//            string lastName=Console.ReadLine();

//            Console.WriteLine("enter address");
//            string address=Console.ReadLine();

//            Console.WriteLine("enter city");
//            string city=Console.ReadLine();

//            Console.WriteLine("enter address");
//            string state=Console.ReadLine();

//            Console.WriteLine("enter address");
//            long zip=long.Parse(Console.ReadLine());

//            Console.WriteLine("enter address");
//            long phone=long.Parse(Console.ReadLine());

//            Console.WriteLine("enter address");
//            string email=Console.ReadLine();

//            Contact c=new Contact(firstName,lastName,address,city,state,zip,phone,email);
//            lst.Add(c);

//            Console.WriteLine("Contact added successfully!");
//            Console.WriteLine(c.FirstName +c.LastName+c.Email+c.City+c.Phone+c.Adress+c.Zip);

            
//            Console.WriteLine("Address Book:");
//            foreach (var x in lst)
//            {
//                Console.WriteLine(c.FirstName);
//            }
//        }
//    }

//    public class Contact
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public string Adress { get; set; }

//        public string City { get; set; }

//        public string State { get; set; }

//        public long Zip { get; set; }

//        public long Phone { get; set; }

//        public string Email { get; set; }

//        public Contact(string firstName, string lastName,s)
//        {
//            FirstName =firstName;
//            LastName=lastName;
//            Adress = address;
//            City = city;
//            State = state;
//            Zip = zip;
//            Phone = phone;
//            Email = email;

//        }
//    }
//}
