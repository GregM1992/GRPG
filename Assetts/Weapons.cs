using GRPG.Models;


namespace GRPG.Assetts
{
    public class Weapons
    {
        List<Weapon> weapons = new()
{
    new Weapon()
    {
        Id = 1,
        Name = "Long Sword",
        AttackModifier = 2,
        AttackSpeedModifier = -1,
        MagicModifier = 0,
    },
     new Weapon()
    {
        Id = 2,
        Name = "Magic Staff",
        AttackModifier = 0,
        AttackSpeedModifier = 0,
        MagicModifier = 3,
    },
      new Weapon()
    {
        Id = 3,
        Name = "Dagger",
        AttackModifier = 1,
        AttackSpeedModifier = 3,
        MagicModifier = 0,
    },
};
    }
}
