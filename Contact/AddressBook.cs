using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class AddressBook
    {
        string ownerName;
        string info;
        Contact[] listOfContact = new Contact[1000];
        int t = 0;

        public AddressBook()
        {
            t = 0;
        }
        public AddressBook(string ownerName, string info)
        {
            this.ownerName = ownerName;
            this.info = info;
        }
        public void ShowAllContactInfo()
        {
            Console.WriteLine("Owner Name: " + ownerName + " ,Info: " + info);
            /*for (int i = 0; i<4; i++)
            {
                Console.WriteLine("\nname: " + listOfContact[0].getPersonName() + "\nbook author: " + listOfContact[1].getPersonId());
                Console.WriteLine("\nname: " +listOfContact[0].getPersonName() );
            }*/
            Console.WriteLine(" ");


        }
        public void AddContact(Contact con)
        {

            listOfContact[0] = con;

            Console.WriteLine("Added: " + listOfContact[0].getMobileNumber());
            t++;

        }
        public void DeleteContact(Contact con)
        {
            for (int i = 0; i < t; i++)
            {
                if (listOfContact[i].MobileNumber == con.MobileNumber)
                {
                    Console.WriteLine("Deleted:" + listOfContact[0].getMobileNumber());
                }

            }

        }
    }
}
