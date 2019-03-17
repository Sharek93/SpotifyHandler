using Newtonsoft.Json;
using SpotifyHandler.Models;
using System;
using System.IO;

namespace SpotifyHandler.Helpers
{
    public static class Config
    {
        public static AppConfig AppConfig { get; set; }

        public static void LoadConfig()
        {
            try
            {
                var configString = File.ReadAllText("AppConfig.json");
                AppConfig = JsonConvert.DeserializeObject<AppConfig>(configString);
                Logger.Log("Config Loaded:");
                Logger.Log("\n" + configString);
            }
            catch (Exception e)
            {
                Logger.Log($"Error occured while loading config file: {e.Message}");               
            }
        }
    }
}
