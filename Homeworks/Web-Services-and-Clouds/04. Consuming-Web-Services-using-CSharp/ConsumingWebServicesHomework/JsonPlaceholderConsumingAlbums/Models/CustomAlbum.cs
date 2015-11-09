namespace JsonPlaceholderConsumingAlbums.Models
{
	using System.Collections.Generic;
	using System.Text;

	public class CustomAlbum
	{
		public string Title { get; set; }
		public string Creator { get; set; }
		public int NumberOfPhotos { get; set; }
		public IEnumerable<Photo> Photos { get; set; }

		public override string ToString()
		{
			var result = new StringBuilder();
			result.AppendLine($"Album title: {this.Title}");
			result.AppendLine($" -by {this.Creator}-");
			result.AppendLine($"Photos: {this.NumberOfPhotos}");
			foreach (var photo in this.Photos)
			{
				result.AppendLine($" -- {photo.ToString()}");
			}

			return result.ToString();
		}
	}
}
