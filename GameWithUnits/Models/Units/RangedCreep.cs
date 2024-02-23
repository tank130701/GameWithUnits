namespace GameWithUnits.Models.Units;

class RangedCreep(int minDamage = 21, int maxDamage = 26, int armor = 0, int hp = 300)
    : Unit("Крип-маг", minDamage, maxDamage, armor, hp), IPerson {}