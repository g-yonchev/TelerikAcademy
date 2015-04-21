namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    public interface IPerformer
    {
        string Name { get; }

        PerformerType Type { get; }

        IList<ISong> Songs { get; }
    }
}
