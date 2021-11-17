using FnTool.Objects;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace FnTool;

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
                
                var Httpclient = new HttpClient();
                var content = await Httpclient.GetByteArrayAsync(Icon).ConfigureAwait(false);

                await File.WriteAllBytesAsync($"{ID}.png", content).ConfigureAwait(false);
                

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
        // user input
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
