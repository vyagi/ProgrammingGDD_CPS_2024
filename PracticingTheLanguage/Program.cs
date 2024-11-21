var myBeautifulCup = new Container(300);
myBeautifulCup.Add(100);
myBeautifulCup.Remove(70);
Console.WriteLine(myBeautifulCup.ContentLevel);

var coffeeMachine = new CoffeeMachine("Krups 1000", 1500, 1200);
coffeeMachine.AddGrains(700);
coffeeMachine.AddWater(1000);

coffeeMachine.MakeEspresso(myBeautifulCup);

Console.WriteLine(myBeautifulCup.ContentLevel);

public class CoffeeMachine
{
    private readonly string _modelName;

    private readonly Container _coffeeContainer;
    private readonly Container _waterContainer;

    private int _espressosMade;

    public CoffeeMachine(string modelName, int coffeeGrainsCapacity, int waterCapacity)
    {
        _modelName = modelName;
        _coffeeContainer = new Container(coffeeGrainsCapacity);
        _waterContainer = new Container(waterCapacity);
    }

    public void AddGrains(int amount) => _coffeeContainer.Add(amount);

    public void AddWater(int amount) => _waterContainer.Add(amount);

    public void MakeEspresso(Container cup)
    {
        if (_coffeeContainer.ContentLevel > 50 && _waterContainer.ContentLevel > 300)
        {
            _coffeeContainer.Remove(18);
            _waterContainer.Remove(30);
            _espressosMade++;
            cup.Add(30);
        }
    }
}
