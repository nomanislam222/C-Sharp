public interface RadioPlayerInterface
{
    void Switch(bool on);
    void Retune(double frequency);
    void SetVolume(int loudness);
    void ChangeChannel();
}
