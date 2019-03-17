using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyHandler.Helpers
{
    public static class Extensions
    {
        public static string AddDateTime(this string message)
        {
            var dateTime = $"{DateTime.Now.Hour:00}:{DateTime.Now.Minute:00}:{DateTime.Now.Second:00}";
            return $"{dateTime}: {message} ";
        }        
    }
}
