namespace GRPG.Models;
public class CharacterClass
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Weapon { get; set; }
	public string Armor { get; set; }
	public int Attack { get; set; }
	public int Defense { get; set;}
	public int AttackSpeed { get; set;}
	public int Magic { get; set;}
}
