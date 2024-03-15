using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

internal class MiddleLvlFactory : ArmyFactory
{
    public override Unit CreateMelee() => Unit.CreateUnit("MeleeCreep", 25, 30, 5, 700);
    public override Unit CreateRanged() => Unit.CreateUnit("RangedCreep", 28, 34, 2, 500);
    public override Unit CreateSiege() => Unit.CreateUnit("SiegeCreep", 45, 55, 5, 1200);
}