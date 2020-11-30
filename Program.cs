using System;

namespace MediaCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media catalog starting");

            MediaCatalog mCat = new MediaCatalog();

            Media m1 = new Media(mCat.NextMediaID) 
            { 
                Author = "H.C. Andersen", 
                Publisher = "Gyldendal", 
                Title = "Ugly Duckling", 
                Year = 2018 
            };
            mCat.AddMedia(m1);

            Media m2 = new Media(mCat.NextMediaID)
            {
                Author = "George Orwell",
                Publisher = "Pearson",
                Title = "1984",
                Year = 2016
            };
            mCat.AddMedia(m2);

            Media m3 = new Media(mCat.NextMediaID)
            {
                Author = "James Joyce",
                Publisher = "Pearson",
                Title = "Ulysses",
                Year = 2014
            };
            mCat.AddMedia(m3);

            //Console.WriteLine(m1);
            //Console.WriteLine(m2);
            //Console.WriteLine(m3);

            mCat.PrintMediaList();

            Console.WriteLine("Media catalog ending");
    }
    }
}
