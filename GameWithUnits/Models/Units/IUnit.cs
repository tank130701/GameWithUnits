namespace GameWithUnits.Models.Units;

public interface IUnit
{
    public string Name {get;}
    public int Armor{get;}
    public int AttackPower{get=>AttackPower;}
    public int Hp {get => Hp;}
    public void Attack(IUnit target);
    public void TakeDamage(int amount){}
    public bool IsDead();
}
