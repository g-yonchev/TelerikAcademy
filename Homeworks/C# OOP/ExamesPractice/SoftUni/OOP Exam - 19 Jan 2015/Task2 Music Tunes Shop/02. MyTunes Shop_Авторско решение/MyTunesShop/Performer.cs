namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    public abstract class Performer : IPerformer
    {
        private string name;
        private IList<ISong> songs;

        public Performer(string name)
        {
            this.Name = name;
            this.songs = new List<ISong>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name of a performer is required.");
                }

                this.name = value;
            }
        }

        public abstract PerformerType Type { get; }

        public IList<ISong> Songs
        {
            get
            {
                return this.songs;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The songs of a performer are required.");
                }

                this.songs = value;
            }
        }
    }
}
