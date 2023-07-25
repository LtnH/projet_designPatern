using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class RentalManager
{
    private static readonly RentalManager instance = new RentalManager();

    private RentalManager()
    {
        InitializeVideoGames();
    }

    public static RentalManager Instance
    {
        get { return instance; }
    }

    private List<VideoGame> videoGames;

    private void InitializeVideoGames()
    {
        videoGames = new List<VideoGame>
        {
            new VideoGame(1, "Super Game 1", "Action", 2020, true),
            new VideoGame(2, "Adventure Quest", "Adventure", 2019, false),
            new VideoGame(3, "Racing Mania", "Racing", 2021, true),
        };
    }

    public void RentVideoGame(int gameId, int days)
    {
        var videoGame = videoGames.FirstOrDefault(g => g.Id == gameId);
        if (videoGame == null)
        {
            Console.WriteLine("Jeu vidéo non trouvé. Location impossible.");
            return;
        }

        Console.WriteLine($"Le jeu vidéo \"{videoGame.Title}\" a été loué pour {days} jours.");
    }

    public void ReturnVideoGame(int gameId)
    {
        var videoGame = videoGames.FirstOrDefault(g => g.Id == gameId);
        if (videoGame == null)
        {
            Console.WriteLine("Jeu vidéo non trouvé. Retour impossible.");
            return;
        }

        Console.WriteLine($"Le jeu vidéo \"{videoGame.Title}\" a été retourné.");
    }

    public void ExtendRental(int gameId, int daysToAdd)
    {
        var videoGame = videoGames.FirstOrDefault(g => g.Id == gameId);
        if (videoGame == null)
        {
            Console.WriteLine("Jeu vidéo non trouvé. Prolongation impossible.");
            return;
        }

        Console.WriteLine($"La location du jeu vidéo \"{videoGame.Title}\" a été prolongée de {daysToAdd} jours.");
    }
}
