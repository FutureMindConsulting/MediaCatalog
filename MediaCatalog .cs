using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCatalog
{
    class MediaCatalog
    {
        const int lowestYear = 2010;

        //Ensures that there wil be only one Media object with the same MediaID in the MediaCatalog. 
        Dictionary<int, Media> medias;
        
        public MediaCatalog()
        {
            medias = new Dictionary<int, Media>();
        }

        public void AddMedia(Media aMedia)
        {
            //Start: Assignment 6
            if (aMedia.Year < lowestYear)
            {
                throw new ArgumentException($"Year NOT allowed to be less than {lowestYear}");
            }
            //End: Assignment 6

            //No need to check MediaID, because af dictionary implementation
            medias.Add(aMedia.MediaID, aMedia);
        }

        public void PrintMediaList()
        {
            int lineNumber = 0;
            foreach(Media m in medias.Values)
            {
                lineNumber++;
                Console.WriteLine($"Line number: {lineNumber},  {m}" );
            }
        }

        public Media GetMedia(int mediaID)
        {
            Media result = null;
            medias.TryGetValue(mediaID, out result);
            return result;
        }

        public List<Media> GetMediaByAuthor(string author)
        {
            List<Media> result = null;

            foreach(var m in medias)
            {
                if (result == null)
                   result = new List<Media>();

                if (m.Value.Author == author)
                {
                    result.Add(m.Value);
                }

            }
            return result;
        }
    }
}
