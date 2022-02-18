using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Address Book----");
            Contacts con = new Contacts();
            con.CreateContacts();
            con.AddContact();
            Console.ReadKey();
        }
    }
}
