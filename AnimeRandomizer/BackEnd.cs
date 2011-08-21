using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AnimeRandomizer
{
    /// <summary>
    /// The backend for AnimeRandomizer. Is as general as possible to allow different front-ends
    /// Handles:
    /// - loading and storing of a database of Anime
    /// - randomly selecting an Anime from this list
    /// - adding Anime to the database
    /// - saving the database
    /// </summary>
    public static class BackEnd
    {
        static readonly Random Rand = new Random();

        /// <summary>
        /// A List to store Anime information in.
        /// </summary>
        private static List<Anime> animeList = new List<Anime>();

        public static List<Anime> AnimeList
        {
            get
            {
                return animeList;
            }
        }

        private const string c_emptyDatabaseString = "Database is empty.";
        private static readonly Anime EmptyDatabase = new Anime(c_emptyDatabaseString, c_emptyDatabaseString, c_emptyDatabaseString, c_emptyDatabaseString);

        /// <summary>
        /// Returns the number of Anime loaded. Looks better than AnimeList().Count
        /// </summary>
        public static int AnimeListLength
        {
            get
            {
                return animeList.Count;
            }
        }

        /// <summary>
        /// Chooses an Anime from animeList
        /// </summary>
        /// <returns>string containing the name of the Anime to watch</returns>
        public static Anime SelectAnime()
        {
            if (AnimeListLength > 0)
            {
                return animeList[Rand.Next(AnimeListLength)];
            }

            return EmptyDatabase;
        }

        /// <summary>
        /// Adds an Anime to animeList
        /// </summary>
        /// <param name="p_animeName">The name of the Anime to add</param>
        /// <param name="p_animeDescription">The description of the anime to add</param>
        /// <param name="p_animeSuggestedBy">Who suggested the anime</param>
        /// <param name="p_animeImageFilePath">The filepath to an image of the anime</param>
        public static void AddAnime(string p_animeName, string p_animeDescription, string p_animeSuggestedBy, string p_animeImageFilePath)
        {
            animeList.Add(new Anime(p_animeName, p_animeDescription, p_animeSuggestedBy, p_animeImageFilePath));
            
            animeList.Sort(Anime.CompareAnimeByName);
        }

        public static void RemoveAnime(int p_animeIndex)
        {
            animeList.RemoveAt(p_animeIndex);
        }

        /// <summary>
        /// Loads Anime into animeList from a file
        /// </summary>
        /// <param name="p_fileLocation">The location of the Anime list file to load from</param>
        /// <returns>true if load succeeded, false if it failed</returns>
        public static bool LoadAnimeXML(string p_fileLocation)
        {
            if (File.Exists(p_fileLocation))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Anime>));
                StreamReader streamReader = new StreamReader(p_fileLocation);
                animeList = (List<Anime>)deserializer.Deserialize(streamReader);
                streamReader.Close();

                animeList.Sort(Anime.CompareAnimeByName);

                return true;
            }
            return false;
        }

/*
        /// <summary>
        /// Loads Anime into animeList from a file
        /// </summary>
        /// <param name="p_fileLocation">The location of the Anime list file to load from</param>
        /// <returns>true if load succeeded, false if it failed</returns>
        public static void LoadAnimeText(string p_fileLocation)
        {
            StreamReader streamReader = new StreamReader(p_fileLocation);
            while (!streamReader.EndOfStream)
            {
                string animeName = streamReader.ReadLine();
                animeList.Add(new Anime(animeName, "", "", ""));
            }
            
            streamReader.Close();

            animeList.Sort(Anime.CompareAnimeByName);
        }
*/

        /// <summary>
        /// Saves animeList to a file
        /// </summary>
        /// <param name="p_fileLocation">The location of the Anime list file to save to</param>
        public static void SaveAnime(string p_fileLocation)
        {
            animeList.Sort(Anime.CompareAnimeByName);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Anime>));
            StreamWriter streamWriter = new StreamWriter(p_fileLocation);
            serializer.Serialize(streamWriter, animeList);
            streamWriter.Close();
        }
    }
}