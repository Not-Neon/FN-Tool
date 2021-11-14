using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using RestSharp;
using RestSharp.Serialization;

namespace FnTool;

public class JsonNetSerializer : IRestSerializer
{

    internal static readonly JsonSerializerSettings? SerializerSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy(true, false),
        }
    };

    public string ContentType { get; set; } = "application/json";
    public DataFormat DataFormat => DataFormat.Json;

    public string[] SupportedContentTypes { get; } =
    {
        "application/json",
        "application/json; charset=utf"
    };

    public string Serialize(object obj)
    {
        return JsonConvert.SerializeObject(obj, SerializerSettings);
    }

    public string Serialize(Parameter parameter)
    {
        return JsonConvert.SerializeObject(parameter.Value, SerializerSettings);
    }

    public T? Deserialize<T>(IRestResponse response)
    {
        return JsonConvert.DeserializeObject<T>(response.Content, SerializerSettings);
    }

}