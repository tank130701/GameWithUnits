namespace GameWithUnits.Models.Units;

class Ballista(int damage = 27, int armor = 10, int hp = 220) : Unit("балиста", damage, armor, hp), IMechanism;