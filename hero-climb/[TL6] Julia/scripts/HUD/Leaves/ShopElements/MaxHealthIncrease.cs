using Godot;

public partial class MaxHealthIncrease : ShopElement
{
	static int Price;
	static int Increase;

	static int HealthIncrease = 20;

    public override void AffectPlayer()
    {
        PlayerGlobal.GetSetPlayerMaxHealth(HealthIncrease);
    }

	public override int Buy(int Money, bool playsound = true)
	{
		int Output = base.Buy(Money, false);

		return Output;
	}

	public static void Reset(Controller.ClassType selector)
	{
		Price = GameDifficultyHandler.Instance().ShopElementParams(ShopElementFactory.ShopElementEnum.MaxHealthIncrease).BaseCost[selector];
		Increase = GameDifficultyHandler.Instance().ShopElementParams(ShopElementFactory.ShopElementEnum.MaxHealthIncrease).CostIncrease[selector];
	}

	public MaxHealthIncrease() : base(Price, Increase)
	{
	}

	public override void _Ready()
	{
		GetNode<Button>("Button").Pressed += ButtonPressed;
		base._Ready();
	}

	public override void _ExitTree()
	{
		Price = CurrentPrice;
	}
}
