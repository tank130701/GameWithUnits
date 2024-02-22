namespace GameWithUnits.Models.Units;

abstract class Unit(string name, int damage = 30, int armor = 8, int hp = 300)
{
    public readonly string Name = name;
    public readonly int Damage = damage;
    public readonly int Armor = armor;
    public int HP { get; protected set; } = hp;

    public void MinusHP()
    {
        HP--;
    }
 
    public bool Death()
    {
        return HP == 0;
    }
}