namespace FlyweightPattern
{
    public class MainPlayer : IPlayer
    {
        private readonly string _displayName;
        private readonly int _attackPower = 5;
        private readonly int _healthBar = 100;

        public string DisplayName => _displayName;
        public int AttackPower => _attackPower;
        public int HealthBar => _healthBar;

        public Weapon Weapon { get; set; }

        public MainPlayer(string displayName)
        {
            Console.WriteLine("Creating Main Player...");
            _displayName = displayName;
        }

        public void Attack()
        {
            Console.WriteLine($"Player: {_displayName} is attacking with weapon: {Weapon?.Name ?? "None"} with base attack damage: {_attackPower}");
        }

        public void AssignWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }
    }

}
