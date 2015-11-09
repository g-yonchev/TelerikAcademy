namespace JsonPlaceholderConsumingAlbums.Models
{
	public class Album
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; }

		public override string ToString()
		{
			return this.Title;
		}
	}
}
