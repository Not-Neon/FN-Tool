namespace FnTool.Objects;

public class Aes
{
    public string Build { get; set; }
    public string MainKey { get; set; }
    public DynamicAesKey[] DynamicKeys { get; set; }
    public DateTime Updated { get; set; }
}

public class DynamicAesKey
{
    public string PakFilename { get; set; }
    public string PakGuid { get; set; }
    public string Key { get; set; }
}