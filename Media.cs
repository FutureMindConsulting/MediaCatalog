using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCatalog
{
    class Media
    {
        public Media(int ID )
        {
            MediaID = ID;
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
