namespace JsonPlaceholderConsumingAlbums
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net.Http;

	using Newtonsoft.Json;

	using Models;

	public class Startup
	{
		private static int albumsCount;
		private static string queryString;

        public static async void GetAlbums(HttpClient httpClient)
		{
			var responseAlbums = await httpClient.GetAsync("albums");
			var textAlbums = responseAlbums.Content.ReadAsStringAsync().Result;
			var jsonsAlbums = JsonConvert.DeserializeObject<List<Album>>(textAlbums);
			var filteredAlbums = jsonsAlbums.Where(x => x.Title.Contains(queryString)).Take(albumsCount);
			
			var responseUsers = await httpClient.GetAsync("users");
			var textUsers = responseUsers.Content.ReadAsStringAsync().Result;
			var jsonUsers = JsonConvert.DeserializeObject<List<User>>(textUsers);

			var responsePhotos = await httpClient.GetAsync("photos");
			var textPhotos = responsePhotos.Content.ReadAsStringAsync().Result;
			var jsonPhotos = JsonConvert.DeserializeObject<List<Photo>>(textPhotos);

			var listOfCustomAlbums = new List<CustomAlbum>();
			
			foreach (var album in filteredAlbums)
			{
				var photos = jsonPhotos.Where(x => x.AlbumId == album.Id).ToList();
				var userName = jsonUsers.Where(x => x.Id == album.UserId).FirstOrDefault().Name;

				var currentAlbum = new CustomAlbum
				{
					Title = album.Title,
					Creator = userName,
					NumberOfPhotos = photos.Count(),
					Photos = photos
				};

				listOfCustomAlbums.Add(currentAlbum);
            }

			Console.WriteLine("Albums:");
			if (listOfCustomAlbums.Count() == 0)
			{
				Console.WriteLine("No albums to preview");
			}
			else
			{
				Console.WriteLine(string.Join(Environment.NewLine, listOfCustomAlbums));
			}
			
			Console.WriteLine();
		}

		static void Main()
		{
			var httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com");

			Console.WriteLine("Insert numbers of albums:");
			albumsCount = int.Parse(Console.ReadLine());

			Console.WriteLine("Insert query string:");
			queryString = Console.ReadLine();

			GetAlbums(httpClient);

			Console.WriteLine("Please wait...");
			Console.ReadLine();
		}
	}
}
