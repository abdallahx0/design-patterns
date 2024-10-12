namespace BridgePattern
{
    public class YouTubeVideoProvider(IVideoQuality videoQuality) : IVideoProvider
    {
        public void Playback(string videoId)
        {
            videoQuality.Render();
            Console.WriteLine("Playback youtube video...");
        }
    }
}
