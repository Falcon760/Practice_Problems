using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library101 = new Library("Library101", 101);
            //
            //Book book1 = new Book(1, "Hamlet", "Shakespeare", new DateTime(2000,02,10));
            //Book book2 = new Book(2, "Something", "Sir Something", new DateTime(2001, 01, 10));

            Computer myc = new Computer();
            myc.Itemid = 2;
            
            var x = library101.FindBook(1);
            Console.WriteLine("The first book is " + x.Name + " and it is a " + x.Description);

            List<Item> myItems = Item.GetItems(10);
            foreach (Item items in myItems)
            {
                Console.WriteLine("The item is {0} and its ID is {1}", items.Name, items.Itemid);

            }
	{
		 
	}
            
            //Console.WriteLine("The first book is: {0} by {1}, published on {2}", book1.Title, book1.Author, book1.PublishDate);
                Console.ReadLine();
        }

       

        }
    }

