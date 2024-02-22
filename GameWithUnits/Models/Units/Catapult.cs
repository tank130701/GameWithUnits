namespace GameWithUnits.Models.Units;

class Catapult(int damage = 30, int armor = 8, int hp = 300) : Unit("катупульта", damage, armor, hp), IMechanism;
