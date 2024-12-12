namespace domain
{
    public class Song
    {
        /// <summary>
        /// Title of the song
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Duration of the song in seconds
        /// </summary>
        public required int Duration { get; set; }
    }
}
