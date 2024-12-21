using System;

namespace HW4
{
    public class RadioProcessor : IRadioProcessor
    {
        private readonly ILogger _logger;

        public RadioProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public void PlayTrack(Track track)
        {
            // Логика воспроизведения трека
            Console.WriteLine($"Сейчас играет: {track.TrackName} от {track.Artist}");

            // Логирование результата
            _logger.Log($"Трек {track.TrackName} успешно воспроизведен.");
        }
    }

}
