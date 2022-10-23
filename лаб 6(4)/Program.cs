using OnlineRadioDatabase;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string Artist
        {
            get => this.artist;
            private set
            {
                this.ValidateSong(new ArtistNameValidation(value));
                this.artist = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.ValidateSong(new SongNameValidation(value));
                this.name = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            private set
            {
                this.ValidateSong(new SongMinutesValidation(value));
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            private set
            {
                this.ValidateSong(new SongSecondsValidation(value));
                this.seconds = value;
            }
        }

        private void ValidateSong(ISongValidation validation)
        {
            validation.Validate();
        }
    }

    public class Playlist
    {
        private List<Song> songs;
        private int hours;
        private int minutes;
        private int seconds;

        public Playlist()
        {
            this.songs = new List<Song>();
            this.hours = 0;
            this.minutes = 0;
            this.seconds = 0;
        }

        public void AddSong(Song song)
        {
            this.songs.Add(song);
            this.minutes += song.Minutes;
            this.seconds += song.Seconds;
            Console.WriteLine("Song added.");
        }

        public override string ToString()
        {
            this.CalculateLength();
            var sb = new StringBuilder();
            sb.AppendLine($"Songs added: {this.songs.Count}");
            sb.Append($"Playlist length: {this.hours}h {this.minutes}m {this.seconds}s");

            return sb.ToString();
        }

        private void CalculateLength()
        {
            var totalLengthInSeconds = this.seconds + (this.minutes * 60) + (this.hours * 60 * 60);
            var timespan = TimeSpan.FromSeconds(totalLengthInSeconds);
            this.hours = timespan.Hours;
            this.minutes = timespan.Minutes;
            this.seconds = timespan.Seconds;
        }
    }
}