using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

internal class MiddleLvlFactory : IFactory
{
    public List<Unit> Create()
    {
        return
        [
            Unit.CreateUnit("MeleeCreep", 25, 30, 5, 700),
            Unit.CreateUnit("MeleeCreep", 25, 30, 5, 700),
            Unit.CreateUnit("MeleeCreep", 25, 30, 5, 700),
            Unit.CreateUnit("MeleeCreep", 25, 30, 5, 700),
            Unit.CreateUnit("MeleeCreep", 25, 30, 5, 700),
            Unit.CreateUnit("RangedCreep", 28, 34, 2, 500),
            Unit.CreateUnit("SiegeCreep", 45, 55, 5, 1200)
        ];
    }
}