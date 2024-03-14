namespace GameWithUnits.Models.Units;

public interface IUnit
{
    public string Name {get;}
    private int Armor{get=>Armor;}
    private int Hp { get=>Hp; set{;}}
    public void Attack(IUnit target);
    private void TakeDamage(int amount){}
    // Метод для проверки смерти
    public bool IsDead();
}
