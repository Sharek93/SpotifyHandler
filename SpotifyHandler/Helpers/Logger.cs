using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SpotifyHandler.Helpers
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message.AddDateTime());
            Debug.WriteLine(message.AddDateTime());
        }
    }
}
