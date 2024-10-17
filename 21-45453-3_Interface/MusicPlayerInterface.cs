public interface MusicPlayerInterface
{
    void Switch(bool on);
    void Play(bool on);
    void SetVolume(int loudness);
    void PlayNext();
    void PlayPrevious();
}
