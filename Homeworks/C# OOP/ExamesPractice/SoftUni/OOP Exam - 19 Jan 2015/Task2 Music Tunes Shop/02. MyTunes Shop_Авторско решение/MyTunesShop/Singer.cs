namespace MyTunesShop
{
    using System;

    public class Singer : Performer
    {
        public Singer(string name)
            : base(name)
        {
        }

        public override PerformerType Type
        {
            get
            {
                return PerformerType.Singer;
            }
        }
    }
}
