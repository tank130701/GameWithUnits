namespace GameWithUnits.Models.Units;

class SiegeCreep(int minDamage = 35, int maxDamage = 46, int armor = 0, int hp = 935)
    : Unit("Катапульта", minDamage, maxDamage, armor, hp), IMechanism {}
