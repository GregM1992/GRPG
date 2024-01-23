using GRPG.Models;


namespace GRPG.Assetts
{
    public class Enemies
    {
        List<Enemy> enemies = new()
        {
        new Enemy()
        {
            Id = 1,
            Name = "Goblin",
            Description = "A small, green, foul smelling creature. Known for its low intelligence.",
            Health = 25,
            Attack = 3,
            Defense = 0,
            AttackSpeed = 0,
            WeakToMagic = false
        },
        new Enemy()
        {
            Id = 2,
            Name = "Kobold",
            Description = "A quick, merciless creature that is known to travel with a pack.",
            Health = 35,
            Attack = 3,
            Defense = 5,
            AttackSpeed = 7,
            WeakToMagic = true
        },
        new Enemy()
        {
            Id = 3,
            Name = "Skeleton",
            Description = "Held together by binding magic. A high health foe.",
            Health = 40,
            Attack = 6,
            Defense = 4,
            AttackSpeed = 4,
            WeakToMagic = false
        },
        new Enemy()
        {
            Id = 4,
            Name = "Bat",
            Description = "This flying creature is a nuisance to those with low attack speed.",
            Health = 20,
            Attack = 3,
            Defense = 2,
            AttackSpeed = 7,
            WeakToMagic = false
        },
        new Enemy()
        {
            Id = 4,
            Name = "Zombie",
            Description = "Dragged from an eternal rest. This high health creature lacks speed but makes up for it in high damage and defense.",
            Health = 30,
            Attack = 7,
            Defense = 7,
            AttackSpeed = 1,
            WeakToMagic = true
           }
        };


    }
}
