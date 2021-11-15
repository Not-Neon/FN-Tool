namespace FNTool.Objects;

public class ShopIRootobject
{
    public DateTime date { get; set; }
    public DateTime expiration { get; set; }
    public string featuredTitle { get; set; }
    public Page[] featured { get; set; }
    public string dailyTitle { get; set; }
    public Page[] daily { get; set; }
    public string specialFeaturedTitle { get; set; }
    public Page[] specialFeatured { get; set; }
    public string specialDailyTitle { get; set; }
    public object specialDaily { get; set; }
    public object voteWinners { get; set; }
}

public class Page
{
    public int panel { get; set; }
    public Entry[] entries { get; set; }
}

public class Entry
{
    public string offerId { get; set; }
    public int regularPrice { get; set; }
    public int finalPrice { get; set; }
    public bool isBundle { get; set; }
    public bool isGiftable { get; set; }
    public bool isRefundable { get; set; }
    public int sortPriority { get; set; }
    public object banner { get; set; }
    public IItem[] items { get; set; }
}

public class IItem
{
    public string id { get; set; }
    public string path { get; set; }
    public Icons icons { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string shortDescription { get; set; }
    public string backendType { get; set; }
    public string rarity { get; set; }
    public string backendRarity { get; set; }
    public string set { get; set; }
    public string setText { get; set; }
    public ISeries series { get; set; }
    public IVariant[] variants { get; set; }
    public string[] gameplayTags { get; set; }
}

public class Icons
{
    public string icon { get; set; }
    public string featured { get; set; }
    public string series { get; set; }
}

public class ISeries
{
    public string name { get; set; }
}

public class IVariant
{
    public string channel { get; set; }
    public string type { get; set; }
    public IOption[] options { get; set; }
}

public class IOption
{
    public string tag { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public bool startUnlocked { get; set; }
    public bool isDefault { get; set; }
    public bool hideIfNotOwned { get; set; }
}