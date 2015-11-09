namespace JsonPlaceholderConsumingAlbums.Models
{
	public class Photo
	{
		public int Id { get; set; }
		public int AlbumId { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }

		public override string ToString()
		{
			return $"Url: {this.Url}; Title: {this.Title}";
		}
	}
}
