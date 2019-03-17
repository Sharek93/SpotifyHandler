using SpotifyHandler.Components;
using SpotifyHandler.Helpers;
using System;

namespace SpotifyHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spotify Handler");
            Config.LoadConfig();

            SpotifyConnector.GetPlaylist(Config.AppConfig.PlaylistId);

            Console.ReadKey();
        }
    }
}
