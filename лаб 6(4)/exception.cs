namespace OnlineRadioDatabase
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private int minNameLength;
        private int maxNameLength;

        public InvalidArtistNameException(int minNameLength, int maxNameLength)
        {
            this.minNameLength = minNameLength;
            this.maxNameLength = maxNameLength;
        }

        public override string Message => $"Artist name should be between {this.minNameLength} and {this.maxNameLength} symbols.";
    }

    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }

    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }

    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private int minSongMinutes;
        private int maxSongMinutes;

        public InvalidSongMinutesException(int minSongMinutes, int maxSongMinutes)
        {
            this.minSongMinutes = minSongMinutes;
            this.maxSongMinutes = maxSongMinutes;
        }

        public override string Message => $"Song minutes should be between {this.minSongMinutes} and {this.maxSongMinutes}.";
    }

    public class InvalidSongNameException : InvalidSongException
    {
        private int minNameLength;
        private int maxNameLength;

        public InvalidSongNameException(int minNameLength, int maxNameLength)
        {
            this.minNameLength = minNameLength;
            this.maxNameLength = maxNameLength;
        }

        public override string Message => $"Song name should be between {this.minNameLength} and {this.maxNameLength} symbols.";
    }

    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private int minSongSeconds;
        private int maxSongSeconds;

        public InvalidSongSecondsException(int minSongSeconds, int maxSongSeconds)
        {
            this.minSongSeconds = minSongSeconds;
            this.maxSongSeconds = maxSongSeconds;
        }

        public override string Message => $"Song seconds should be between {this.minSongSeconds} and {this.maxSongSeconds}.";
    }
}