using Godot;

public partial class LevelParams
{
	public readonly int EnemyChance;
	public readonly int PickupChance;

	public LevelParams(int enemyChance = 33, int pickupChance = 70)
	{
		EnemyChance = enemyChance;
		PickupChance = pickupChance;
	}
}
