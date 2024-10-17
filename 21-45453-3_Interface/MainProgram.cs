class Program
{
    static void Main()
    {
        Ipod ipod = new Ipod();
        ipod.Switch(true);
        ipod.Retune(101.5);
        ipod.SetVolume(50);
        ipod.ChangeChannel();

        ipod.Play(true);
        ipod.PlayNext();
        ipod.PlayPrevious();
    }
}
