using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Homework
{
    /// <summary>
    /// Processes RSS to JSON
    /// </summary>
    public class TelerikRssProcessor
    {
        public static void Main()
        {
            var webclient = new WebClient();

            var rssUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var url = "../../base.xml";
            var jsonUrl = "../../base.json";

            webclient.DownloadFile(rssUrl, url);

            var xmlDoc = XDocument.Load(url);

            var json = JsonConvert.SerializeXNode(xmlDoc, Formatting.Indented);

            File.WriteAllText(jsonUrl, json);

            var jsonObj = JObject.Parse(json);

            PrintVideoTitles(jsonObj);

            CreateHtmlPage(jsonObj);

        }

        private static void PrintVideoTitles(JObject jsonObj)
        {
            var videosCollection = jsonObj["feed"]["entry"].Select(entry => entry["title"]);

            Console.WriteLine("Titles of the videos:\n");

            foreach (var title in videosCollection)
            {
                Console.WriteLine(title);
            }
        }

        // Open videos.html from the solution folder
        private static void CreateHtmlPage(JObject jsonObj)
        {
            var template = new { id = string.Empty, title = string.Empty, published = string.Empty };
            var videos = jsonObj["feed"]["entry"].Select(video => JsonConvert.DeserializeAnonymousType(video.ToString(), template));
            var htmlCreator = new StreamWriter("../../videos.html");

            htmlCreator.Write("<html><head><title>Telerik RSS Videos</title><meta charset=\"UTF-8\"></head><body>");

            foreach (var video in videos)
            {
                htmlCreator.WriteLine(
                    "<div style=\"display: inline-block;\"><iframe width=420 height=315 src=\"https://www.youtube.com/embed/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\"></iframe><br />"
                    + "<a style=\"text-decoration: none; font-family: Arial; color: #444;\""
                    + " href=\"https://youtu.be/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\" target=\"_blank\">" + video.title + "</a></div"
                    + ">");
            }

            htmlCreator.Write("</body></html>");
            htmlCreator.Close();
        }
    }
}
