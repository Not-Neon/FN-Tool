using Newtonsoft.Json;

namespace FNTool.Objects;

public class ServerRootobject
{
    public int status { get; set; }
    public ServerData data { get; set; }
}

public class ServerData
{
    [JsonProperty("devplaytest-prod12")]
    public DevplaytestProd12 devplaytestprod12 { get; set; }
    [JsonProperty("releaseplaytest-prod")]
    public ReleaseplaytestProd releaseplaytestprod { get; set; }
    public Stage stage { get; set; }
    [JsonProperty("extqareleasetestingb-prod")]
    public ExtqareleasetestingbProd extqareleasetestingbprod { get; set; }
}

public class DevplaytestProd12
{
    public string app { get; set; }
    public DateTime serverDate { get; set; }
    public string overridePropertiesVersion { get; set; }
    public string cln { get; set; }
    public string build { get; set; }
    public string moduleName { get; set; }
    public DateTime buildDate { get; set; }
    public string version { get; set; }
    public string branch { get; set; }
}

public class ReleaseplaytestProd
{
    public string app { get; set; }
    public DateTime serverDate { get; set; }
    public string overridePropertiesVersion { get; set; }
    public string cln { get; set; }
    public string build { get; set; }
    public string moduleName { get; set; }
    public DateTime buildDate { get; set; }
    public string version { get; set; }
    public string branch { get; set; }
}

public class Stage
{
    public string app { get; set; }
    public DateTime serverDate { get; set; }
    public string overridePropertiesVersion { get; set; }
    public string cln { get; set; }
    public string build { get; set; }
    public string moduleName { get; set; }
    public DateTime buildDate { get; set; }
    public string version { get; set; }
    public string branch { get; set; }
}

public class ExtqareleasetestingbProd
{
    public string app { get; set; }
    public DateTime serverDate { get; set; }
    public string overridePropertiesVersion { get; set; }
    public string cln { get; set; }
    public string build { get; set; }
    public string moduleName { get; set; }
    public DateTime buildDate { get; set; }
    public string version { get; set; }
    public string branch { get; set; }
}