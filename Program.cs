using GRPG.Models;

List<CharacterClass> characterClasses = new()
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

List<Weapon> weapons = new()
{
    new Weapon()
    {
        Id = 1,
        Name = "Long Sword",
        AttackModifier = +2,
        AttackSpeedModifier = -1,
        MagicModifier = 0,
    },
     new Weapon()
    {
        Id = 2,
        Name = "Magic Staff",
        AttackModifier = 0,
        AttackSpeedModifier = 0,
        MagicModifier = +3,
    },
      new Weapon()
    {
        Id = 3,
        Name = "Dagger",
        AttackModifier = +1,
        AttackSpeedModifier = +3,
        MagicModifier = 0,
    },
};

List<Armor> armors = new()
{
    new Armor()
    {
        Id = 1,
        Name = "Chain Mail",
        AttackSpeedModifier = -1,
        DefenseModifier = +3,
    },
    new Armor()
    {
        Id = 2,
        Name = "Silk Robe",
        AttackSpeedModifier = +2,
        DefenseModifier = 0,
    },
    new Armor()
    {
        Id = 3,
        Name = "Leather Armor",
        AttackSpeedModifier = +1,
        DefenseModifier = +1,
    },
};

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
        WeakToMagic = false
    }
};