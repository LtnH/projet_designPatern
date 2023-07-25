using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Modèle-vue-contrôleur
public class VideoGame
{
    public VideoGame(int id, string title, string genre, int releaseYear, bool multiplayerEnabled)
    {
        Id = id;
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        MultiplayerEnabled = multiplayerEnabled;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public bool MultiplayerEnabled { get; set; }
}