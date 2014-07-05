using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Item
    {

            public int Itemid { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Item(int id)
            {
                Itemid = id;
            }
        
            
            
            public Item()
            {
                //  member initialization
            }

            public virtual void Describe()
            {
                Console.WriteLine("This is a {0}", Description);
            }
            public static List<Item> GetItems(int Num)
            {
                var random = new Random();
                var newList = new List<Item>();
                Item newItem;
                for (int i = 0; i < Num; i++)
                {
                    newItem = new Item() { Itemid = random.Next(), Name = "MyItem" + i.ToString() };
                    newList.Add(newItem);
                }
                return newList;
            }
    }

    class Book : Item
    {
            
            public string Author { get; set; }
            public DateTime PublishDate { get; set; }
            public Book(int id, string title, string author, DateTime publishdate, string summary)
            {
                Itemid = id;
                Name = title;
                Author = author;
                PublishDate = publishdate;
                Description = summary;
            }
        public Book()
            { }
            
        }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }
    class Computer : Hardware
    {
        public string Type { get; set; }
        public int MemorySize { get; set; }
    }

}
