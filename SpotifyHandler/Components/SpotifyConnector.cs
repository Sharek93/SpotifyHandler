using SpotifyHandler.Helpers;
using System;
using System.Net;

namespace SpotifyHandler.Components
{
    public static class SpotifyConnector
    {
        public static void Authorize(string clientId)
        {

        }

        public static void GetPlaylist(string playlistId)
        {
            var requestUri = $@"{Config.AppConfig.SpotifyURI}/playlists/{playlistId}";
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.Method = "GET";

            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {

                }
            }
            catch (Exception e)
            {
                Logger.Log($"Connot get playlist: {e.Message}");
                
            }
        }
    }
}
