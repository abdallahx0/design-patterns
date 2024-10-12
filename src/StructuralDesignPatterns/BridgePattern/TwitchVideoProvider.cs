namespace BridgePattern
{
    public class TwitchVideoProvider(IVideoQuality videoQuality) : IVideoProvider
    {
        public void Playback(string videoId)
        {
            videoQuality.Render();
            Console.WriteLine("Playback twitch video...");
        }
    }
}
