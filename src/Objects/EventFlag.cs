using Newtonsoft.Json;

namespace FNTool.Objects;

public class Rootobject
{
    public Channels channels { get; set; }
    public float cacheIntervalMins { get; set; }
    public DateTime currentTime { get; set; }
}

public class Channels
{
    public StandaloneStore standalonestore { get; set; }

    [JsonProperty("client-events")]
    public ClientEvents clientevents { get; set; }
}

public class StandaloneStore
{
    public DateTime cacheExpire { get; set; }
}

public class ClientEvents
{
    public State10[] states { get; set; }
    public DateTime cacheExpire { get; set; }
}

public class State10
{
    public DateTime validFrom { get; set; }
    public Activeevent1[] activeEvents { get; set; }
}

public class Sectionstoreends
{
    public DateTime DC8B { get; set; }
    public DateTime DC9B { get; set; }
    public DateTime SpookyOffers { get; set; }
    public DateTime SpookyOffers2 { get; set; }
    public DateTime SpookyOffers3 { get; set; }
    public DateTime DC2B { get; set; }
    public DateTime DC3B { get; set; }
    public DateTime DC4B { get; set; }
    public DateTime DC5B { get; set; }
    public DateTime SpookyOffers4 { get; set; }
    public DateTime SpookyOffers5 { get; set; }
    public DateTime DC6B { get; set; }
    public DateTime DC7B { get; set; }
    public DateTime Dune { get; set; }
    public DateTime Featured { get; set; }
    public DateTime Daily { get; set; }
}

public class Activeevent1
{
    public string eventType { get; set; }
    public DateTime activeUntil { get; set; }
    public DateTime activeSince { get; set; }
}