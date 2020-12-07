using System;
using System.Collections.Generic;

namespace MediaCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media catalog starting");

            //Start: Assignment 4
            MediaCatalog mCat = new MediaCatalog();    
            Media m1 = new Media(1, "H.C. Andersen", "Gyldendal", 2018, "Ugly Duckling");
            Media m2 = new Media(2, "George Orwell", "Pearson", 2016, "1984");
            Media m3 = new Media(3, "James Joyce", "Pearson", 2014, "Ulysses");
            Media m4 = new Media(4, "H.C. Andersen", "Gyldendal", 2014, "Clumpsy Hans");
            //End: Assignment 4

            //Start: Assignment 5
            mCat.AddMedia(m1);
            mCat.AddMedia(m2);
            mCat.AddMedia(m3);
            mCat.AddMedia(m4);

            Console.WriteLine();
            Console.WriteLine("Printing medias:");
            mCat.PrintMediaList();

            Console.WriteLine();
            Console.WriteLine("Testing GetMedia:");

            Console.WriteLine("Testing GetMedia(1):");
            Media mTest = mCat.GetMedia(m1.MediaID);
            if (mTest != null)
            {
                Console.WriteLine(mTest);
            }

            Console.WriteLine("Testing GetMedia(42):");
            mTest = mCat.GetMedia(42);
            if (mTest == null)
            {
                Console.WriteLine("Null as expected");
            }
            Console.WriteLine();
            //End: Assignment 5

            //Start: Assignment 6
            Console.WriteLine("Testing exception:");
            try
            {
                mCat.AddMedia(new Media(42, "", "", 2000, ""));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            //End: Assignment 6


            //Start: Assignment 7
            Book b1 = new Book(10, "Jonathan Rasmussen", "The Agile Samurai", 2010, "The Pagmatic Bookshelf", "978-1-934356-58-6");
            Book b2 = new Book(11, "Osterwalder & Pigneur", "Business Model Canvas", 2010, "Wiley", "978-0470-87641-1");

            mCat.AddMedia(b1);
            mCat.AddMedia(b2);
            Console.WriteLine();

            Console.WriteLine("Printing medias:");
            mCat.PrintMediaList();
            Console.WriteLine();

            //End: Assignment 7


            //Start: Assignment 8
            List<Media> foundMedia = mCat.GetMediaByAuthor("H.C. Andersen");

            Console.WriteLine("Found medias printed in a while loop:");
            int idx = 0;
            while (idx < foundMedia.Count)
            {
                Console.WriteLine(foundMedia[idx]);
                idx++;
            }
            //Start: Assignment 8
            Console.WriteLine("Media catalog ending");

            }
    }
}
