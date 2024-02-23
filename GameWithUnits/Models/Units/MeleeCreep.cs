namespace GameWithUnits.Models.Units;

class MeleeCreep(int minDamage = 19, int maxDamage = 23, int armor = 2, int hp = 550)
    : Unit("Крип-мечник", minDamage, maxDamage, armor, hp), IPerson {}


