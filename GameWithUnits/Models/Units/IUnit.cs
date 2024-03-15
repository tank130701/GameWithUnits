namespace GameWithUnits.Models.Units;

public interface IUnit
{
    public string Name {get;}
    public int Armor{get=>Armor;}
    public int AttackPower{get=>AttackPower; set{;}}
    public int Hp { get=>Hp; set{;}}
    public void Attack(IUnit target);
    public void TakeDamage(int amount){}
    public bool IsDead();
}
