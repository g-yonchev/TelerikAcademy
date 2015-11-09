using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ArtistSystem.ConsoleClient
{
	public class Startup
	{
		public static void Main()
		{
			var baseUri = new Uri("http://localhost:61023/");

			GetSongsAsJson(baseUri, "api/albums");
			GetSongsAsXml(baseUri, "api/albums");

			Console.ReadLine();
		}

		private static async void GetSongsAsXml(Uri baseUri, string path)
		{
			using (var httpClient = new HttpClient())
			{
				httpClient.BaseAddress = baseUri;
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

				var response = await httpClient.GetAsync(path);
				Console.WriteLine("Albums: " + await response.Content.ReadAsStringAsync());
			}
		}

		private static async void GetSongsAsJson(Uri baseUri, string path)
		{
			using (var httpClient = new HttpClient())
			{
				httpClient.BaseAddress = baseUri;

				var response = await httpClient.GetAsync(path);
				Console.WriteLine("Songs: " + await response.Content.ReadAsStringAsync());
			}
		}
	}
}
