using GRPG.Models;

namespace GRPG.Assetts
{
    public class CharacterClasses
    {
       public static List<CharacterClass> characterClasses = new()
        {
            new CharacterClass()
            {
                Id = 1,
                Name = "Knight",
                Description = "A tough warrior with high damage and defense but is weak to magic.",
                Weapon = "Long Sword",
                Armor = "Chain Mail",
                Attack = 8,
                Defense = 7,
                AttackSpeed = 4,
                Magic = 1,
            },
            new CharacterClass()
            {
                Id = 2,
                Name = "Mage",
                Description = "A magic user with medium attack speed but high magic.",
                Weapon = "Magic Staff",
                Armor = "Silk Robe",
                Attack = 2,
                Defense = 3,
                AttackSpeed = 5,
                Magic = 9,
            },
            new CharacterClass()
            {
                Id = 3,
                Name = "Rogue",
                Description = "A quick warrior that has incredibly high attack speed.",
                Weapon = "Dagger",
                Armor = "Leather Armor",
                Attack = 5,
                Defense = 6,
                AttackSpeed = 10,
                Magic = 1,
            }
        };
    }
}
