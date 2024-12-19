public class Device : ISwitchable, IFixable
{
    private int _usages;

    public bool IsBroken { get; private set; }

    public bool IsOn { get; private set; }

    public void SwitchOff() => IsOn = false;

    public void SwitchOn() => IsOn = true;

    public void Toggle() => IsOn = !IsOn;

    public void Work()
    {
        if (!IsOn || IsBroken) return;
     
        Console.WriteLine("Working..");
        _usages++;

        if(_usages > 2)
            IsBroken = true;
    }

    public void Fix()
    {
        _usages = 0;
        IsBroken = false;
    }
}

public class Rectangle : IScalable
{
    public double SideA { get; protected set; }

    public double SideB { get; protected set; }

    public Rectangle(double sideA, double sideB) => (SideA, SideB) = (sideA, sideB);

    public void Scale(double coefficient)
    {
        SideA *= coefficient; 
        SideB *= coefficient;
    }
}

public class Point : IMoveable
{
    public double X { get; private set; }

    public double Y { get; private set; }

    public Point(double x, double y) => (X, Y) = (x, y);

    public bool IsOnAxis => X == 0 || Y == 0;

    public bool IsInOrigin => X == 0 && Y == 0;

    public void Move(double x, double y) 
    { 
        X += x;
        Y += y;
    }

    public void Move(Vector vector) 
    {
        X += vector.X;
        Y += vector.Y;
    }
}

public class Vector : IScalable
{
    public double X { get; private set; }

    public double Y { get; private set; }

    public Vector(double x, double y) => (X, Y) = (x, y);

    public double Length() => Math.Sqrt(X * X + Y * Y);

    public void Scale(double coefficient)
    {
        X *= coefficient;
        Y *= coefficient;
    }

    public bool IsVertical => X == 0;

    public bool IsHorizontal => Y == 0;
}

public interface IMoveable
{
    void Move(double x, double y);

    void Move(Vector vector);
}

public interface IScalable
{
    void Scale(double coefficient);
}

public interface ISwitchable
{
    void SwitchOn();
    void SwitchOff();
    void Toggle();
}

public interface IFixable
{
    void Fix();

    bool IsBroken { get; }
}

public interface IRechargeable
{
    void Recharge();
    double BatteryLevel { get; }
}

public class FixedRectangle : Rectangle, IMoveable
{
    public Point PointOfAttachment { get; protected set; }

    public FixedRectangle(double sideA, double sideB, Point point) : base(sideA, sideB)
    {
        PointOfAttachment = point;
    }

    public void Move(double x, double y) => PointOfAttachment.Move(x, y);

    public void Move(Vector vector) => PointOfAttachment.Move(vector);
}