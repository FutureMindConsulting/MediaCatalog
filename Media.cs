using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCatalog
{
    class Media
    { 
        public Media(int ID, string author, string title, int year, string publisher )
        {
            MediaID = ID;
            Author = author;
            Title = title;
            Year = year;
            Publisher = publisher;
        }
        public int MediaID { get; private set; }

        public string Author { get; set; }
        public string Title { get; set; }
        
        public int  Year { get; set; }

        public string Publisher { get; set; }

        override public string ToString()
        {
            return $"MediaID: {MediaID}, Author: {Author}, Title: {Title}, Year: {Year}, Publisher: {Publisher}";
        }
    }
}
