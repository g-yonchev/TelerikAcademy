using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTunesShop
{
    public abstract class Media : IMedia, IRateable
    {
        public string Title
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Price
        {
            get { throw new NotImplementedException(); }
        }

        public IList<int> Ratings
        {
            get { throw new NotImplementedException(); }
        }

        public void PlaceRating(int rating)
        {
            throw new NotImplementedException();
        }
    }
}
