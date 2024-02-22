using GameWithUnits.Models.Army;
using GameWithUnits.Models.Units;

namespace GameWithUnits;

static class Program
{
    static void Main()
    {
        List<Unit> unitsOne = new List<Unit>()
        {
            new Soldier(36, 22, 180),
            new Ballista(),
            new Ballista(48, 12, 270)
        };
        Army armyOne = new Army("Королевство кривых кулис", unitsOne);
 
        List<Unit> unitsTwo = new List<Unit>()
        {
            new Ballista(),
            new Ballista(33, 8, 450),
            new Catapult(),
            new Soldier(200, 100, 1000)
        };
        Army armyTwo = new Army("Рыцари чести", unitsTwo);
 
        while (armyTwo.TakingDamage(armyOne.TotalDamage()) && armyOne.TakingDamage(armyTwo.TotalDamage()));
 
        Console.ReadKey();
    }
}