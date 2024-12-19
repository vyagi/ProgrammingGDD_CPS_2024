//var point = new Point(1, 2);

//point.Move(4, 5);
//point.Move(new Vector(3, 5));

//Console.WriteLine($"{point.X},{point.Y}");


//var vector = new Vector(3, 1);
//Console.WriteLine(vector.Length());
//Console.WriteLine($"{vector.X},{vector.Y}");

//vector.Scale(2);
//Console.WriteLine(vector.Length());
//Console.WriteLine($"{vector.X},{vector.Y}");

//var rectangle = new Rectangle(3, 1);
//Console.WriteLine($"{rectangle.SideA},{rectangle.SideB}");

//rectangle.Scale(2);
//Console.WriteLine($"{rectangle.SideA},{rectangle.SideB}");

//var device = new Device();
//Console.WriteLine(device.IsOn);
//device.Toggle();
//Console.WriteLine(device.IsOn);
//device.Work();
//device.Work();
//device.Work();
//device.Work();
//Console.WriteLine(device.IsBroken);
//device.Fix();
//Console.WriteLine(device.IsBroken);
//device.Work();
//device.SwitchOff();
//Console.WriteLine(device.IsOn);
//device.Work();

var fr = new FixedRectangle(1, 2, new Point(2, 3));
fr.Move(-2, -3);
Console.WriteLine($"{fr.PointOfAttachment.X},{fr.PointOfAttachment.Y}");
Console.WriteLine(fr.PointOfAttachment.IsInOrigin);