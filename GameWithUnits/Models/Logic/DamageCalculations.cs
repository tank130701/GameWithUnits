using GameWithUnits.Models.Units;

namespace GameWithUnits.Models.Logic;

public static class DamageCalculations
{
    public static void PerformMeleeAttack(this IUnit attacker, IUnit target)
    {
        int damage = attacker.CalculateMeleeDamage(target);
        target.TakeDamage(damage);
    }

    public static int CalculateMeleeDamage(this IUnit attacker, IUnit target)
    {
        Random random = new Random();
        int damage = random.Next(attacker.AttackPower-5, attacker.AttackPower+5);
        // Уменьшаем урон на значение брони цели, но не меньше нуля
        damage -= target.Armor;
        return Math.Max(damage, 0);
    }
}
