var myBeautifulCup = new Cup(300);
myBeautifulCup.Add(100);
myBeautifulCup.Pour(70);
Console.WriteLine(myBeautifulCup.LiquidLevel);

var coffeeMachine = new CoffeeMachine("Krups 1000", 1500, 1200);
coffeeMachine.AddGrains(700);
coffeeMachine.AddWater(1000);

coffeeMachine.MakeEspresso(myBeautifulCup);

Console.WriteLine(myBeautifulCup.LiquidLevel);

public class CoffeeMachine
{
    private readonly string _modelName;
    private readonly int _coffeeGrainsCapacity;
    private readonly int _waterCapacity;

    private int _grainsLevel;
    private int _waterLevel;
    private int _espressosMade;

    public CoffeeMachine(string modelName, int coffeeGrainsCapacity, int waterCapacity)
    {
        _modelName = modelName;
        _coffeeGrainsCapacity = coffeeGrainsCapacity;
        _waterCapacity = waterCapacity;
    }

    public void AddGrains(int amount)
    {
        _grainsLevel += amount;

        if (_grainsLevel > _coffeeGrainsCapacity)
            _grainsLevel = _coffeeGrainsCapacity;
    }

    public void AddWater(int amount)
    {
        _waterLevel += amount;

        if (_waterLevel > _waterCapacity)
            _waterLevel = _waterCapacity;
    }

    public void MakeEspresso(Cup cup)
    {
        if (_grainsLevel > 50 && _waterLevel > 300)
        {
            _grainsLevel -= 18;
            _waterLevel -= 30;
            _espressosMade++;
            cup.Add(30);
        }
    }
}

public class Cup
{
    private readonly int _capacity;
	private int _liquidLevel;

	public Cup(int capacity)
	{
        if (capacity < 0)
            throw new ArgumentException(nameof(capacity), "Capacity cannot be negative");

        _capacity = capacity;
	}

	public void Add(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(nameof(amount), "Amount cannot be negative");

        _liquidLevel += amount;

		if (_liquidLevel > _capacity)
			_liquidLevel = _capacity;
    }

	public void Pour(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(nameof(amount), "Amount cannot be negative");

        _liquidLevel -= amount;

        if (_liquidLevel < 0)
            _liquidLevel = 0;
    }

    public int LiquidLevel => _liquidLevel;
}