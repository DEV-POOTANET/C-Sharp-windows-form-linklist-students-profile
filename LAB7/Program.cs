using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> theList = new LinkedList<char>();
            LinkedListIterator<char> theItr;

            int i;
            char[] ch = { 'A', 'B', 'C', 'D' };

            theItr = theList.Zeroth();
          
            for (i = 0; i < 4; i++)
            {
                theList.Insert(ch[i], theItr);
                theItr.Advance();
            }

            theItr= theList.First();

            while(theItr.IsValid())
            {
                Console.Write(theItr.Retrieve()+",");
                theItr.Advance();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
