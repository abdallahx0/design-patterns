namespace FlyweightPattern
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int BonusAttackDamage { get; private set; }

        public Weapon(string name, int bonusAttackDamage)
        {
            Name = name;
            BonusAttackDamage = bonusAttackDamage;
        }
    }
}
