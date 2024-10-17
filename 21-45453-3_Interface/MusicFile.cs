public class MusicFile
{
    private string title;
    private string artist;
    private int yearOfRelease;
    private int durationInSeconds;

    public MusicFile(){}

    public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
    {
        this.title = title;
        this.artist = artist;
        this.yearOfRelease = yearOfRelease;
        this.durationInSeconds = durationInSeconds;
    }

    public void ChangeTitle(string title)
    {
        this.title = title;
    }
}
