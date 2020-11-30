using System;

namespace MediaCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media catalog starting");
            Media m1 = new Media(1) { Author = "H.C. Andersen", 
                                      Publisher = "Gyldendal", 
                                      Title = "Ugly Duckling", 
                                      Year = 2018 };
            Media m2 = new Media(2)
            {
                Author = "George Orwell",
                Publisher = "Pearson",
                Title = "1984",
                Year = 2016
            };

            Media m3 = new Media(3)
            {
                Author = "James Joyce",
                Publisher = "Pearson",
                Title = "Olysses",
                Year = 2014
            };

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);

            Console.WriteLine("Media catalog ending");
    }
    }
}
