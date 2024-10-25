namespace FlyweightPattern
{
    public static class PlayersFactory
    {
        private static readonly Dictionary<PlayerType, IPlayer> InMemoryCachedPlayers = new();

        public static IPlayer GetPlayer(PlayerType playerType)
        {
            if (InMemoryCachedPlayers.ContainsKey(playerType))
            {
                return InMemoryCachedPlayers[playerType];
            }

            IPlayer player = playerType switch
            {
                PlayerType.MAIN_PLAYER => new MainPlayer("Default Main Player"),
                PlayerType.WEAK_ENEMY => new Enemy(1, 10),
                PlayerType.STRONG_ENEMY => new Enemy(5, 50),
                _ => throw new NotSupportedException("Unsupported player type")
            };

            InMemoryCachedPlayers[playerType] = player;
            return player;
        }
    }
}
