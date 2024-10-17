public class Ipod : RadioPlayerInterface, MusicPlayerInterface
{
    private MusicFile[] musicFiles;
    private bool isRadioOn;
    private bool isMusicOn;
    private int currentVolume;
    private int currentChannel;

    public Ipod()
    {
        musicFiles = new MusicFile[500];
    }

    public void Switch(bool on)
    {
        isRadioOn = on;
    }

    public void Retune(double frequency){}

    public void SetVolume(int loudness)
    {
        currentVolume = loudness;
    }

    public void ChangeChannel(){}

    public void Play(bool on)
    {
        isMusicOn = on;
    }

    public void PlayNext(){}

    public void PlayPrevious(){}
}
