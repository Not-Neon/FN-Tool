namespace FNTool.Objects;

public class PlaylistsRootobject
{
    public int status { get; set; }
    public Datum[] data { get; set; }
}

public class Datum
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
    public string image { get; set; }
    public object violator { get; set; }
}