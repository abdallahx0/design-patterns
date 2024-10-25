namespace FlyweightPattern
{
    public class Enemy : IPlayer
    {
        private readonly string _displayName = "Enemy Bot";
        private readonly int _attackPower;
        private readonly int _healthBar;

        public Weapon Weapon { get; set; } = new Weapon("Rifle", 0);
        public string DisplayName => _displayName;
        public int AttackPower => _attackPower;

        public int HealthBar => _healthBar;
        public Enemy(int attackPower, int healthBar)
        {
            Console.WriteLine("Creating Enemy...");
            _attackPower = attackPower;
            _healthBar = healthBar;
        }

        public void Attack()
        {
            Console.WriteLine($"Player: {_displayName} is attacking with weapon: {Weapon.Name} with base attack damage: {_attackPower}");
        }

        public void AssignWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }
    }

}
