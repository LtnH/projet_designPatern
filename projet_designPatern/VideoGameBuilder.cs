using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Builder
public class VideoGameBuilder
{
    private int id;
    private string title;
    private string genre;
    private int releaseYear;
    private bool multiplayerEnabled;

    public VideoGameBuilder(string title)
    {
        this.title = title;
    }

    public VideoGameBuilder WithGenre(string genre)
    {
        this.genre = genre;
        return this;
    }

    public VideoGameBuilder ReleasedInYear(int year)
    {
        this.releaseYear = year;
        return this;
    }

    public VideoGameBuilder WithMultiplayer(bool multiplayer)
    {
        this.multiplayerEnabled = multiplayer;
        return this;
    }

    public VideoGameBuilder WithID(int id)
    {
        this.id = id;
        return this;
    }

    public VideoGame Build()
    {
        return new VideoGame(id, title, genre, releaseYear, multiplayerEnabled);
    }
}

