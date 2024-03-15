using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

// Конкретные фабрики
internal class EazyLvlFactory : ArmyFactory
{
    public override Unit CreateMelee() => Unit.CreateUnit("MeleeCreep", 19, 23, 2, 550);
    public override Unit CreateRanged() => Unit.CreateUnit("RangedCreep", 21, 26,0, 300);
    public override Unit CreateSiege() => Unit.CreateUnit("SiegeCreep", 35, 46,0, 935);
}



