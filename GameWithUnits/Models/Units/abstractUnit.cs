namespace GameWithUnits.Models.Units;

abstract class Unit(string name, int minDamage, int maxDamage, int armor, int hp)
{
    public readonly string Name = name;
    private readonly int _armor = armor;
    private int Hp { get; set; } = hp;
    
    // Метод для атаки
    public int Attack(Unit target)
    {
        Random random = new Random();
        // Вычисляем урон в диапазоне от минимального до максимального
        int damage = random.Next(minDamage, maxDamage);
        // Уменьшаем урон на значение брони цели, но не меньше нуля
        damage -= target._armor;
        damage = Math.Max(damage, 0);
        // Уменьшаем здоровье цели на полученный урон
        target.GetDamage(damage);
        return damage;
    }

    // Метод для уменьшения здоровья
    private void GetDamage(int amount)
    {
        Hp -= amount;
    }

    // Метод для проверки смерти
    public bool IsDead()
    {
        return Hp <= 0;
    }
    
    public static Unit CreateUnit(string type, int minDamage, int maxDamage, int armor, int hp)
    {
        switch (type)
        {
            case "MeleeCreep":
                return new MeleeCreep(minDamage, maxDamage, armor, hp);
            case "RangedCreep":
                return new RangedCreep(minDamage, maxDamage, armor,hp);
            case "SiegeCreep":
                return new SiegeCreep(minDamage, maxDamage, armor, hp);
            default:
                throw new ArgumentException("Invalid unit type", nameof(type));
        }
    }
}