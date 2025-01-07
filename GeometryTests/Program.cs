//using Geometry;

//var p = new Point(5,1);
//p.Move(1,3);

//Console.WriteLine($"{p.X}, {p.Y}");

//var s = new Segment(p, new Point(-6, 8));

//Console.WriteLine(p.Distance());
//Console.WriteLine(s.Length);

//var s1 = new Segment(new Point(0,0), new Point(3,4));
//Console.WriteLine(s1.Length);

//var pc = new PolygonalChain(new Point(0,0), new Point(1,1));
//Console.WriteLine(pc.Length);

//pc.AddMidpoint(new Point(1,0));
//Console.WriteLine(pc.Length);

//pc.Move(5,5);
//Console.WriteLine(pc.Length);

//Console.WriteLine(pc);
//pc.AddMidpoint(new Point(-8, -7));
//Console.WriteLine(pc);

using Utilities;

var name = "Marcin Jagieła";

Console.WriteLine(StringUtilities.ToWords(name));
Console.WriteLine(StringUtilities.ToWords("The lord of the rings"));

Console.WriteLine(StringUtilities.ToSentence("MaArcIN jagIEła"));

Console.WriteLine(StringUtilities.ToCamelCase("the LorD OF thE Rings"));