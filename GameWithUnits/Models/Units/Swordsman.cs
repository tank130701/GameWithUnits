using GameWithUnits.Models.Logic;

namespace GameWithUnits.Models.Units;

class MeleeUnit : IMeleeUnit
{
    public string Name => "Swordsman";
    public int Armor => 10;
    public int AttackPower => 25;
    public int Hp;
    public void Attack(IUnit target)
    {
        this.PerformMeleeAttack(target);
    }
    public void TakeDamage(int amount){}
    bool IUnit.IsDead()
    {
        return Hp <= 0;
    }
}