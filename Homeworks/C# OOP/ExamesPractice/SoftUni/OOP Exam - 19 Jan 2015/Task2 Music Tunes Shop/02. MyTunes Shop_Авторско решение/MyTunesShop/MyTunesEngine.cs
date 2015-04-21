namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MyTunesEngine
    {
        private Printer printer;

        protected IList<IMedia> media;
        protected IDictionary<IMedia, SalesInfo> mediaSupplies;
        protected IList<IPerformer> performers;

        public MyTunesEngine()
        {
            this.printer = new Printer();
            this.media = new List<IMedia>();
            this.mediaSupplies = new Dictionary<IMedia, SalesInfo>();
            this.performers = new List<IPerformer>();
        }

        public Printer Printer
        {
            get
            {
                return this.printer;
            }
        }

        public void ParseCommand(string command)
        {
            string[] commandWords = command.Split(new[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                this.DispatchCommand(commandWords);
            }
            catch (Exception e)
            {
                this.Printer.PrintLine(e.Message);
            }
        }

        protected virtual void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "performer":
                    this.ExecuteInsertPerformerCommand(commandWords);
                    break;
                case "media":
                    this.ExecuteInsertMediaCommand(commandWords);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteInsertPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "singer":
                    var singer = new Singer(commandWords[3]);
                    this.InsertPerformer(singer);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteInsertMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "song":
                    var performer = this.performers.FirstOrDefault(p => p.Name == commandWords[5]);
                    if (performer == null)
                    {
                        this.Printer.PrintLine("The performer does not exist in the database.");
                        return;
                    }

                    var song = new Song(
                        commandWords[3],
                        decimal.Parse(commandWords[4]),
                        performer,
                        commandWords[6],
                        int.Parse(commandWords[7]),
                        commandWords[8]);
                    this.InsertSong(song, performer);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteSupplyCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song":
                    var song = this.media.FirstOrDefault(s => s is ISong && s.Title == commandWords[2]);
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    int quantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[song].Supply(quantity);
                    this.Printer.PrintLine("{0} items of song {1} successfully supplied.", quantity, song.Title);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteSellCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song":
                    var song = this.media.FirstOrDefault(s => s is ISong && s.Title == commandWords[2]);
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    int quantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[song].Sell(quantity);
                    this.Printer.PrintLine("{0} items of song {1} successfully sold.", quantity, song.Title);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteReportCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "performer":
                    this.ExecuteReportPerformerCommand(commandWords);
                    break;
                case "media":
                    this.ExecuteReportMediaCommand(commandWords);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteReportPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "singer":
                    var singer = this.performers.FirstOrDefault(p => p is Singer && p.Name == commandWords[3]) as Singer;
                    if (singer == null)
                    {
                        this.Printer.PrintLine("The singer does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetSingerReport(singer));
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteReportMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "song":
                    var song = this.media.FirstOrDefault(s => s is ISong && s.Title == commandWords[3]) as ISong;
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetSongReport(song));
                    break;
                default:
                    break;
            }
        }

        protected virtual string GetSongReport(ISong song)
        {
            var songSalesInfo = this.mediaSupplies[song];
            StringBuilder songInfo = new StringBuilder();
            songInfo.AppendFormat("{0} ({1}) by {2}", song.Title, song.Year, song.Performer.Name).AppendLine()
                .AppendFormat("Genre: {0}, Price: ${1:F2}", song.Genre, song.Price).AppendLine()
                .AppendFormat("Rating: {0:F0}", song.Ratings.Any() ? song.Ratings.Average() : 0).AppendLine()
                .AppendFormat("Supplies: {0}, Sold: {1}", songSalesInfo.Supplies, songSalesInfo.QuantitySold);
            return songInfo.ToString();
        }

        protected virtual string GetSingerReport(Singer singer)
        {
            StringBuilder singerInfo = new StringBuilder();
            singerInfo.Append(singer.Name + ": ");
            if (singer.Songs.Any())
            {
                var songs = singer.Songs
                  .Select(s => s.Title)
                  .OrderBy(s => s);
                singerInfo.Append(string.Join("; ", songs));
            }
            else
            {
                singerInfo.Append("no songs");
            }

            return singerInfo.ToString();
        }

        protected virtual void ExecuteRateCommand(string[] commandWords)
        {
            throw new NotImplementedException();
        }

        protected void InsertPerformer(IPerformer performer)
        {
            this.performers.Add(performer);
            this.Printer.PrintLine("{0} {1} added successfully", performer.Type.ToString(), performer.Name);
        }

        private void InsertSong(ISong song, IPerformer performer)
        {
            this.media.Add(song);
            this.mediaSupplies.Add(song, new SalesInfo());
            performer.Songs.Add(song);
            this.Printer.PrintLine("Song {0} by {1} added successfully", song.Title, performer.Name);
        }

        private void DispatchCommand(string[] commandWords)
        {
            switch (commandWords[0])
            {
                case "insert":
                    this.ExecuteInsertCommand(commandWords);
                    break;
                case "supply":
                    this.ExecuteSupplyCommand(commandWords);
                    break;
                case "sell":
                    this.ExecuteSellCommand(commandWords);
                    break;
                case "report":
                    this.ExecuteReportCommand(commandWords);
                    break;
                case "rate":
                    this.ExecuteRateCommand(commandWords);
                    break;
                default:
                    break;
            }
        }
    }
}