using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

internal class HardLvlFactory : IFactory
{
    public List<Unit> Create()
    {
        return
        [
            Unit.CreateUnit("MeleeCreep", 35, 40, 10, 900),
            Unit.CreateUnit("MeleeCreep", 35, 40, 10, 900),
            Unit.CreateUnit("MeleeCreep", 35, 40, 10, 900),
            Unit.CreateUnit("MeleeCreep", 35, 40, 10, 900),
            Unit.CreateUnit("MeleeCreep", 35, 40, 10, 900),
            Unit.CreateUnit("RangedCreep", 38, 44, 5, 700),
            Unit.CreateUnit("SiegeCreep", 60, 70, 10, 1500)
        ];
    }
}