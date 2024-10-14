using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedProgram
{
    public class BookPresenter
    {
        public void Display(Book book)
        {
            Console.WriteLine($"Book: {book.Title} ({book.Id})");
        }
    }
}
