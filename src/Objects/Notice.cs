namespace FNTool.Objects;


public class NoticeRootobject
{
    public int status { get; set; }
    public NoticeDatum[] data { get; set; }
}

public class NoticeDatum
{
    public string title { get; set; }
    public string body { get; set; }
    public object hidden { get; set; }
    public object gamemodes { get; set; }
    public string[] platforms { get; set; }
    public Playlist[] playlists { get; set; }
}

public class Playlist
{
    public string id { get; set; }
    public string name { get; set; }
    public string sub_name { get; set; }
    public string description { get; set; }
    public string game_type { get; set; }
    public object rating { get; set; }
    public int min_players { get; set; }
    public int max_players { get; set; }
    public int max_teams { get; set; }
    public int max_teamSize { get; set; }
    public int max_squadSize { get; set; }
    public object gameplay_tags { get; set; }
    public object image { get; set; }
    public object violator { get; set; }
}