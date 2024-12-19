namespace homework_8.Classes;

public class Song
{
    private string name;
    private string author;
    private Song prev;

    public string Name {get => name; set => name = value;}

    public string Author {get => author; set => author = value;}

    public Song Prev {get => prev; set => prev = value;}

    public Song(string name, string author)
    {
        Name = name;
        Author = author;
        Prev = null;
    }
    
    public Song(string name, string author, Song prev)
    {
        Name = name;
        Author = author;
        Prev = null;
    }

    public Song()
    {
        Name = "Неизвестно";
        Author = "Неизвестный";
        Prev = null;
    }
    
    public string Title()
    {
        return $"{name} - {author}";
    }
    
    public override bool Equals(object obj)
    {
        if (obj is Song otherSong)
        {
            return this.name == otherSong.name && this.author == otherSong.author;
        }
        return false;
    }
}