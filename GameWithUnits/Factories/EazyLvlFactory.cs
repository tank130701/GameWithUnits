using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

// Конкретные фабрики
internal class EazyLvlFactory : IFactory
{
    public List<Unit> Create()
    {
        return
        [
            Unit.CreateUnit("MeleeCreep", 19, 23, 2, 550),
            Unit.CreateUnit("MeleeCreep", 19, 23, 2, 550),
            Unit.CreateUnit("MeleeCreep", 19, 23, 2, 550),
            Unit.CreateUnit("MeleeCreep", 19, 23, 2, 550),
            Unit.CreateUnit("MeleeCreep", 19, 23, 2, 550),
            Unit.CreateUnit("RangedCreep", 21, 26, 0, 300),
            Unit.CreateUnit("SiegeCreep", 35, 46, 0, 935)
        ];
    }
}



