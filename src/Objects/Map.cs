namespace FNTool.Objects;


public class MapRootobject
{
    public int status { get; set; }
    public MapData data { get; set; }
}

public class MapData
{
    public MapImages images { get; set; }
    public Pois[] pois { get; set; }
}

public class MapImages
{
    public string blank { get; set; }
    public string pois { get; set; }
}

public class Pois
{
    public string id { get; set; }
    public string name { get; set; }
    public Location location { get; set; }
}

public class Location
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}
