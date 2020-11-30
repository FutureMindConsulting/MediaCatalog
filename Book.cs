using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCatalog
{
    class Book : Media
    {
        public string ISBN { get; set; }

        public Book(int ID, string author, string title, int year, string publisher, string isbn)
            : base(ID, author, title, year, publisher)
        {
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ISBN: {ISBN}";
        }
    }
}
