using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_3
{
    class AddressBook 
    {
        string name;
        string phone;
        
        public AddressBook(string n ,string p)
        {
            name = n;
            phone = p;
        }

        public override string ToString()
        {
            return "Name: " + name + " Tel: " + phone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<AddressBook> theList = new LinkedList<AddressBook>();
            LinkedListIterator<AddressBook> theItr;

            AddressBook ad1 =new AddressBook("Pootanet Rampuey","0612161312");
            AddressBook ad2 = new AddressBook("Rampuey Pootanet", "0712161312");
            AddressBook ad3 = new AddressBook("Dev Rampuey", "0812161312");
            AddressBook ad4 = new AddressBook("jane jane", "0912161312");
            AddressBook ad5 = new AddressBook("dic dic", "0212161312");


            /*
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.Write("Enter phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine();
            AddressBook ad2 = new AddressBook(name, phone);
            */
            theItr = theList.Zeroth();
            theList.Insert(ad1, theItr);
            theList.Insert(ad2, theItr);
            theList.Insert(ad3, theItr);
            theList.Insert(ad4, theItr);
            theList.Insert(ad5, theItr);
            
            theItr = theList.First();
            Console.WriteLine("Empty list");
            while (theItr.IsValid())
            {
                Console.WriteLine("Insert friend : {0}",theItr.Retrieve());
                theItr.Advance();
            }



            Console.ReadKey();
        }
    }
}
