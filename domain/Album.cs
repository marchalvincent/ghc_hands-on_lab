namespace domain
{
    public class Album
    {
        /// <summary>
        /// Title of the album
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Artist of the album
        /// </summary>
        public required string Artist { get; set; }

        /// <summary>
        /// Publish year of the album
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// List of songs in the album
        /// </summary>
        public IEnumerable<Song> Songs
        {
            get
            {
                return _songs;
            }
        }

        public int SongNumber => _songs.Count;
        public int Duration => _songs.Sum(s => s.Duration);

        private List<Song> _songs { get; set; } = new();

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            _songs.Remove(song);
        }
    }
}
