using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

// Абстрактная фабрика
abstract class ArmyFactory
{
    public abstract Unit CreateMelee();
    public abstract Unit CreateRanged();
    public abstract Unit CreateSiege();
}
