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


    // FOR API IN METHOD "Notice" !!!
    public class NoticeRootobject
    {
        public int status { get; set; }
        public NoticeData[] data { get; set; }
    }

    public class NoticeData
    {
        public bool hidden { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string[] platforms { get; set; }
    }



    // FOR API IN METHOD "ShopTab" !!!
    public class ShopRootobject
    {
        public int status { get; set; }
        public ShopData data { get; set; }
    }

    public class ShopData
    {
        public string hash { get; set; }
        public DateTime timestamp { get; set; }
        public Section[] sections { get; set; }
    }

    public class Section
    {
        public string id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string[] list { get; set; }
    }



    // FOR AES IN METHOD "ShopItems" !!!

    public class ShopIRootobject
    {
        public DateTime date { get; set; }
        public DateTime expiration { get; set; }
        public string featuredTitle { get; set; }
        public Featured[] featured { get; set; }
        public string dailyTitle { get; set; }
        public Daily[] daily { get; set; }
        public string specialFeaturedTitle { get; set; }
        public Specialfeatured[] specialFeatured { get; set; }
        public string specialDailyTitle { get; set; }
        public object specialDaily { get; set; }
        public object voteWinners { get; set; }
    }

    public class Featured
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

    public class Daily
    {
        public int panel { get; set; }
        public Entry1[] entries { get; set; }
    }

    public class Entry1
    {
        public string offerId { get; set; }
        public int regularPrice { get; set; }
        public int finalPrice { get; set; }
        public bool isBundle { get; set; }
        public bool isGiftable { get; set; }
        public bool isRefundable { get; set; }
        public int sortPriority { get; set; }
        public object banner { get; set; }
        public Item1[] items { get; set; }
    }

    public class Item1
    {
        public string id { get; set; }
        public string path { get; set; }
        public Icons1 icons { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string shortDescription { get; set; }
        public string backendType { get; set; }
        public string rarity { get; set; }
        public string backendRarity { get; set; }
        public string set { get; set; }
        public string setText { get; set; }
        public Series1 series { get; set; }
        public object variants { get; set; }
        public string[] gameplayTags { get; set; }
    }

    public class Icons1
    {
        public string icon { get; set; }
        public object featured { get; set; }
        public string series { get; set; }
    }

    public class Series1
    {
        public string name { get; set; }
    }

    public class Specialfeatured
    {
        public int panel { get; set; }
        public Entry2[] entries { get; set; }
    }

    public class Entry2
    {
        public string offerId { get; set; }
        public int regularPrice { get; set; }
        public int finalPrice { get; set; }
        public bool isBundle { get; set; }
        public bool isGiftable { get; set; }
        public bool isRefundable { get; set; }
        public int sortPriority { get; set; }
        public object banner { get; set; }
        public Item2[] items { get; set; }
    }

    public class Item2
    {
        public string id { get; set; }
        public string path { get; set; }
        public Icons2 icons { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string shortDescription { get; set; }
        public string backendType { get; set; }
        public string rarity { get; set; }
        public string backendRarity { get; set; }
        public string set { get; set; }
        public string setText { get; set; }
        public Series2 series { get; set; }
        public Variant1[] variants { get; set; }
        public string[] gameplayTags { get; set; }
    }

    public class Icons2
    {
        public string icon { get; set; }
        public string featured { get; set; }
        public string series { get; set; }
    }

    public class Series2
    {
        public string name { get; set; }
    }

    public class Variant1
    {
        public string channel { get; set; }
        public string type { get; set; }
        public Option1[] options { get; set; }
    }

    public class Option1
    {
        public string tag { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public bool startUnlocked { get; set; }
        public bool isDefault { get; set; }
        public bool hideIfNotOwned { get; set; }
    }




    // FOR API IN METHOD "PlayLists" !!!
    public class PlaylistsRootobject
    {
        public int status { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sub_name { get; set; }
        public string description { get; set; }
        public string game_type { get; set; }
        public object rating { get; set; }
        public int min_players { get; set; }
        public int max_players { get; set; }
        public int max_teams { get; set; }
        public int max_teamSize { get; set; }
        public int max_squadSize { get; set; }
        public object gameplay_tags { get; set; }
        public string image { get; set; }
        public object violator { get; set; }
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



    // FOR API IN METHOD "Servers" !!!
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


    // JSON CLASSES END HERE !!!

    // MAIN PROGRAM STARTS HERE !!!

    class Program
    {
        static void AES()
        {
            Console.Title = "FN AES Grabber C#";
            Console.ForegroundColor = ConsoleColor.Green;

            // first api (Fortnite-API)
            string api = "https://fortnite-api.com/v2/aes";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest1 = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest1);
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<AESRootobject>(jsonResponse.Content);

            // RESTSHARP CODE FOR FILES IN DYNAMIC PAKCHUNKS HERE
            string api2 = "https://benbot.app/api/v1/files/dynamic/1011";
            RestClient client2 = new RestClient(api2);
            IRestRequest jsonRequest2 = new RestRequest();
            IRestResponse jsonResponse2 = client2.Execute(jsonRequest2);
            jsonResponse2.Content = jsonResponse2.Content;

            dynamic json2 = JsonConvert.DeserializeObject(jsonResponse2.Content);


            if (json != null)
            {
                Console.WriteLine($"\nServer Status: {json.status} ");
                Console.WriteLine($"Build: {json.data.build}");
                Console.WriteLine($"API Last Updated: {json.data.updated}\n");
                Console.WriteLine($"Main Static Key for current build: {json.data.mainKey.ToUpper()}");
                int pakchunkCount = 0;
                foreach (var key in json.data.dynamicKeys)
                {
                    pakchunkCount++;
                    Console.WriteLine($"\n{key.pakFilename}: Guid = {key.pakGuid}\n{key.pakFilename}: AES Key = {key.key.ToUpper()}");
                }

                Console.WriteLine($"\n\nTotal Pakchunks: {pakchunkCount}");
            }

            if (json2 != null)
            {
                Console.WriteLine("\n\nFiles in Pakchunk1008:\n");
                foreach (var file in json2)
                {
                    Console.WriteLine("\t" + file);
                }
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
                    itemcount++;
                    var ID = item.id;
                    var Name = item.name;
                    var Desc = item.description;
                    var Rarity = item.rarity.displayValue;
                    var BackendRarity = item.rarity.backendValue;
                    var Icon = item.images.icon;
                    Console.WriteLine($"\nItem Name = {Name}\nID = {ID}\nItem Type = {item.type.value}, {item.type.backendValue}, {item.type.displayValue}\nItem Description = {Desc}\nDisplay Rarity = {Rarity}\nBack End Rarity = {BackendRarity}\nDate Added = {item.added}");

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
                    else
                    {
                        Console.WriteLine("Item Shop History = Null [Not yet released]");
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
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<NoticeRootobject>(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine($"\nServer Status: {json.status}\n");

                if (json.data == null)
                {
                    Console.WriteLine("No Emergency Notice update currently available.");
                }
                else if (json.data != null)
                {
                    foreach (var notice in json.data)
                    {
                        //Console.WriteLine($"Gamemode: {notice.gamemodes[0]}");
                        Console.WriteLine($"Hidden (bool true or false): {notice.hidden}");
                        //Console.WriteLine($"Playlist: {notice.playlists[0]}");
                        Console.WriteLine($"\nEmergency Notice Title: {notice.title}");
                        Console.WriteLine($"Emergency Notice Message: {notice.body}");
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
            jsonResponse.Content = jsonResponse.Content;

            dynamic json = JsonConvert.DeserializeObject(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine("\nAdded Files in Current Build: \n");

                foreach (var file in json)
                {
                    Console.WriteLine(file);
                }
            }

            string apiRemoved = "https://benbot.app/api/v1/files/removed";
            RestClient clientRemoved = new RestClient(apiRemoved);
            IRestRequest jsonRequestRemoved = new RestRequest();
            IRestResponse jsonResponseRemoved = clientRemoved.Execute(jsonRequestRemoved);
            jsonResponseRemoved.Content = jsonResponseRemoved.Content;

            dynamic jsonRemoved = JsonConvert.DeserializeObject(jsonResponseRemoved.Content);

            if (jsonRemoved != null)
            {
                Console.WriteLine("\n\nRemoved files from Current Build: \n");

                foreach (var fileRemoved in jsonRemoved)
                {
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
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<ShopRootobject>(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine($"Server Status: {json.status}");
                Console.WriteLine($"Time Stamp: {json.data.timestamp}");

                foreach (var tab in json.data.sections)
                {
                    foreach (var list in tab.list)
                    {
                        Console.WriteLine($"({list}) = {tab.id} --> {tab.name} (X{tab.quantity})");
                    }
                }
            }
        }

        static void ShopItem()
        {
            Console.Title = "Shop Items";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://benbot.app/api/v1/shop/br";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<ShopIRootobject>(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine($"Date: {json.date}");
                Console.WriteLine($"Expiration Time/Date: {json.expiration}");

                Console.WriteLine("Shop Tab Titles:\n");
                var Featured = json.featuredTitle;
                Console.WriteLine(Featured);
                var Daily = json.dailyTitle;
                Console.WriteLine(Daily);
                var SpecialF = json.specialFeaturedTitle;
                Console.WriteLine(SpecialF);
                var SpecialD = json.specialDailyTitle;
                Console.WriteLine(SpecialD);

                var itemcount = 0;
                Console.WriteLine($"\n\nItems in {Featured}:\n\n");
                foreach (var a in json.featured)
                {
                    foreach (var i in a.entries)
                    {
                        foreach (var data in i.items)
                        {
                            itemcount++;
                            var ID = data.id;
                            var Name = data.name;
                            var Desc = data.description;
                            var ShortDesc = data.shortDescription;
                            var Rarity = data.rarity;
                            var BackendRarity = data.backendRarity;
                            var Type = data.backendType;
                            var Path = data.path;
                            var Icon = data.icons;
                            Console.WriteLine($"Name: {Name}");
                            Console.WriteLine($"ID: {ID}");
                            Console.WriteLine($"Item Type: {Type}");
                            Console.WriteLine($"Description: {Desc}");
                            Console.WriteLine($"Short Description: {ShortDesc}");
                            Console.WriteLine($"Rarity: {Rarity}");
                            Console.WriteLine($"Backend Rarity: {BackendRarity}");
                            Console.WriteLine($"Item Path: {Path}");
                            if (data.set != null)
                            {
                                var Set = data.set;
                                var SetText = data.setText;
                                Console.WriteLine($"{Set}, {SetText}\n");
                            }
                        }
                    }
                }
            }
        }

        static void PlayLists()
        {
            Console.Title = "Active Playlists";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://fn-api.com/api/playlists/active";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<PlaylistsRootobject>(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine($"Server Status: {json.status}\n");

                foreach (var playlist in json.data)
                {
                    Console.WriteLine($"Playlist ID: {playlist.id}");
                    if (playlist.name != null)
                    {
                        Console.WriteLine($"Playlist Name: {playlist.name}");
                    }
                    if (playlist.sub_name != null)
                    {
                        Console.WriteLine($"Playlist Subname: { playlist.sub_name}");
                    }
                    if (playlist.description != null)
                    {
                        Console.WriteLine($"Playlist Description:\n{playlist.description}");
                    }
                    Console.WriteLine($"Playlist Mode: {playlist.game_type}\n");
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

        static void Servers()
        {
            Console.Title = "FN DevServer Data";
            Console.ForegroundColor = ConsoleColor.Green;

            string api = "https://fn-api.com/api/servers";
            RestClient client = new RestClient(api);
            IRestRequest jsonRequest = new RestRequest();
            IRestResponse jsonResponse = client.Execute(jsonRequest);
            jsonResponse.Content = jsonResponse.Content;

            var json = JsonConvert.DeserializeObject<ServerRootobject>(jsonResponse.Content);

            if (json != null)
            {
                Console.WriteLine($"Server Status: {json.status}\n\n");
                if (json.data.devplaytestprod12 != null)
                {
                    Console.WriteLine("DevPlaytestProd12: \n\n");
                    var CLN = json.data.devplaytestprod12.cln;
                    var Build = json.data.devplaytestprod12.build;
                    var ModuleName = json.data.devplaytestprod12.moduleName;
                    var Version = json.data.devplaytestprod12.version;
                    var Branch = json.data.devplaytestprod12.branch;
                    Console.WriteLine($"App = {json.data.devplaytestprod12.app}");
                    Console.WriteLine($"Server DateTime = {json.data.devplaytestprod12.serverDate}");
                    Console.WriteLine($"CLN = {CLN}");
                    Console.WriteLine($"Build = {Build}");
                    Console.WriteLine($"Module = {ModuleName}");
                    Console.WriteLine($"Build DateTime = {json.data.devplaytestprod12.buildDate}");
                    Console.WriteLine($"Version = {Version}");
                    Console.WriteLine($"Branch = {Branch}\n\n");
                }
                if (json.data.releaseplaytestprod != null)
                {
                    Console.WriteLine("ReleasePlayTestProd: \n\n");
                    var CLN = json.data.releaseplaytestprod.cln;
                    var Build = json.data.releaseplaytestprod.build;
                    var ModuleName = json.data.releaseplaytestprod.moduleName;
                    var Version = json.data.releaseplaytestprod.version;
                    var Branch = json.data.releaseplaytestprod.branch;
                    Console.WriteLine($"App = {json.data.releaseplaytestprod.app}");
                    Console.WriteLine($"Server DateTime = {json.data.releaseplaytestprod.serverDate}");
                    Console.WriteLine($"CLN = {CLN}");
                    Console.WriteLine($"Build = {Build}");
                    Console.WriteLine($"Module = {ModuleName}");
                    Console.WriteLine($"Build DateTime = {json.data.releaseplaytestprod.buildDate}");
                    Console.WriteLine($"Version = {Version}");
                    Console.WriteLine($"Branch = {Branch}\n\n");
                }
                if (json.data.stage != null)
                {
                    Console.WriteLine("Stage: \n\n");
                    var CLN = json.data.stage.cln;
                    var Build = json.data.stage.build;
                    var ModuleName = json.data.stage.moduleName;
                    var Version = json.data.stage.version;
                    var Branch = json.data.stage.branch;
                    Console.WriteLine($"App = {json.data.stage.app}");
                    Console.WriteLine($"Server DateTime = {json.data.stage.serverDate}");
                    Console.WriteLine($"CLN = {CLN}");
                    Console.WriteLine($"Build = {Build}");
                    Console.WriteLine($"Module = {ModuleName}");
                    Console.WriteLine($"Build DateTime = {json.data.stage.buildDate}");
                    Console.WriteLine($"Version = {Version}");
                    Console.WriteLine($"Branch = {Branch}\n\n");
                }
            }
        }

        // MAIN METHOD HERE !!!
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
            Console.WriteLine("\t[6] Shop Item");
            Console.WriteLine("\t[7] Playlists");
            Console.WriteLine("\t[8] EventFlags");
            Console.WriteLine("\t[9] ServerRelease");
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
                ShopItem();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "7")
            {
                PlayLists();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "8")
            {
                EventFlag();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "9")
            {
                Servers();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
        }
    }
}
