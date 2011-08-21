namespace AnimeRandomizer
{
    /// <summary>
    /// A class to hold details about Anime
    /// </summary>
    public class Anime
    {
        /// <summary>
        /// The name of the Anime
        /// </summary>
        public string Name
        { get; set; }
        /// <summary>
        /// The description of the Anime
        /// </summary>
        public string Description
        { get; set; }
        /// <summary>
        /// Who suggested the Anime
        /// </summary>
        public string SuggestedBy
        { get; set; }
        /// <summary>
        /// The file path to an image of the Anime
        /// </summary>
        public string ImageFilePath
        { get; set; }

        /// <summary>
        /// Whether or not someone already has it available
        /// </summary>
        public bool Available
        { get; set; }

        /// <summary>
        /// Empty constructor, required for serialization to xml
        /// </summary>
// ReSharper disable UnusedMember.Global
        public Anime()
// ReSharper restore UnusedMember.Global
        {}

        /// <summary>
        /// Constructor for Anime objects.
        /// </summary>
        /// <param name="p_name">The name of the Anime</param>
        /// <param name="p_description">The description of the Anime</param>
        /// <param name="p_suggestedBy">Who suggested the Anime</param>
        /// <param name="p_imageFilePath">The file path to an image of the Anime</param>
        public Anime(string p_name, string p_description, string p_suggestedBy, string p_imageFilePath)
        {
            Name = p_name;
            Description = p_description;
            SuggestedBy = p_suggestedBy;
            ImageFilePath = p_imageFilePath;
            Available = false;
        }

        public static int CompareAnimeByName(Anime p_anime1, Anime p_anime2)
        {
            return p_anime1.Name.CompareTo(p_anime2.Name);
        }
    }
}
