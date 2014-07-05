using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Library
    {
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }

        public Library(string name, int id)
        {
            this.LibraryName = name;
            this.LibraryID = id;
        }

        public Book FindBook(int id)
        {
            Book foundbook = new Book() { Itemid=1, Name="Hamlet", Author="Shakespeare", PublishDate=new DateTime(2001,10,4), Description="Book about revenge" };
            return foundbook;

        }
    }
}
