namespace FNTool.Objects;


public class ShopRootobject
{
    public int status { get; set; }
    public ShopData data { get; set; }
}

public class ShopData
{
    public string hash { get; set; }
    public DateTime updated { get; set; }
    public DateTime date { get; set; }
    public Section[] sections { get; set; }
}

public class Section
{
    public string id { get; set; }
    public string name { get; set; }
    public int quantity { get; set; }
}