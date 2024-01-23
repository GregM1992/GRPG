using GRPG.Models;


namespace GRPG.Assetts
{
    public class Armors
    {
        List<Armor> armors = new()
            {
            new Armor()
            {
                Id = 1,
                Name = "Chain Mail",
                AttackSpeedModifier = -1,
                DefenseModifier = 3,
            },
            new Armor()
            {
                Id = 2,
                Name = "Silk Robe",
                AttackSpeedModifier = 2,
                DefenseModifier = 0,
            },
            new Armor()
            {
                Id = 3,
                Name = "Leather Armor",
                AttackSpeedModifier = 1,
                DefenseModifier = 1,
            },
            };
    }
}
