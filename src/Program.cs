﻿using FnTool.Objects;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace FnTool;

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
    public NoticeDatum[] data { get; set; }
}

public class NoticeDatum
{
    public string title { get; set; }
    public string body { get; set; }
    public object hidden { get; set; }
    public object gamemodes { get; set; }
    public string[] platforms { get; set; }
    public Playlist[] playlists { get; set; }
}

public class Playlist
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
    public object image { get; set; }
    public object violator { get; set; }
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



// FOR API IN METHOD "Background" !!!
public class BackgroundRootobject
{
    public int status { get; set; }
    public BackgroundData data { get; set; }
}

public class BackgroundData
{
    public Lobby lobby { get; set; }
    public Vault vault { get; set; }
}

public class Lobby
{
    public string name { get; set; }
    public string image { get; set; }
}

public class Vault
{
    public string name { get; set; }
    public object image { get; set; }
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


// FOR API IN METHOD "PlayerStats" !!!
public class StatRootobject
{
    public int status { get; set; }
    public StatData data { get; set; }
}

public class StatData
{
    public Account account { get; set; }
    public Battlepass battlePass { get; set; }
    public object image { get; set; }
    public Stats stats { get; set; }
}

public class Account
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Battlepass
{
    public int level { get; set; }
    public int progress { get; set; }
}

public class Stats
{
    public All all { get; set; }
}

public class All
{
    public Overall overall { get; set; }
    public Solo solo { get; set; }
    public Duo duo { get; set; }
    public Squad squad { get; set; }
    public Ltm ltm { get; set; }
}

public class Overall
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top3 { get; set; }
    public int top5 { get; set; }
    public int top6 { get; set; }
    public int top10 { get; set; }
    public int top12 { get; set; }
    public int top25 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Solo
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top10 { get; set; }
    public int top25 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Duo
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top5 { get; set; }
    public int top12 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Squad
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int top3 { get; set; }
    public int top6 { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Ltm
{
    public int score { get; set; }
    public float scorePerMin { get; set; }
    public float scorePerMatch { get; set; }
    public int wins { get; set; }
    public int kills { get; set; }
    public float killsPerMin { get; set; }
    public float killsPerMatch { get; set; }
    public int deaths { get; set; }
    public float kd { get; set; }
    public int matches { get; set; }
    public float winRate { get; set; }
    public int minutesPlayed { get; set; }
    public int playersOutlived { get; set; }
    public DateTime lastModified { get; set; }
}

public class Run
{
    public static void AES()
    {
        var client = new RestClient(Program.FortniteApiUrl);
        client.UseSerializer<JsonNetSerializer>();

        var request = new RestRequest("/v2/aes");
        var response = client.Execute<ApiResponse<Aes>>(request);
        var data = response.Data.Data;

        Console.WriteLine($"\nServer Status: {response.Data.Status} ");
        Console.WriteLine($"Build: {data.Build}");
        Console.WriteLine($"API Last Updated: {data.Updated}\n");
        Console.WriteLine($"Main Static Key for current build: 0x{data.MainKey.ToUpper()}");

        foreach (var key in data.DynamicKeys)
        {
            Console.WriteLine(
                $"\n{key.PakFilename}: Guid = {key.PakGuid}\n{key.PakFilename}: AES Key = {key.Key.ToUpper()}");
        }

        Console.WriteLine($"\n\nTotal Pakchunks: {data.DynamicKeys.Length + 1}");

        Console.Write("Enter a Dynamic Pakchunk number to access it's files : ");
        var pakchunk = Console.ReadLine();

        var api2 = $"https://benbot.app/api/v1/files/dynamic/{pakchunk}";
        RestClient client2 = new RestClient(api2);
        IRestRequest jsonRequest2 = new RestRequest();
        IRestResponse jsonResponse2 = client2.Execute(jsonRequest2);
        jsonResponse2.Content = jsonResponse2.Content;

        dynamic json2 = JsonConvert.DeserializeObject(jsonResponse2.Content);

        if (json2 != null)
        {
            Console.WriteLine($"\n\nFiles in Pakchunk {pakchunk}:\n");
            foreach (var file in json2)
            {
                Console.WriteLine("\t" + file);
            }
        }

    }

    public static void Cosmetics()
    {
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
                var Path = item.path;
                Console.WriteLine(
                    $"\nItem Name = {Name}\nID = {ID}\nItem Type = {item.type.value}, " +
                    $"{item.type.backendValue}, {item.type.displayValue}\n" +
                    $"Item Description = {Desc}\nDisplay Rarity = {Rarity}\n" +
                    $"Back End Rarity = {BackendRarity}\nDate Added = {item.added}\n" +
                    $"File Path = {Path}"
                );

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
                    Console.WriteLine("Item Shop History = Null (Not yet release)");
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

    public static void Notice()
    {
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
                    Console.WriteLine($"Hidden (bool true or false): {notice.hidden}");
                    Console.WriteLine($"\nEmergency Notice Title: {notice.title}");
                    Console.WriteLine($"Emergency Notice Message: {notice.body}");
                    if (notice.gamemodes != null)
                    {
                        Console.WriteLine($"Gamemode: {notice.gamemodes}");
                    }

                    foreach (var Platforms in notice.platforms)
                    {
                        Console.WriteLine($"Platforms: {Platforms}");
                    }

                    if (notice.playlists != null)
                    {
                        foreach (var playlist in notice.playlists)
                        {
                            Console.WriteLine($"Playlist ID: {playlist.id}");
                            if (playlist.name != null)
                            {
                                Console.WriteLine($"Playlist Name: {playlist.name}");
                            }

                            if (playlist.sub_name != null)
                            {
                                Console.WriteLine($"Playlist Subname: {playlist.sub_name}");
                            }

                            if (playlist.description != null)
                            {
                                Console.WriteLine($"Playlist Description:\n{playlist.description}");
                            }

                            Console.WriteLine($"Playlist Mode: {playlist.game_type}\n");
                        }
                    }
                }
            }
        }
    }

    public static void Files()
    {
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

    public static void ShopTab()
    {
        string api = "https://fn-api.com/api/shop/sections";
        RestClient client = new RestClient(api);
        IRestRequest jsonRequest = new RestRequest();
        IRestResponse jsonResponse = client.Execute(jsonRequest);
        jsonResponse.Content = jsonResponse.Content;

        var json = JsonConvert.DeserializeObject<ShopRootobject>(jsonResponse.Content);

        if (json != null)
        {
            Console.WriteLine($"Server Status: {json.status}");
            Console.WriteLine($"Date: {json.data.date}");

            foreach (var tab in json.data.sections)
            {
                Console.WriteLine($"{tab.id} --> {tab.name} (X{tab.quantity})");
            }
        }
    }

    public static void ShopItem()
    {
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
            var itemcount2 = 0;
            var itemcount3 = 0;
            Console.WriteLine($"\n\nItems in {Featured}:\n\n");
            if (json.featured != null)
            {
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
                                Console.WriteLine($"{Set} {SetText}\n");
                            }
                            else
                            {
                                Console.WriteLine("\n");
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Total Items in {Featured} = {itemcount} \n\n");

            if (json.daily != null)
            {
                foreach (var a in json.daily)
                {
                    foreach (var i in a.entries)
                    {
                        foreach (var data in i.items)
                        {
                            itemcount2++;
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
                                Console.WriteLine($"{Set} {SetText}\n");
                            }
                            else
                            {
                                Console.WriteLine("\n");
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Total Items in {Daily} = {itemcount2}\n\n");

            if (json.specialFeatured != null)
            {
                foreach (var a in json.specialFeatured)
                {
                    foreach (var i in a.entries)
                    {
                        foreach (var data in i.items)
                        {
                            itemcount3++;
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
                                Console.WriteLine($"{Set} {SetText}\n");
                            }
                            else
                            {
                                Console.WriteLine("\n");
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Total Items in {SpecialF} = {itemcount3}\n\n");
            var total = itemcount + itemcount2 + itemcount3;
            Console.WriteLine($"Total Items in the shop: {total}");
        }
    }

    public static void Backgrounds()
    {
        string api = "https://fn-api.com/api/backgrounds";
        RestClient client = new RestClient(api);
        IRestRequest jsonRequest = new RestRequest();
        IRestResponse jsonResponse = client.Execute(jsonRequest);
        jsonResponse.Content = jsonResponse.Content;

        var json = JsonConvert.DeserializeObject<BackgroundRootobject>(jsonResponse.Content);

        if (json != null)
        {
            Console.WriteLine($"Server Status: {json.status}");

            if (json.data.lobby != null)
            {
                Console.WriteLine($"Lobby Background Name: {json.data.lobby.name}");
                Console.WriteLine($"Lobby Background Image URL: {json.data.lobby.image}");
            }

            if (json.data.vault != null)
            {
                Console.WriteLine($"Shop Background Name: {json.data.vault.name}");
                Console.WriteLine($"Shop Background Image URL: {json.data.vault.image}");
            }
        }
    }

    public static void PlayLists()
    {
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
                    Console.WriteLine($"Playlist Subname: {playlist.sub_name}");
                }

                if (playlist.description != null)
                {
                    Console.WriteLine($"Playlist Description:\n{playlist.description}");
                }

                Console.WriteLine($"Playlist Mode: {playlist.game_type}\n");
            }
        }
    }

    public static void EventFlag()
    {
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
                        Console.WriteLine(
                            $"\nEvent Type: {type} --> Active Since: {activeSince} --> Active Until: {activeUntil}");
                    }
                }
            }

            Console.WriteLine(
                $"\n\nCache Interval: {Deserializedjson.cacheIntervalMins} Minutes\nCurrent Time: {Deserializedjson.currentTime}");
        }
    }

    public static void Servers()
    {
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

            if (json.data.extqareleasetestingbprod != null)
            {
                Console.WriteLine("ExtQAReleaseTestingA: \n\n");
                var CLN = json.data.extqareleasetestingbprod.cln;
                var Build = json.data.extqareleasetestingbprod.build;
                var ModuleName = json.data.extqareleasetestingbprod.moduleName;
                var Version = json.data.extqareleasetestingbprod.version;
                var Branch = json.data.extqareleasetestingbprod.branch;
                Console.WriteLine($"App = {json.data.extqareleasetestingbprod.app}");
                Console.WriteLine($"Server DateTime = {json.data.extqareleasetestingbprod.serverDate}");
                Console.WriteLine($"CLN = {CLN}");
                Console.WriteLine($"Build = {Build}");
                Console.WriteLine($"Module = {ModuleName}");
                Console.WriteLine($"Build DateTime = {json.data.extqareleasetestingbprod.buildDate}");
                Console.WriteLine($"Version = {Version}");
                Console.WriteLine($"Branch = {Branch}\n\n");
            }
        }
    }

    public static void PlayerStats()
    {
        Console.Write("Enter the account name : ");
        string PlayerName = Console.ReadLine();
        /*Console.Write("LifeTime Player Stats or Seasonal Player Stats? [Reply with True/False]");
        string LifeTimeOrSeason = Console.ReadLine();*/

        string api = $"https://fortnite-api.com/v2/stats/br/v2?name={PlayerName}";
        RestClient client = new RestClient(api);
        IRestRequest jsonRequest = new RestRequest();
        IRestResponse jsonResponse = client.Execute(jsonRequest);
        jsonResponse.Content = jsonResponse.Content;

        var json = JsonConvert.DeserializeObject<StatRootobject>(jsonResponse.Content);

        if (json != null)
        {
            Console.WriteLine($"Server Status : {json.status}");
            if (json.status != 404)
            {
                Console.WriteLine("\nAccount Details:\n");
                Console.WriteLine($"Account Name: {json.data.account.name}");
                Console.WriteLine($"Account ID: {json.data.account.id}");

                Console.WriteLine("\n\nBattlePass Info:\n");
                Console.WriteLine($"Level: {json.data.battlePass.level}\nProgress: {json.data.battlePass.progress}");

                var SoloStats = json.data.stats.all.solo;
                var DuoStats = json.data.stats.all.duo;
                var SquadStats = json.data.stats.all.squad;
                var LTMStats = json.data.stats.all.ltm;
                var OverallStats = json.data.stats.all.overall;

                if (SoloStats != null)
                {
                    Console.WriteLine("\n\nSolo Stats:\n");
                    Console.WriteLine($"Win Amount: {SoloStats.wins}");
                    Console.WriteLine($"Win Rate: {SoloStats.winRate}");
                    Console.WriteLine($"Top 10: {SoloStats.top10}\nTop 25: {SoloStats.top25}");
                    Console.WriteLine($"Kills: {SoloStats.kills}\nDeaths: {SoloStats.deaths}");
                    Console.WriteLine($"Score: {SoloStats.score}\nScore per match: {SoloStats.scorePerMatch}");
                    Console.WriteLine(
                        $"Matches Played: {SoloStats.matches}\nMinutes Played in Solo: {SoloStats.minutesPlayed}");
                    Console.WriteLine($"Players Outlived: {SoloStats.playersOutlived}");
                    Console.WriteLine($"Kills To Death Ratio (KDR): {SoloStats.kd}");
                    Console.WriteLine($"Data Last Modified: {SoloStats.lastModified}");
                }

                if (DuoStats != null)
                {
                    Console.WriteLine("\n\nDuo Stats:\n");
                    Console.WriteLine($"Win Amount: {DuoStats.wins}");
                    Console.WriteLine($"Win Rate: {DuoStats.winRate}");
                    Console.WriteLine($"Top 5: {DuoStats.top5}\nTop 12: {DuoStats.top12}");
                    Console.WriteLine($"Kills: {DuoStats.kills}\nDeaths: {DuoStats.deaths}");
                    Console.WriteLine($"Score: {DuoStats.score}\nScore per match: {DuoStats.scorePerMatch}");
                    Console.WriteLine(
                        $"Matches Played: {DuoStats.matches}\nMinutes Played in Duo: {DuoStats.minutesPlayed}");
                    Console.WriteLine($"Players Outlived: {DuoStats.playersOutlived}");
                    Console.WriteLine($"Kills To Death Ratio (KDR): {DuoStats.kd}");
                    Console.WriteLine($"Data Last Modified: {DuoStats.lastModified}");
                }

                if (SquadStats != null)
                {
                    Console.WriteLine("\n\nSquad Stats:\n");
                    Console.WriteLine($"Win Amount: {SquadStats.wins}");
                    Console.WriteLine($"Win Rate: {SquadStats.winRate}");
                    Console.WriteLine($"Top 3: {SquadStats.top3}\nTop 6: {SquadStats.top6}");
                    Console.WriteLine($"Kills: {SquadStats.kills}\nDeaths: {SquadStats.deaths}");
                    Console.WriteLine($"Score: {SquadStats.score}\nScore per match: {SquadStats.scorePerMatch}");
                    Console.WriteLine(
                        $"Matches Played: {SquadStats.matches}\nMinutes Played in Squad: {SquadStats.minutesPlayed}");
                    Console.WriteLine($"Players Outlived: {SquadStats.playersOutlived}");
                    Console.WriteLine($"Kills To Death Ratio (KDR): {SquadStats.kd}");
                    Console.WriteLine($"Data Last Modified: {SquadStats.lastModified}");
                }

                if (LTMStats != null)
                {
                    Console.WriteLine("\n\nLTM Stats:\n");
                    Console.WriteLine($"Win Amount: {LTMStats.wins}");
                    Console.WriteLine($"Win Rate: {LTMStats.winRate}");
                    Console.WriteLine($"Kills: {LTMStats.kills}\nDeaths: {LTMStats.deaths}");
                    Console.WriteLine($"Score: {LTMStats.score}\nScore per match: {LTMStats.scorePerMatch}");
                    Console.WriteLine(
                        $"Matches Played: {LTMStats.matches}\nMinutes Played in LTM's: {LTMStats.minutesPlayed}");
                    Console.WriteLine($"Players Outlived: {LTMStats.playersOutlived}");
                    Console.WriteLine($"Kills To Death Ratio (KDR): {LTMStats.kd}");
                    Console.WriteLine($"Data Last Modified: {LTMStats.lastModified}");
                }

                if (OverallStats != null)
                {
                    Console.WriteLine("\n\nOverall Stats:\n");
                    Console.WriteLine($"Win Amount: {OverallStats.wins}");
                    Console.WriteLine($"Win Rate: {OverallStats.winRate}");
                    Console.WriteLine($"Kills: {OverallStats.kills}\nDeaths: {OverallStats.deaths}");
                    Console.WriteLine($"Score: {OverallStats.score}\nScore per match: {OverallStats.scorePerMatch}");
                    Console.WriteLine(
                        $"Matches Played: {OverallStats.matches}\nMinutes Played in Squad: {OverallStats.minutesPlayed}");
                    Console.WriteLine($"Players Outlived: {OverallStats.playersOutlived}");
                    Console.WriteLine($"Kills To Death Ratio (KDR): {OverallStats.kd}");
                    Console.WriteLine($"Data Last Modified: {OverallStats.lastModified}");
                }
            }
        }
    }

    public static async Task CreatorCodeAsync()
    {
        var creatorCode = Utils.ReadInput("Enter the creator code : ");
        var client = new RestClient(Program.FortniteApiUrl);
        var request = new RestRequest($"/v2/creatorcode?name={creatorCode}");
        var response = await client.ExecuteAsync<ApiResponse<CreatorCode>>(request);
        if (!response.IsSuccessful)
        {
            return;
        }

        var data = response.Data.Data;
        Console.WriteLine($"Server Status: {response.Data.Status}");
        Console.WriteLine($"Creator Code: {data.Code}\nCode Status: {data.Status}");
        Console.WriteLine($"Account: {data.Account.Name}\nAccount ID: {data.Account.Id}");
        Console.WriteLine($"Code Verification: {data.Verified}");
    }

}

internal class Program
{

    public const string BenbotBaseUrl = "https://benbot.app";
    public const string FortniteApiUrl = "https://fortnite-api.com";

    public static async Task PrintDefaultInfoAsync()
    {
        var client = new RestClient(BenbotBaseUrl);
        var request = new RestRequest("/api/v1/mappings");
        var response = await client.ExecuteGetAsync(request);
        var json = JsonConvert.DeserializeObject<dynamic>(response.Content);
        if (json == null)
        {
            return;
        }

        foreach (var data in json)
        {
            Console.WriteLine($"Current Game Version : {data.meta.version}\n");
            break;
        }
    }

    public static async Task Main(string[] _)
    {
        Console.Title = "FN Tool";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Greetings! It is currently {DateTime.UtcNow} UTC");

        await PrintDefaultInfoAsync();
        PrintOperations();

        var ask = Console.ReadLine();
        var vs = new[]{ "Working on it...\n\n", "Loading...\n\n", "Grabbing your IP-- oh I mean, grabbing your data...\n\n" };

        var random = new Random();
        var randomIndex = random.Next(vs.Length);

        Console.WriteLine(vs[randomIndex]);
        switch (ask)
        {
            case "1": Run.AES();
                break;
            case "2":
                Run.Cosmetics();
                break;
            case "3":
                Run.Notice();
                break;
            case "4":
                Run.Files();
                break;
            case "5":
                Run.ShopTab();
                break;
            case "6":
                Run.ShopItem();
                break;
            case "7":
                Run.Backgrounds();
                break;
            case "8":
                Run.PlayLists();
                break;
            case "9":
                Run.EventFlag();
                break;
            case "10":
                Run.Servers();
                break;
            case "11":
                Run.PlayerStats();
                break;
            case "12":
                await Run.CreatorCodeAsync();
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }

        Console.WriteLine("\n\nProcess finished with exit code 0.");
        Console.ReadKey();
    }

    private static void PrintOperations()
    {
        Console.WriteLine("\nSpecify an operation.\n");
        Console.WriteLine("\t[1] AES");
        Console.WriteLine("\t[2] Cosmetics");
        Console.WriteLine("\t[3] Emergency Notice");
        Console.WriteLine("\t[4] Files");
        Console.WriteLine("\t[5] Shop Tab");
        Console.WriteLine("\t[6] Shop Item");
        Console.WriteLine("\t[7] Background Image");
        Console.WriteLine("\t[8] Playlists");
        Console.WriteLine("\t[9] Event Flags");
        Console.WriteLine("\t[10] Server Release");
        Console.WriteLine("\t[11] Player Stats");
        Console.WriteLine("\t[12] Creator Code Check");
    }

}