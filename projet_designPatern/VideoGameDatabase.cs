using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DatabaseVideoGameRepository : IVideoGameRepository
{
    public VideoGame GetById(int id)
    {
        Console.WriteLine("Récupération de du jeux avec l'ID : "  +  id);
        return null;
    }

    public void Save(VideoGame videoGame)
    {
        Console.WriteLine("Enregistrement du jeu vidéo : " +  videoGame.Title);
    }
}