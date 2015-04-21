namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Song : ISong
    {
        private static readonly int MinYear = DateTime.MinValue.Year;
        private static readonly int MaxYear = DateTime.Now.Year;

        private string title;
        private decimal price;
        private IPerformer performer;
        private string genre;
        private int year;
        private string duration;

        public Song(string title, decimal price, IPerformer performer, string genre, int year, string duration)
        {
            this.Title = title;
            this.Price = price;
            this.Performer = performer;
            this.Genre = genre;
            this.Year = year;
            this.Duration = duration;
            this.Ratings = new List<int>();
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The title of a song is required.");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price of a song must be non-negative.");
                }

                this.price = value;
            }
        }

        public IPerformer Performer
        {
            get
            {
                return this.performer;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The performer of a song is required.");
                }

                this.performer = value;
            }
        }

        public string Genre
        {
            get
            {
                return this.genre;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The genre of a song is required.");
                }

                this.genre = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            private set
            {
                if (value < MinYear || value > MaxYear)
                {
                    throw new ArgumentException(string.Format("The year of a song must be between {0} and {1}.", MinYear, MaxYear));
                }

                this.year = value;
            }
        }

        public string Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The duration of a song is required.");
                }

                this.duration = value;
            }
        }

        public IList<int> Ratings { get; private set; }

        public void PlaceRating(int rating)
        {
            this.Ratings.Add(rating);
        }
    }
}
