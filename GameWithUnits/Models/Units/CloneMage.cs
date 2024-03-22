namespace GameWithUnits.Models.Units;

class CloneMage (int minDamage = 19, int maxDamage = 23, int armor = 2, int hp = 550)
    : Unit("Clone mage", minDamage, maxDamage, armor, hp), IPerson, ICloneableUnit
{
    ICloneableUnit ICloneableUnit.Clone()
    {
        CloneMage other = (CloneMage) this.MemberwiseClone();
        return other;
    }
}