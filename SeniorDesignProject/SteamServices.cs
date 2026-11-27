using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SeniorDesignProject;

public class SteamService
{
	private readonly HttpClient client;
	private readonly string apiKey;
	private gamesDictionary steamDictionary;
	public SteamService(string steamAPIkey)
	{
		apiKey = steamAPIkey;
		client = new HttpClient();
		steamDictionary = new gamesDictionary("steam.txt");
	}

	public async Task<List<SteamApp>> GetAppListAsync()
	{
		List<SteamApp> allApps = new List<SteamApp>();

		uint? lastAppId = null;
		bool hasMoreResults = true;

		while(hasMoreResults)
		{
			// Creating the parameters for Steam.
			string inputJson = "{\"max_results\": 50000";

			if(lastAppId.HasValue)
			{
				inputJson += ",\"last_appid\":" + lastAppId.Value;
			}

			inputJson += "}";

			// Build the request URL.
			string url =
				"https://api.steampowered.com/IStoreService/GetAppList/v1/" +
				"?key=" + Uri.EscapeDataString(apiKey) +
				"&input_json=" + Uri.EscapeDataString(inputJson);

			// Send the request.
			HttpResponseMessage response = await client.GetAsync(url);

			response.EnsureSuccessStatusCode();

			// Read the JSON response.
			string json = await response.Content.ReadAsStringAsync();

			JObject data = JObject.Parse(json);

			JArray apps = (JArray)data["response"]["apps"];

			// Read each app from the response.
			foreach (JToken app in apps)
			{
				SteamApp steamApp = new SteamApp();

				steamApp.AppId = app["appid"].Value<uint>();
				steamApp.Name = app["name"] == null
					? null
					: app["name"].Value<string>();

				allApps.Add(steamApp);
			}

			// Determine whether Steam has more results.
			JToken moreResults = data["response"]["have_more_results"];

			hasMoreResults = moreResults != null &&
				moreResults.Value<bool>();

			// Save the last App ID for the next request.
			if(apps.Count >0)
			{
				lastAppId = apps[apps.Count - 1]["appid"].Value<uint>();
			}
			else
			{
				hasMoreResults = false;
			}

		}

		return allApps;
	}

	// Insert the new method here.
	public async Task SaveAppDetailsAsync(uint appID, string appName)
	{
		string url =
			"https://store.steampowered.com/api/appdetails" +
			"?appids=" + appID +
			"&cc=us&l=en";

		HttpResponseMessage response = await client.GetAsync(url);

		response.EnsureSuccessStatusCode();

		string json = await response.Content.ReadAsStringAsync();

		// Might not be reliable for pathing
		string folderPath = Path.Combine(
			Directory.GetParent(
				AppDomain.CurrentDomain.BaseDirectory
				).Parent.FullName,
			"SteamData"
		);

		Directory.CreateDirectory(folderPath);
        string appTempName = string.Join("", appName.Split(Path.GetInvalidFileNameChars()));
		appTempName = string.Join("", appName.Split(' ', '-'));
        appTempName = appTempName.ToLower();

		steamDictionary.addGame(appTempName, appID.ToString());

        string filePath = Path.Combine(
			folderPath,
			appID + ".json"
		);

        Console.WriteLine(steamDictionary.retrieveID("counterstrike"));

        File.WriteAllText(filePath, json);

        Console.WriteLine("Saving files to: " + folderPath);
    }
}
