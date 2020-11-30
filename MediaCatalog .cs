using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCatalog
{
    class MediaCatalog
    {
        int _nextMediaID;
        Dictionary<int, Media> medias;

        public int NextMediaID { get { return _nextMediaID++; } }
        
        public MediaCatalog()
        {
            _nextMediaID = 0;
            medias = new Dictionary<int, Media>();
        }

        public void AddMedia(Media aMedia)
        {
            medias.Add(aMedia.MediaID, aMedia);
        }

    }
}
