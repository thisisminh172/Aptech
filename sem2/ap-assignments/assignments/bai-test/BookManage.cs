using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace bai_test
{
    public delegate void DShow(string s);
    public class BookManage : IEnumerable
    {
        public event DShow EShow;
        List<Book> bList = new List<Book>();
        public BookManage()
        {
            EShow = new DShow(showMes);
        }
        public void createBook(Book book)
        {
            //Book b = new Book();
            while (true)
            {
                try
                {
                    Console.Write("Enter book title: ");
                    book.pTitle = Console.ReadLine().Trim();
                    break;
                }catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            
            while (true)
            {
                try
                {
                    Console.Write("Enter book price: ");
                    book.pPrice = double.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("is the book sale [1 is sale or 0 is not sale]: ");
                    string ans = Console.ReadLine().Trim();
                    
                    book.pIsSale = ans=="1"?true:false;
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            bList.Add(book);
        }
        public void findByIsSale()
        {
            if (bList.Count == 0)
            {
                EShow("There is no book");
                return;
            }
            var items = from item in bList
                        where item.pIsSale == true
                        select item;
            if(items.ToList().Count == 0)
            {
                EShow("There is no book is sale");
                return;
            }
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public void displayAll()
        {
            if (bList.Count == 0)
            {
                EShow("There is no book");
                return;
            }
            foreach (var item in bList)
            {
                item.bookInfo();
            }
        }
        public void showMes(string s)
        {
            Console.WriteLine(s);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var item in bList)
            {
                yield return item;
            }
        }
    }
}
