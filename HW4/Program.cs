using System;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            IRadioProcessor radioProcessor = new RadioProcessor(logger);

            Track track = new Track
            {
                TrackId = 1,
                TrackName = "Bohemian Rhapsody",
                Artist = "Queen"
            };

            radioProcessor.PlayTrack(track);
        }
    }
}
