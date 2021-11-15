namespace FNTool.Objects;

public class StatRootobject
{
    public int status { get; set; }
    public StatData data { get; set; }
}

public class StatData
{
    public Account account { get; set; }
    public Battlepass battlePass { get; set; }
    public object image { get; set; }
    public Stats stats { get; set; }
}

public class Account
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Battlepass
{
    public int level { get; set; }
    public int progress { get; set; }
}

public class Stats
{
    public All all { get; set; }
}

public class All
{
    public Overall overall { get; set; }
    public Solo solo { get; set; }
    public Duo duo { get; set; }
    public Squad squad { get; set; }
    public Ltm ltm { get; set; }
}

public class Overall
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top3 { get; set; }
    public int top5 { get; set; }
    public int top6 { get; set; }
    public int top10 { get; set; }
    public int top12 { get; set; }
    public int top25 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Solo
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top10 { get; set; }
    public int top25 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Duo
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top5 { get; set; }
    public int top12 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Squad
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top3 { get; set; }
    public int top6 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Ltm
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}