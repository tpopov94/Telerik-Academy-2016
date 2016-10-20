using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace JSON.NET
{
    public class XMLParser
    {
        private const int MaxAlbumPrice = 20;
        private const string path = "../../catalogue.xml";

        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Task Two
            PrintArtistFromCatalogue(doc);
            Console.WriteLine(new string('-', 60));

            // Task Three
            PrintArtistFromCatalogueXPath(doc);
            Console.WriteLine(new string('-', 60));

            // TaskFour
            RemoveExpensiveAlbums(doc);
            Console.WriteLine(new string('-', 60));

            // TaskFive
            ExtractSongTitlesXReader();
            Console.WriteLine(new string('-', 60));

            // TaskSix
            ExtractSongTitlesLinq();
            Console.WriteLine(new string('-', 60));
        }


        private static void PrintArtistFromCatalogue(XmlDocument doc)
        {
            XmlNode root = doc.DocumentElement;
            var albums = new Hashtable();

            foreach (XmlElement album in root.ChildNodes)
            {
                if (albums.ContainsKey(album["artist"].InnerText))
                {
                    (albums[album["artist"].InnerText] as List<string>).Add(album["name"].InnerText);
                }
                else
                {
                    albums.Add(album["artist"].InnerText, new List<string> { album["name"].InnerText });
                }
            }

            foreach (var key in albums.Keys)
            {
                Console.WriteLine($"{key} Number of albums: {(albums[key] as List<string>).Count}");
            }
        }

        private static void PrintArtistFromCatalogueXPath(XmlDocument doc)
        {
            XmlNode root = doc.DocumentElement;
            var albums = new Hashtable();

            foreach (XmlElement album in root.ChildNodes)
            {
                if (albums.ContainsKey(album["artist"].InnerText))
                {
                    (albums[album["artist"].InnerText] as List<string>).Add(album["name"].InnerText);
                }
                else
                {
                    albums.Add(album["artist"].InnerText, new List<string> { album["name"].InnerText });
                }
            }

            foreach (var key in albums.Keys)
            {
                Console.WriteLine($"{key} Number of albums: {(albums[key] as List<string>).Count}");
            }
        }

        private static void RemoveExpensiveAlbums(XmlDocument doc)
        {
            XmlNode root = doc.DocumentElement;
            bool removeNode = false;

            foreach (XmlElement album in root.ChildNodes)
            {
                var albumPrice = double.Parse(album["price"].InnerText);

                if (removeNode)
                {
                    root.RemoveChild(album.PreviousSibling);
                    removeNode = false;
                }

                if (albumPrice > MaxAlbumPrice)
                {
                    removeNode = true;
                }
            }

            if (removeNode)
            {
                root.RemoveChild(root.LastChild);
            }

            foreach (XmlElement album in root.ChildNodes)
            {
                Console.WriteLine($"{album["name"].InnerText} - Price: {album["price"].InnerText}");
            }
        }

        private static void ExtractSongTitlesXReader()
        {
            int id = 1;

            Console.WriteLine("Songs in the albums library:");

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                            (reader.Name == "title"))
                    {
                        Console.WriteLine($"{id++}. {reader.ReadElementContentAsString()}");
                    }
                }
            }
        }

        private static void ExtractSongTitlesLinq()
        {
            int id = 1;
            var doc = XDocument.Load(path);

            Console.WriteLine("Songs in the albums library with LINQ:");

            var songsAlbum = from songs in doc.Descendants("title") select songs.Element("title").Value;

            foreach (var song in songsAlbum)
            {
                Console.WriteLine($"{id++}. {song}");
            }
        }
    }
}
