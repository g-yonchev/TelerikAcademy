using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTunesShop
{
    public class Album : Media, IAlbum, IMedia, IRateable
    {
        public IPerformer Performer
        {
            get { throw new NotImplementedException(); }
        }

        public string Genre
        {
            get { throw new NotImplementedException(); }
        }

        public int Year
        {
            get { throw new NotImplementedException(); }
        }

        public IList<ISong> Songs
        {
            get { throw new NotImplementedException(); }
        }

        public void AddSong(ISong song)
        {
            throw new NotImplementedException();
        }

        public string Title
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Price
        {
            get { throw new NotImplementedException(); }
        }
    }
}
