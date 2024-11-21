namespace UtilityClasses;

public class WaterContainer : Container
{
	public bool IsTransparent { get; private set; }

	public WaterContainer(int capacity, bool isTransparent) : base(capacity)
	{
		IsTransparent = isTransparent;
	}
}
