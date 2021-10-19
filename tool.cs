using System;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;

namespace FN_Tool_CSharp
{
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
            jsonResponse.Content = "[" + jsonResponse.Content + "]";

            dynamic json = JsonConvert.DeserializeObject(jsonResponse.Content);

            if (json != null)
            {
                foreach (var data in json)
                {
                    Console.WriteLine($"\nServer Status: {data.status} ");
                    Console.WriteLine($"Build: {data.data.build}");
                    Console.WriteLine($"API Last Updated: {data.data.updated}");
                    int pakchunkCount = 0;
                    foreach (var key in data.data.dynamicKeys)
                    {
                        pakchunkCount = pakchunkCount + 1;
                        Console.WriteLine($"\n{key.pakFilename}: Guid = {key.pakGuid}\n{key.pakFilename}: AES Key = {key.key}");
                    }

                    Console.WriteLine($"Total Pakchunks: {pakchunkCount}");
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
            jsonResponse.Content = "[" + jsonResponse.Content + "]";

            dynamic json = JsonConvert.DeserializeObject(jsonResponse.Content);

            if (json != null)
            {                
                foreach (var data in json)
                {
                    Console.WriteLine($"\nServer Status: {data.status}");
                    Console.WriteLine($"Previous Build: {data.data.previousBuild}");
                    Console.WriteLine($"Current Build: {data.data.build}\n");
                    int itemcount = 0;
                    foreach (var item in data.data.items)
                    {
                        itemcount = itemcount + 1;
                        var ID = item.id;
                        var name = item.name;
                        var desc = item.description;
                        var rarity = item.rarity.displayValue;
                        var backendRarity = item.rarity.backendValue;
                        var icon = item.images.icon;
                        Console.WriteLine($"\nItem Name = {name}\nID = {ID}\nItem Description = {desc}\nDisplay Rarity = {rarity}\nBack End Rarity = {backendRarity}");
                        if (item.set != null)
                        {
                            var set1 = item.set.value;
                            var set2 = item.set.text;
                            Console.WriteLine($"Part of set: {set1}, {set2}");
                        }
                    }

                    Console.WriteLine($"\nTotal cosmetics added in {data.data.build} --> {itemcount}");
                }
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

                    if (data.data != null)
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
                    else if (data.data == null)
                    {
                        Console.WriteLine("No Emergency Notice update currently available.");
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
        static void Main(string[] args)
        {
            Console.Title = "FN Tool";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Specify an operation.\n");
            Console.WriteLine("\tAES");
            Console.WriteLine("\tCosmetics");
            Console.WriteLine("\tEmergency Notice");
            Console.WriteLine("\tFiles");
            Console.WriteLine("\tShop Tab");
            string ask = Console.ReadLine();

            if (ask == "AES")
            {
                AES();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "Cosmetics")
            {
                Cosmetics();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "Emergency Notice")
            {
                Notice();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "Files")
            {
                Files();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
            else if (ask == "Shop Tab")
            {
                ShopTab();
                Console.WriteLine("\n\nProcess finished with exit code 0.");
                Console.ReadKey();
            }
        }
    }
}
