//using System;
//using System.Collections.Generic;

//namespace AddressBook
//{
//    class Program
//    {
//        public class Contact
//        {
//            public string FirstName { get; set; }
//            public string LastName { get; set; }

//            public string Adress { get; set; }

//            public string City { get; set; }

//            public string State { get; set; }

//            public long Zip { get; set; }

//            public long Phone { get; set; }

//            public string Email { get; set; }
//        }

//        static List<Contact> addressBook = new List<Contact>();

//        static void Main(string[] args)
//        {
            
//                Console.WriteLine("1.Add Contact");
//                Console.WriteLine("2.Edit Contact");
//                Console.WriteLine("3.Delete Contact");
//                Console.Write("Enter your choice");

//                int choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        AddContact();
//                        break;
//                    case 2:
//                        EditContact();
//                        break;
//                    case 3:
//                        DeleteContact();
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice");
//                        break;
//                }
//            }
        

//        static void AddContact()
//        {
//            Console.Write("Enter First Name");
//            string firstName = Console.ReadLine();

//            Console.Write("Enter Last Name");
//            string lastName = Console.ReadLine();

//            Console.WriteLine("enter address");
//            string address = Console.ReadLine();

//            Console.WriteLine("enter city");
//            string city = Console.ReadLine();

//            Console.WriteLine("enter state");
//            string state = Console.ReadLine();

//            Console.WriteLine("enter zip");
//            long zip = long.Parse(Console.ReadLine());

//            Console.WriteLine("enter phone");
//            long phone = long.Parse(Console.ReadLine());

//            Console.WriteLine("enter email");
//            string email = Console.ReadLine();


//            addressBook.Add(new Contact {FirstName = firstName, LastName = lastName,Adress=address,City=city,State=state,Zip=zip, });
//            Console.WriteLine("Contact added");
//        }

//        static void EditContact()
//        {
//            Console.Write("Enter first name");
//            string firstName = Console.ReadLine();

//            Contact contact = addressBook.Find(c=>c.FirstName.Equals(firstName));

           
//                Console.Write("Enter new First Name");
//                string FName = Console.ReadLine();

//                Console.Write("Enter new Last Name");
//                string LName = Console.ReadLine();

//                Console.WriteLine("enter address");
//                string Aaddress = Console.ReadLine();

//                Console.WriteLine("enter city");
//                string Ccity = Console.ReadLine();

//                Console.WriteLine("enter state");
//                string Sstate = Console.ReadLine();

//                Console.WriteLine("enter zip");
//                long Zzip = long.Parse(Console.ReadLine());

//                Console.WriteLine("enter phone");
//                long Pphone = long.Parse(Console.ReadLine());

//                Console.WriteLine("enter email");
//                string Eemail = Console.ReadLine();

//                contact.FirstName = FName;
//                contact.LastName = LName;
//                contact.Adress = Aaddress;
//                contact.City = Ccity;
//                contact.State = Sstate;
//                contact.Zip = Zzip;
//                contact.Phone = Pphone;
//                contact.Email = Eemail;
//                contact.FirstName = firstName;
            
//                Console.WriteLine("Contact updated");
           
//        }

//        static void DeleteContact()
//        {
//            Console.Write("Enter name to be deleted");
//            string firstName = Console.ReadLine();

//            Contact contact = addressBook.Find(c=>c.FirstName.Equals(firstName));

//                addressBook.Remove(contact);
//                Console.WriteLine("Contact deleted");
//        }

//        public static void ViewAllContacts()
//        {
            
//                foreach (var contact in addressBook)
//                {
//                    Console.WriteLine(contact.FirstName+contact.LastName);
//                }
            
//        }
//    }
//}

