using GameWithUnits.Models.Units;

namespace GameWithUnits.Models.Army;

class Army
{
    public readonly List<Unit> Lst;
    public readonly string Name;
 
    public Army(string name, List<Unit> lst)
    {
        Name = name;
        Lst = lst;
    }
 
    public int TotalDamage()
    {
        int total = 0;
        foreach (var unit in Lst)
            total += unit.Damage;
        return total;
    }
 
    public int TotalArmor()
    {
        int total = 0;
        foreach (var unit in Lst)
            total += unit.Armor;
        return total;
    }
 
    public int TotalHP()
    {
        int total = 0;
        foreach (var unit in Lst)
            total += unit.HP;
        return total;
    }
 
    public bool TakingDamage(int otherDamage)
    {
        int totalDamage = otherDamage - TotalArmor();
        for (int i = 0; totalDamage > 0; i = i == Lst.Count - 1 ? 0 : i + 1)
        {
            Lst[i].MinusHP();
            if (Lst[i].Death())
            {
                Console.WriteLine($"Из армии \"{Name}\" погиб {Lst[i].Name}");
                Lst.RemoveAt(i--);
                if (TotalHP() == 0)
                {
                    Console.WriteLine($"Армия \"{Name}\" уничтожена");
                    return false;
                }
            }
        }
        return true;
    }
}