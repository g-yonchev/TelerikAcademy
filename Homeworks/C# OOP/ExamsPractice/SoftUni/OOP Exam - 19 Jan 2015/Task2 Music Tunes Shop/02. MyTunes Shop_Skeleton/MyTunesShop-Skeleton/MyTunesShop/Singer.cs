namespace MyTunesShop
{
    using System;

    public class Singer : Performer, ISinger, IPerformer
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
