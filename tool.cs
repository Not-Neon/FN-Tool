using System;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;

namespace FN_Tool_CSharp
{
    // FOR API IN METHOD "AES" !!!

    public class AESRootobject
    {
        public int status { get; set; }
        public AESData data { get; set; }
    }

    public class AESData
    {
        public string build { get; set; }
        public string mainKey { get; set; }
        public Dynamickey[] dynamicKeys { get; set; }
        public DateTime updated { get; set; }
    }

    public class Dynamickey
    {
        public string pakFilename { get; set; }
        public string pakGuid { get; set; }
        public string key { get; set; }
    }



    // FOR API IN METHOD "Cosmetics" !!!
    public class CosmeticsRootobject
    {
        public int status { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string build { get; set; }
        public string previousBuild { get; set; }
        public DateTime date { get; set; }
        public DateTime lastAddition { get; set; }
        public Item[] items { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Type type { get; set; }
        public Rarity rarity { get; set; }
        public Series series { get; set; }
        public Set set { get; set; }
        public Introduction introduction { get; set; }
        public Images images { get; set; }
        public Variant[] variants { get; set; }
        public object searchTags { get; set; }
        public string[] gameplayTags { get; set; }
        public object metaTags { get; set; }
        public string showcaseVideo { get; set; }
        public string dynamicPakId { get; set; }
        public string itemPreviewHeroPath { get; set; }
        public object displayAssetPath { get; set; }
        public string definitionPath { get; set; }
        public string path { get; set; }
        public DateTime added { get; set; }
        public DateTime[] shopHistory { get; set; }
        public string[] builtInEmoteIds { get; set; }
    }

    public class Type
    {
        public string value { get; set; }
        public string displayValue { get; set; }
        public string backendValue { get; set; }
    }

    public class Rarity
    {
        public string value { get; set; }
        public string displayValue { get; set; }
        public string backendValue { get; set; }
    }

    public class Series
    {
        public string value { get; set; }
        public string image { get; set; }
        public string backendValue { get; set; }
    }

    public class Set
    {
        public string value { get; set; }
        public string text { get; set; }
        public string backendValue { get; set; }
    }

    public class Introduction
    {
        public string chapter { get; set; }
        public string season { get; set; }
        public string text { get; set; }
        public int backendValue { get; set; }
    }

    public class Images
    {
        public string smallIcon { get; set; }
        public string icon { get; set; }
        public string featured { get; set; }
        public Other other { get; set; }
    }

    public class Other
    {
        public string background { get; set; }
        public string coverart { get; set; }
    }

    public class Variant
    {
        public string channel { get; set; }
        public string type { get; set; }
        public Option[] options { get; set; }
    }

    public class Option
    {
        public string tag { get; set; }
        public string name { get; set; }
        public string image { get; set; }
    }



    // FOR API IN METHOD "EventFlag" !!!
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


    // JSON CLASSES END HERE !!!

    // MAIN PROGRAM STARTS HERE !!!

    class Program
    {
        static void AES()
        {
            Console.Title = "FN AES Grabber C#";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://fortnite-api.com/v2/aes";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<AESRootobject>(jsonResponse.Content);

            if (json != null)
            {
                    Console.WriteLine($"\nServer Status: {json.status} ");
                    Console.WriteLine($"Build: {json.data.build}");
                    Console.WriteLine($"API Last Updated: {json.data.updated}");
                    int pakchunkCount = 0;
                    foreach (var key in json.data.dynamicKeys)
                    {
                        pakchunkCount = pakchunkCount + 1;
                        Console.WriteLine($"\n{key.pakFilename}: Guid = {key.pakGuid}\n{key.pakFilename}: AES Key = {key.key}");
                    }

                    Console.WriteLine($"\n\nTotal Pakchunks: {pakchunkCount}");
            }

        }
        static void Cosmetics()
        {
            Console.Title = "FN New Cosmetics ID C#";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://fortnite-api.com/v2/cosmetics/br/new";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<CosmeticsRootobject>(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine($"\nServer Status: {json.status}");
                Console.WriteLine($"Date Today: {json.data.date}");
                Console.WriteLine($"Last Addition to API: {json.data.lastAddition}");
                Console.WriteLine($"Previous Build: {json.data.previousBuild}");
                Console.WriteLine($"Current Build: {json.data.build}\n");

                int itemcount = 0;
                foreach (var item in json.data.items)
                {
                    itemcount = itemcount + 1;
                    var ID = item.id;
                    var Name = item.name;
                    var Desc = item.description;
                    var Rarity = item.rarity.displayValue;
                    var BackendRarity = item.rarity.backendValue;
                    var Icon = item.images.icon;
                    Console.WriteLine($"\nItem Name = {Name}\nID = {ID}\nItem Description = {Desc}\nDisplay Rarity = {Rarity}\nBack End Rarity = {BackendRarity}\nDate Added = {item.added}");

                    if (item.dynamicPakId != null)
                    {
                        var PakID = item.dynamicPakId;
                        Console.WriteLine($"Dynamic Pakchunk ID = {PakID}");
                    }
                    if (item.variants != null)
                    {
                        foreach (var variants in item.variants)
                        {
                            foreach (var option in variants.options)
                            {
                                Console.WriteLine($"Variants = {option.tag} --> {option.name}");
                            }
                        }
                    }
                    if (item.shopHistory != null)
                    {
                        foreach (var history in item.shopHistory)
                        {
                            Console.WriteLine($"Item Shop History = {history}");
                        }
                    }
                    if (item.set != null)
                    {
                        var set1 = item.set.value;
                        var set2 = item.set.text;
                        Console.WriteLine($"Part of set = {set1}, {set2}");
                    }
                }
                Console.WriteLine($"\nTotal cosmetics added in {json.data.build} --> {itemcount}");
            }
        }
        static void Notice()
        {
            Console.Title = "FN Emergency Notice Update C#";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://fn-api.com/api/emergencyNotices";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = "[" + jsonResponse.Content + "]";

            dynamic json = JsonConvert.DeserializeObject(jsonResponse.Content);

            if (json != null)
            {
                foreach (var data in json)
                {
                    Console.WriteLine($"\nServer Status: {data.status}\n");

                    if (data.data == null)
                    {
                        Console.WriteLine("No Emergency Notice update currently available.");
                    }
                    else if (data.data != null)
                    {
                        foreach (var notice in data.data)
                        {
                            Console.WriteLine($"Gamemode: {notice.gamemodes[0]}");
                            Console.WriteLine($"Hidden (bool true or false): {notice.hidden}");
                            Console.WriteLine($"Playlist: {notice.playlists[0]}");
                            Console.WriteLine($"\nEmergency Notice Title: {notice.title}");
                            Console.WriteLine($"Emergency Notice Message: {notice.body}");
                        }
                    }
                }
            }
        }
        static void Files()
        {
            Console.Title = "FN New/Removed Files Grabber C#";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://benbot.app/api/v1/files/added";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = "[" + jsonResponse.Content + "]";

            dynamic json = JsonConvert.DeserializeObject(jsonResponse.Content);

            if (json != null)
            {
                foreach (var file in json)
                {
                    Console.WriteLine("\nAdded Files in Current Build: \n");
                    Console.WriteLine(file);
                }
            }

            string apiRemoved = "https://benbot.app/api/v1/files/removed";
            RestClient clientRemoved = new RestClient(apiRemoved);
            IRestRequest jsonRequestRemoved = new RestRequest();
            IRestResponse jsonResponseRemoved = clientRemoved.Execute(jsonRequestRemoved);
            jsonResponseRemoved.Content = "[" + jsonResponseRemoved.Content + "]";

            dynamic jsonRemoved = JsonConvert.DeserializeObject(jsonResponseRemoved.Content);

            if (jsonRemoved != null)
            {
                foreach (var fileRemoved in jsonRemoved)
                {
                    Console.WriteLine("\n\nRemoved files from Current Build: \n");
                    Console.WriteLine(fileRemoved);
                }
            }
        }
        static void ShopTab()
        {
            Console.Title = "FN Shop Tab Grabber C#";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://fn-api.com/api/shop/sections";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = "[" + jsonResponse.Content + "]";

            dynamic json = JsonConvert.DeserializeObject(jsonResponse.Content);

            if (json != null)
            {
                foreach (var data in json)
                {
                    Console.WriteLine($"Server Status: {data.status}");

                    foreach (var tab in data.data.sections)
                    {
                        Console.WriteLine($"{tab.list} {tab.id} --> {tab.name} (X{tab.quantity})");
                    }
                }
            }
        }
        static void EventFlag()
        {
            Console.Title = "Event Flag Grabber C#";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://benbot.app/api/v1/calendar";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = jsonResponse.Content;

            var Deserializedjson = JsonConvert.DeserializeObject<Rootobject>(jsonResponse.Content);

            if (Deserializedjson != null)
            {
                Console.WriteLine("Server Status: 200");

                foreach (var valid in Deserializedjson.channels.clientevents.states)
                {
                    Console.WriteLine($"Client Events: {valid.validFrom}\n");

                    if (valid.activeEvents != null)
                    {
                        foreach (var flag in valid.activeEvents)
                        {
                            var type = flag.eventType;
                            var activeSince = flag.activeSince;
                            var activeUntil = flag.activeUntil;
                            Console.WriteLine($"\nEvent Type: {type} --> Active Since: {activeSince} --> Active Until: {activeUntil}");
                        }
                    }
                }

                Console.WriteLine($"\n\nCache Interval: {Deserializedjson.cacheIntervalMins} Minutes\nCurrent Time: {Deserializedjson.currentTime}");
            }
        }

        // MAIN METHOD HERE 
        static void Main(string[] args)
        {
            Console.Title = "FN Tool";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Specify an operation.\n");
            Console.WriteLine("\t[1] AES");
            Console.WriteLine("\t[2] Cosmetics");
            Console.WriteLine("\t[3] Emergency Notice");
            Console.WriteLine("\t[4] Files");
            Console.WriteLine("\t[5] Shop Tab");
            Console.WriteLine("\t[6] EventFlags");
            string ask = Console.ReadLine();

            if (ask == "1")
            {
                AES();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "2")
            {
                Cosmetics();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "3")
            {
                Notice();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "4")
            {
                Files();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "5")
            {
                ShopTab();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "6")
            {
                EventFlag();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "all")
            {
                AES();
                Notice();
                Cosmetics();
                ShopTab();
                Files();
                EventFlag();
                Console.WriteLine("\n\n\nProcess finished with exit code 0");
            }
        }
    }
}
