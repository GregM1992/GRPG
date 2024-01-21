namespace GRPG.Models;

public class Enemy
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public int Health { get; set; }
	public int Attack {  get; set; }
	public int Defense { get; set; }
	public int AttackSpeed { get; set; }
	public bool WeakToMagic { get; set; }
}
