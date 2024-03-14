namespace GameWithUnits.Models.Units;

public interface IRangedUnit : IUnit
{
    public int Range{get;}
    public int RangedDamage{get;}
    public void RangedAttack(IUnit target);
}
