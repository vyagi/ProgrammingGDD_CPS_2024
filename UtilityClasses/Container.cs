namespace UtilityClasses;

public abstract class Container
{
    private readonly int _capacity;
	private int _contentLevel;

	public Container(int capacity)
	{
        if (capacity < 0)
            throw new ArgumentException(nameof(capacity), "Capacity cannot be negative");

        _capacity = capacity;
	}

	public void Add(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(nameof(amount), "Amount cannot be negative");

        _contentLevel += amount;

		if (_contentLevel > _capacity)
			_contentLevel = _capacity;
    }

	public void Remove(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(nameof(amount), "Amount cannot be negative");

        _contentLevel -= amount;

        if (_contentLevel < 0)
            _contentLevel = 0;
    }

    public int ContentLevel => _contentLevel;
}