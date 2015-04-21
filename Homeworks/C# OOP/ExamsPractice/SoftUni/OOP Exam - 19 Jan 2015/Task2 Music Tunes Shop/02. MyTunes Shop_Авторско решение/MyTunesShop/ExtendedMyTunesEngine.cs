namespace MyTunesShop
{
    using System;
    using System.Linq;
    using System.Text;

    public class ExtendedMyTunesEngine : MyTunesEngine
    {
        protected override void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song_to_album":
                    var album = this.media.FirstOrDefault(m => m is IAlbum && m.Title == commandWords[2]) as IAlbum;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    var song = this.media.FirstOrDefault(m => m is ISong && m.Title == commandWords[3]) as ISong;
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    album.AddSong(song);
                    this.Printer.PrintLine("The song {0} has been added to the album {1}.", song.Title, album.Title);
                    break;
                case "member_to_band":
                    var band = this.performers.FirstOrDefault(p => p is IBand && p.Name == commandWords[2]) as Band;
                    if (band == null)
                    {
                        this.Printer.PrintLine("The band does not exist in the database.");
                        return;
                    }

                    band.AddMember(commandWords[3]);
                    this.Printer.PrintLine("The member {0} has been added to the band {1}.", commandWords[3], band.Name);
                    break;
                default:
                    base.ExecuteInsertCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteRateCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song":
                    var song = this.media.FirstOrDefault(s => s is ISong && s.Title == commandWords[2]) as ISong;
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    song.PlaceRating(int.Parse(commandWords[3]));
                    this.Printer.PrintLine("The rating has been placed successfully.");
                    break;
                default:
                    base.ExecuteRateCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var performer = this.performers.FirstOrDefault(p => p.Name == commandWords[5]);
                    if (performer == null)
                    {
                        this.Printer.PrintLine("The performer does not exist in the database.");
                        return;
                    }

                    var album = new Album(
                        commandWords[3],
                        decimal.Parse(commandWords[4]),
                        performer,
                        commandWords[6],
                        int.Parse(commandWords[7]));
                    this.InsertAlbum(album, performer);
                    break;
                default:
                    base.ExecuteInsertMediaCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var album = this.media.FirstOrDefault(m => m is IAlbum && m.Title == commandWords[3]) as IAlbum;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetAlbumReport(album));
                    break;
                default:
                    base.ExecuteReportMediaCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "band":
                    var band = this.performers.FirstOrDefault(p => p is IBand && p.Name == commandWords[3]) as IBand;
                    if (band == null)
                    {
                        this.Printer.PrintLine("The band does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetBandReport(band));
                    break;
                default:
                    base.ExecuteReportPerformerCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "band":
                    var band = new Band(commandWords[3]);
                    this.InsertPerformer(band);
                    break;
                default:
                    base.ExecuteInsertPerformerCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSupplyCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(s => s is IAlbum && s.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    int quantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[album].Supply(quantity);
                    this.Printer.PrintLine("{0} items of album {1} successfully supplied.", quantity, album.Title);
                    break;
                default:
                    base.ExecuteSupplyCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSellCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(s => s is IAlbum && s.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    int quantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[album].Sell(quantity);
                    this.Printer.PrintLine("{0} items of album {1} successfully sold.", quantity, album.Title);
                    break;
                default:
                    base.ExecuteSellCommand(commandWords);
                    break;
            }
        }

        private void InsertAlbum(Album album, IPerformer performer)
        {
            this.media.Add(album);
            this.mediaSupplies.Add(album, new SalesInfo());
            this.Printer.PrintLine("Album {0} by {1} added successfully", album.Title, performer.Name);
        }

        private string GetAlbumReport(IAlbum album)
        {
            var albumSalesInfo = this.mediaSupplies[album];
            StringBuilder albumInfo = new StringBuilder();
            albumInfo.AppendFormat("{0} ({1}) by {2}", album.Title, album.Year, album.Performer.Name).AppendLine()
                .AppendFormat("Genre: {0}, Price: ${1:F2}", album.Genre, album.Price).AppendLine()
                .AppendFormat("Supplies: {0}, Sold: {1}", albumSalesInfo.Supplies, albumSalesInfo.QuantitySold).AppendLine();
            if (album.Songs.Any())
            {
                var songs = album.Songs
                    .Select(s => s.Title + " (" + s.Duration + ")");
                albumInfo
                    .AppendLine("Songs:")
                    .Append(string.Join(Environment.NewLine, songs));
            }
            else
            {
                albumInfo.Append("No songs");
            }

            return albumInfo.ToString();
        }

        private string GetBandReport(IBand band)
        {
            StringBuilder bandInfo = new StringBuilder();
            bandInfo.Append(band.Name + ": ");
            if (band.Members.Any())
            {
                bandInfo.Append(string.Join(", ", band.Members));
            }

            bandInfo.AppendLine();
            if (band.Songs.Any())
            {
                var songs = band.Songs
                  .Select(s => s.Title)
                  .OrderBy(s => s);
                bandInfo.Append(string.Join("; ", songs));
            }
            else
            {
                bandInfo.Append("no songs");
            }

            return bandInfo.ToString();
        }
    }
}
