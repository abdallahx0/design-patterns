

using BridgePattern;

IVideoProvider youtubeVideoProvider = new YouTubeVideoProvider(new HDVideoQuality());
youtubeVideoProvider.Playback("video1.mp4");


IVideoProvider twichVideoProvider = new TwitchVideoProvider(new FhdVideoQuality());
twichVideoProvider.Playback("video2.mp4");