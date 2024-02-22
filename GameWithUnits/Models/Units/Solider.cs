namespace GameWithUnits.Models.Units;

class Soldier : Unit, IPerson
{
    public Soldier(int damage = 15, int armor = 18, int hp = 100) : base("солдат", damage, armor, hp) { }
}
