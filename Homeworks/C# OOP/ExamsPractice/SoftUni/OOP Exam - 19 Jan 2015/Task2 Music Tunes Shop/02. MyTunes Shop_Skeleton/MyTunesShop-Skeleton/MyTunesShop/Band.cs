using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTunesShop
{
    public class Band : Performer, IBand, IRateable, IPerformer
    {
        public override PerformerType Type
        {
            get { throw new NotImplementedException(); }
        }

        public IList<string> Members
        {
            get { throw new NotImplementedException(); }
        }

        public void AddMember(string memberName)
        {
            throw new NotImplementedException();
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
