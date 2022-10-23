namespace OnlineRadioDatabase
{ 

public interface ISongValidation
{
    public void Validate();
}

public class ArtistNameValidation : ISongValidation
{
    private const int MinNameLength = 3;
    private const int MaxNameLength = 20;
    private string name;

    public ArtistNameValidation(string name)
    {
        this.name = name;
    }

    public void Validate()
    {
        if (this.name.Length < MinNameLength || this.name.Length > MaxNameLength)
        {
            throw new InvalidArtistNameException(MinNameLength, MaxNameLength);
        }
    }
}

public class SongMinutesValidation : ISongValidation
{
    private const int MinSongMinutes = 0;
    private const int MaxSongMinutes = 14;
    private int minutes;

    public SongMinutesValidation(int minutes)
    {
        this.minutes = minutes;
    }

    public void Validate()
    {
        if (this.minutes < MinSongMinutes || this.minutes > MaxSongMinutes)
        {
            throw new InvalidSongMinutesException(MinSongMinutes, MaxSongMinutes);
        }
    }
}

public class SongNameValidation : ISongValidation
{
    private const int MinNameLength = 3;
    private const int MaxNameLength = 30;
    private string name;

    public SongNameValidation(string name)
    {
        this.name = name;
    }

    public void Validate()
    {
        if (this.name.Length < MinNameLength || this.name.Length > MaxNameLength)
        {
            throw new InvalidSongNameException(MinNameLength, MaxNameLength);
        }
    }
}

  public class SongSecondsValidation : ISongValidation
  {
    private const int MinSongSeconds = 0;
    private const int MaxSongSeconds = 59;
    private int seconds;

    public SongSecondsValidation(int seconds)
    {
        this.seconds = seconds;
    }

    public void Validate()
    {
        if (this.seconds < MinSongSeconds || this.seconds > MaxSongSeconds)
        {
            throw new InvalidSongSecondsException(MinSongSeconds, MaxSongSeconds);
        }
    }
  }
}