namespace FnTool.Objects;

public class CreatorCode
{
    public string Code { get; set; }
    public CreatorCodeAccount Account { get; set; }
    public string Status { get; set; }
    public bool Verified { get; set; }
}

public class CreatorCodeAccount
{
    public string Id { get; set; }
    public string Name { get; set; }
}
