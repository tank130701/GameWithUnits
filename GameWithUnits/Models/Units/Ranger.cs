using GameWithUnits.Models.Logic;

namespace GameWithUnits.Models.Units;

class Ranger : IRangedUnit
{
    public int Range=>Range;
    public int RangedDamage => RangedDamage;
    public string Name => "Ranger";
    public int Armor => Armor;
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