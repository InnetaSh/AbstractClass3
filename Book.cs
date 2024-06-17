using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Book: количество страниц(PageCount).

namespace AbstractClass3
{
    internal class Book : LibraryItem
    {
        public int PageCount { get; private set; } // количество страниц.
        public Book(string title, string author, int pageCount) :base(title,author)
        {
            PageCount = pageCount;
        }
        public override string GetInfo()
        {
           return $"Книга \'{Title}\',\nавтор - {Author},\tколичество страниц - {PageCount}";
        }
    }
}
