using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contacts
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int PhoneNumber { get; set; }
            public long PhoneNumbers { get; set; }
            public string EmailId { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int ZipCode { get; set; }

        public void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter FirstName: \n");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Lastline: \n");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber: \n");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumbers: \n");
            contacts.PhoneNumbers = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email ID: \n");
            contacts.EmailId = Console.ReadLine();
            Console.WriteLine("Enter Address: \n");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City: \n");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State: \n");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter ZipCode: \n");
            contacts.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumbers + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode);

        }
        List<Contacts> addressBook = new List<Contacts>();
        public void AddContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter FirstName: \n");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Lastline: \n");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber: \n");
            contacts.PhoneNumbers = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email ID: \n");
            contacts.EmailId = Console.ReadLine();

            Console.WriteLine("Enter Address: \n");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City: \n");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State: \n");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter ZipCode: \n");
            contacts.ZipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode);

            addressBook.Add(contacts);
        }
        public void EditContact(string FirstName)
        {
            Contacts contacts = new Contacts();
            foreach (var item in addressBook)
            {
                if (item.FirstName == FirstName)
                {
                    contacts = item;
                    //return;
                    break;
                }
            }
            Console.WriteLine("1.LastName \n2.PhoneNumber \n3.EmailID \n4.Address \n5.City \n6.State \n7.ZipCode ");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        contacts.LastName = Console.ReadLine();
                        break;

                    case 2:
                        contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        contacts.EmailId = Console.ReadLine();
                        break;

                    case 4:
                        contacts.Address = Console.ReadLine();
                        break;

                    case 5:
                        contacts.City = Console.ReadLine();
                        break;

                    case 6:
                        contacts.State = Console.ReadLine();
                        break;

                    case 7:
                        contacts.ZipCode = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        flag = false;
                        break;

                }
                display(contacts);
            }



        }

        public static void display(Contacts contacts)
        {
            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n");
        }
    }
}
