using System;

public class HomeTheaterFacade
{
    private DvdPlayer dvdPlayer;
    private Projector projector;
    private Lights lights;
    private SoundSystem soundSystem;

    public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, Lights lights, SoundSystem soundSystem)
    {
        this.dvdPlayer = dvdPlayer;
        this.projector = projector;
        this.lights = lights;
        this.soundSystem = soundSystem;
    }

    public void PlayMovie(string movie)
    {
        lights.Dim(10);
        soundSystem.On();
        soundSystem.SetVolume(5);
        projector.On();
        projector.SetInput("DVD");
        dvdPlayer.SetMovie(movie);
        dvdPlayer.Play();
        Console.WriteLine($"Playing movie: {movie}");
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        dvdPlayer.Stop();
        projector.Off();
        soundSystem.Off();
        lights.On();
    }
}