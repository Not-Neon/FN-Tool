namespace FNTool.Objects;

public class BackgroundRootobject
{
    public int status { get; set; }
    public BackgroundData data { get; set; }
}

public class BackgroundData
{
    public Lobby lobby { get; set; }
    public Vault vault { get; set; }
}

public class Lobby
{
    public string name { get; set; }
    public string image { get; set; }
}

public class Vault
{
    public string name { get; set; }
    public object image { get; set; }
}