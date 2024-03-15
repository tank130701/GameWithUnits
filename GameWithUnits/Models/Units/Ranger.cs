using GameWithUnits.Models.Logic;

namespace GameWithUnits.Models.Units;

class Ranger : IRangedUnit
{
    public int Range => 5;

    public int RangedDamage => 25;

    public string Name => "Ranger";

    public void Attack(IUnit target)
    {
        throw new NotImplementedException();
    }

    public bool IsDead()
    {
        throw new NotImplementedException();
    }

    public void RangedAttack(IUnit target)
    {
        throw new NotImplementedException();
    }
}