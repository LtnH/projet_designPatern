// Singleton
using System;



public class Program
{
    public static void Main()
    {
        var rentalManager = RentalManager.Instance;

        var gameBuilder = new VideoGameBuilder("Super Game")
            .WithGenre("Action")
            .ReleasedInYear(2020)
            .WithMultiplayer(true)
            .WithID(5);
        var videoGame = gameBuilder.Build();

        Console.WriteLine($"Jeu vidéo créé : {videoGame.Title}, Genre : {videoGame.Genre}, Année : {videoGame.ReleaseYear}, Multijoueur : {videoGame.MultiplayerEnabled}");

        while (true) {
            Console.Write("Entrez l'ID du jeu vidéo à louer : ");
            if (int.TryParse(Console.ReadLine(), out int gameId))
            {
                Console.Write("Entrez le nombre de jours de location : ");
                if (int.TryParse(Console.ReadLine(), out int days))
                {
                    IPriceCalculationStrategy strategy = new WeekendPriceCalculationStrategy();
                    decimal price = strategy.CalculatePrice(days);

                    Console.WriteLine($"Prix de location pour {days} jours : {price} $");

                    rentalManager.RentVideoGame(gameId, days);

                    Console.Write("Entrez l'ID du jeu vidéo à retourner : ");
                    if (int.TryParse(Console.ReadLine(), out int gameIdToReturn))
                    {
                        rentalManager.ReturnVideoGame(gameIdToReturn);

                        Console.Write("Entrez l'ID du jeu vidéo à prolonger la location : ");
                        if (int.TryParse(Console.ReadLine(), out int gameIdToExtend))
                        {
                            Console.Write("Entrez le nombre de jours à ajouter pour la prolongation : ");
                            if (int.TryParse(Console.ReadLine(), out int daysToAdd))
                            {
                                rentalManager.ExtendRental(gameIdToExtend, daysToAdd);
                            }
                            else
                            {
                                Console.WriteLine("Nombre de jours invalide.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID de jeu vidéo pour la prolongation invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID de jeu vidéo à retourner invalide.");
                    }
                }
                else
                {
                    Console.WriteLine("Nombre de jours invalide.");
                }
            }
            else
            {
                Console.WriteLine("ID de jeu vidéo à louer invalide.");
            }
        }
    }
}
