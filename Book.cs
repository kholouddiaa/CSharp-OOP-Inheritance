using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion4_iti
{
    internal class Book : IPrintable, IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }

        public void Borrow()
        {
            Console.WriteLine($"{Title} has been borrowed.");
        }
    }
}
