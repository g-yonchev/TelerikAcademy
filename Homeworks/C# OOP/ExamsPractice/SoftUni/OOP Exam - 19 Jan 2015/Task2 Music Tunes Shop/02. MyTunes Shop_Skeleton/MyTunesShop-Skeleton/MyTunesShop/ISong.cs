namespace MyTunesShop
{
    using System;

    public interface ISong : IMedia
    {
        IPerformer Performer { get; }

        string Genre { get; }

        int Year { get; }

        string Duration { get; }
    }
}
