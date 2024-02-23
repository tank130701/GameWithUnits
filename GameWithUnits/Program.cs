using GameWithUnits.Models.Army;
using GameWithUnits.Models.Units;

namespace GameWithUnits;

static class Program
{
    static void Main()
    {
        List<Unit> unitsOne = new List<Unit>()
        {
            new MeleeCreep(),
            new MeleeCreep(),
            new MeleeCreep(),
            new MeleeCreep(),
            new MeleeCreep(),
            new RangedCreep(),
            new SiegeCreep(),
        };
        Army armyOne = new Army("Силы света", unitsOne);
 
        List<Unit> unitsTwo = new List<Unit>()
        {
            new MeleeCreep(),
            new MeleeCreep(),
            new MeleeCreep(),
            new MeleeCreep(),
            new MeleeCreep(),
            new RangedCreep(),
            new SiegeCreep(),
        };
        Army armyTwo = new Army("Силы тьмы", unitsTwo);
 
        armyOne.Attack(armyTwo);
 
        Console.ReadKey();
    }
}