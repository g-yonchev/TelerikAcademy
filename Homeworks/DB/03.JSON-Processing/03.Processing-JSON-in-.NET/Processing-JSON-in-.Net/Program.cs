namespace Processing_JSON_in_.Net
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }

    public class MediaThumbnail
    {
        [JsonProperty("@url")]
        public string Url { get; set; }
    }

    public class MediaStatistics
    {
        [JsonProperty("@views")]
        public string Views { get; set; }
    }

    public class MediaCommunity
    {
        [JsonProperty("media:statistics")]
        public MediaStatistics Statistics { get; set; }
    }

    public class MediaGroup
    {
        [JsonProperty("media:description")]
        public string Description { get; set; }

        [JsonProperty("media:thumbnail")]
        public MediaThumbnail МediaТhumbnail { get; set; }

        [JsonProperty("media:community")]
        public MediaCommunity Community { get; set; }
    }

    public class Entry
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("media:group")]
        public MediaGroup Group { get; set; }
    }

    public class Feed
    {
        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("entry")]
        public List<Entry> Entry { get; set; }
    }

    public class TelerikAcademyVideos
    {
        [JsonProperty("feed")]
        public Feed Feed { get; set; }
    }

    public class Video
    {
        public Video(string title, string link, DateTime publishedDate, string description, int views, string img)
        {
            this.Title = title;
            this.Link = link;
            this.PublishedDate = publishedDate;
            this.Description = description;
            this.Views = views;
            this.Img = img;
        }

        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public string Img { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Download youtube videos
            string file = @"../../videos.xml";
            string rrsVideosFile = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            WebClient webClient = new WebClient();
            webClient.DownloadFile(rrsVideosFile, file);
            XmlDocument document = new XmlDocument();
            document.Load(file);

            // Converting to JSON
            string json = JsonConvert.SerializeXmlNode(document);
            JObject jsonObj = JObject.Parse(json);

            var videosJson = jsonObj["feed"]["entry"];

            var titles = videosJson.Select(v => v["title"]);

            foreach (var title in titles)
            {
                Console.WriteLine("Video title: " + title);
            }

            var deserializedVideos = JsonConvert.DeserializeObject<TelerikAcademyVideos>(json);

            var videos = new List<Video>();

            var countVideos = deserializedVideos.Feed.Entry.Count;

            // All deserialized videos to be added in new list
            for (int i = 0; i < countVideos; i++)
            {
                var currentVideo = deserializedVideos.Feed.Entry[i];

                string title = currentVideo.Title;
                string description = currentVideo.Group.Description;
                string link = currentVideo.Link.Href;
                DateTime publishedDate = DateTime.Parse(currentVideo.Published);
                int views = int.Parse(currentVideo.Group.Community.Statistics.Views);
                string img = currentVideo.Group.МediaТhumbnail.Url;

                var video = new Video(title, link, publishedDate, description, views, img);
                videos.Add(video);
            }

            // HTML generete
            string html = @"<!DOCTYPE html>
                            <html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
                            <head>
                                <meta charset=""utf-8"" />
                                <title>Video</title>
                            </head>
                            <body>";

            foreach (var video in videos)
            {
                html += string.Format("<div><a href=\"{0}\" target=\"_blank\"><img src=\"{1}\" width=\"60\" height=\"60\" />{2}</a><span> (Views: {3})</span> <span> Published on: {4}</span></div>", video.Link, video.Img, video.Title, video.Views, video.PublishedDate);
            }

            html += "</body></html>";

            File.WriteAllText("../../index.html", html);
        }
    }
}
