namespace GameWithUnits.Models.Units;

abstract class Unit(string name, int minDamage, int maxDamage, int armor, int hp)
{
    public readonly string Name = name;
    public readonly int MinDamage = minDamage;
    public readonly int MaxDamage = maxDamage;
    public readonly int Armor = armor;
    public int Hp { get; protected set; } = hp;
    
    // Метод для атаки
    public void Attack(Unit target)
    {
        Random random = new Random();
        // Вычисляем урон в диапазоне от минимального до максимального
        int damage = random.Next(MinDamage, MaxDamage);
        // Уменьшаем урон на значение брони цели, но не меньше нуля
        damage -= target.Armor;
        damage = Math.Max(damage, 0);
        // Уменьшаем здоровье цели на полученный урон
        target.GetDamage(damage);    
    }

    // Метод для уменьшения здоровья
    public void GetDamage(int amount)
    {
        Hp -= amount;
    }

    // Метод для проверки смерти
    public bool IsDead()
    {
        return Hp <= 0;
    }
}