using System;

public interface IActionResult
{
    void Execute();
}

public class NotFoundResult : IActionResult
{
    public void Execute()
    {
        Console.WriteLine("Ressource non trouvée (404 Not Found).");
    }
}

public class OkResult : IActionResult
{
    private readonly VideoGame videoGame;

    public OkResult(VideoGame videoGame)
    {
        this.videoGame = videoGame;
    }

    public void Execute()
    {
        Console.WriteLine($"Jeu vidéo trouvé : {videoGame.Title}, Genre : {videoGame.Genre}, Année : {videoGame.ReleaseYear}, Multijoueur : {videoGame.MultiplayerEnabled}");
    }
}
