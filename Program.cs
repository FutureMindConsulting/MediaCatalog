using System;

namespace MediaCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media catalog starting");

            MediaCatalog mCat = new MediaCatalog();

            Media m1 = new Book(mCat.NextMediaID, "H.C. Andersen", "Gyldendal", 2018, "Ugly Duckling","1234567890"); 
            mCat.AddMedia(m1);

            Media m2 = new Book(mCat.NextMediaID, "George Orwell", "Pearson", 2016, "1984", "1234567890");
            mCat.AddMedia(m2);

            Media m3 = new Book(mCat.NextMediaID, "James Joyce", "Pearson", 2014, "Ulysses", "1234567890");
            mCat.AddMedia(m3);

           

            //Console.WriteLine(m1);
            //Console.WriteLine(m2);
            //Console.WriteLine(m3);

            mCat.PrintMediaList();

            Console.WriteLine();
            Console.WriteLine("Testing GetMedia");
            
            Media mTest = mCat.GetMedia(m1.MediaID);
            if (mTest != null)
            {
                Console.WriteLine(mTest);
            }

            mTest = mCat.GetMedia(42);
            if (mTest == null)
            {
                Console.WriteLine("Null as expected");
            }


            try
            {
                mCat.AddMedia (new Media(42,"","",2000,""));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }





            Console.WriteLine("Media catalog ending");
    }
    }
}
