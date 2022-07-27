using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollection
{
    class BookStore
    {
        int bookid;
        string bookName;

        public int Bookid { get { return bookid; } set { bookid = value; } }
        public string BookName { get { return bookName; } set { bookName = value; } }

        public BookStore(int id, string name)
        {
            Bookid = id;
            BookName = name;
        }

        public static void Display(BookStore book)
        {
            Console.WriteLine(book.Bookid + " " + book.BookName);
        }
    }
    internal class Question4
    {
        static void Main()
        {
            Hashtable Books = new Hashtable();         
            Console.WriteLine("Enter Book details or exit to exit:");
            for (int i = 1; ; i++)
            {
                Console.Write("Book ID: ");
                int bId;
                string? temp = Console.ReadLine();
                try
                {

                    if (temp == "")
                    {
                        throw new Exception("Book ID cannot be empty");
                    }
                    if (temp.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    bId = int.Parse(temp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                    continue;
                }

                Console.Write("Book Name: ");
                string? bName = Console.ReadLine();
                if (bName == "")
                {
                    Console.WriteLine("Name Cannot be null");
                    i--;
                    continue;
                }
                BookStore book = new BookStore(bId, bName);
                Books.Add(i, book);
            }

            Console.WriteLine("Employee Details");
            foreach (BookStore book in Books.Values)
            {
                BookStore.Display(book);
            }
        }
    }
}
