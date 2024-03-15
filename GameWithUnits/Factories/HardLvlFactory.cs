using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

internal class HardLvlFactory : ArmyFactory
{
    public override Unit CreateMelee() => Unit.CreateUnit("MeleeCreep", 35, 40, 10, 900);
    public override Unit CreateRanged() => Unit.CreateUnit("RangedCreep", 38, 44, 5, 700);
    public override Unit CreateSiege() => Unit.CreateUnit("SiegeCreep", 60, 70, 10, 1500);
}