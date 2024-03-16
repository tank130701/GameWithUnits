using System.Dynamic;
using GameWithUnits.Models.Logic;

namespace GameWithUnits.Models.Units;

class MeleeUnit : IMeleeUnit
{
    public string Name => "Swordsman";
    public int Armor => Armor;
    public int AttackPower => AttackPower;
    private int _hp;
    public int Hp {get=>_hp; set{_hp = value;}}
    public void Attack(IUnit target)
    {
        this.PerformMeleeAttack(target);
    }
    public void TakeDamage(int amount)
    {
        Hp -= amount;
    }
    bool IUnit.IsDead()
    {
        return Hp <= 0;
    }
}