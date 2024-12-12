using domain;

namespace application
{
    public static class AlbumManager
    {
        private static List<Album> albums = [];

        public static void Init()
        {
            // create the Thriller album from Mickael Jackson
            var thriller = new Album() { Artist = "Michael Jackson", Title = "Thriller", Year = 1982 };
            thriller.AddSong(new Song() { Title = "Wanna Be Startin' Somethin'", Duration = 386 });
            thriller.AddSong(new Song() { Title = "Baby Be Mine", Duration = 244 });
            thriller.AddSong(new Song() { Title = "The Girl Is Mine", Duration = 232 });
            thriller.AddSong(new Song() { Title = "Thriller", Duration = 358 });
            thriller.AddSong(new Song() { Title = "Beat It", Duration = 258 });
            thriller.AddSong(new Song() { Title = "Billie Jean", Duration = 292 });
            thriller.AddSong(new Song() { Title = "Human Nature", Duration = 242 });
            thriller.AddSong(new Song() { Title = "P.Y.T. (Pretty Young Thing)", Duration = 230 });
            thriller.AddSong(new Song() { Title = "The Lady in My Life", Duration = 270 });
            albums.Add(thriller);

            // create the Back in Black album from AC/DC
            var backInBlack = new Album() { Artist = "AC/DC", Title = "Back in Black", Year = 1980 };
            backInBlack.AddSong(new Song() { Title = "Hells Bells", Duration = 312 });
            backInBlack.AddSong(new Song() { Title = "Shoot to Thrill", Duration = 350 });
            backInBlack.AddSong(new Song() { Title = "What Do You Do for Money Honey", Duration = 203 });
            backInBlack.AddSong(new Song() { Title = "Given the Dog a Bone", Duration = 210 });
            backInBlack.AddSong(new Song() { Title = "Let Me Put My Love into You", Duration = 274 });
            backInBlack.AddSong(new Song() { Title = "Back in Black", Duration = 255 });
            backInBlack.AddSong(new Song() { Title = "You Shook Me All Night Long", Duration = 210 });
            backInBlack.AddSong(new Song() { Title = "Have a Drink on Me", Duration = 229 });
            backInBlack.AddSong(new Song() { Title = "Shake a Leg", Duration = 242 });
            backInBlack.AddSong(new Song() { Title = "Rock and Roll Ain't Noise Pollution", Duration = 352 });
            albums.Add(backInBlack);
        }
    }
}
