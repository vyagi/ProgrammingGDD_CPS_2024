using LinqPractice;

var musicians = MusicData.Musicians;

//Using Distinct, GroupBy, Any and All
//#2
var task2 = musicians.GroupBy(x => x.Instruments.Count);
foreach (var subcollection in task2)
{
    Console.WriteLine(subcollection.Key);
    foreach (var musician in subcollection)
    {
        Console.WriteLine($"{musician.Name}");
    }
}

//#6
// var task6 = musicians.Select(x => x.BirthDate.Year).Distinct().OrderBy(x=>x);
// foreach (var element in task6)
//     Console.WriteLine(element);

//#4
// var task4 = musicians.All(x => x.Hobbies.Count >= 1);
// Console.WriteLine(task4);

//#3
// var task3 = musicians.Any(x => x.Height > 200);
// Console.WriteLine(task3);

//Retrieving specific elements from the collection
//#17
// var task17 = musicians.TakeWhile(x => x.Name.Contains("e"));
// foreach (var element in task17)
//     Console.WriteLine(element);

//#13
// var task13 = musicians.Where(x => x.Height < 170).Take(2);
// foreach (var element in task13)
//     Console.WriteLine(element);

//#10a (I will only keep 3 of the remaining)
// var task10a = musicians.Skip(5).Take(3);
// foreach (var element in task10a)
//     Console.WriteLine(element);

//#8
//var task8 = musicians.LastOrDefault(x => x.Hobbies.Count > 3);
//Console.WriteLine(task8);

//#2
// var task2 = musicians.First(x => x.Height > 180);
// Console.WriteLine(task2);

//Projection (Select), ordering (OrderBy) and filtration (Where)

//#13
// var task13 = musicians
//     .OrderBy(x => x.BirthDate.Year)
//     .ThenBy(x => x.Name);
//
// foreach (var element in task13)
//     Console.WriteLine(element);

//#11
// var task11 = musicians.OrderBy(x => x.Name);
// foreach (var element in task11)
//     Console.WriteLine(element);

//#7
// var task7 = musicians.Select(x => x.Name.Split(" ").Length);
// foreach (var element in task7)
//     Console.WriteLine(element);

//#6
//var task6 = musicians.Select(x => x.Name);
//foreach (var element in task6)
//    Console.WriteLine(element);

//#5
//var task5 = musicians.Where(x => x.Instruments.Contains("Guitar"));
//foreach (var element in task5)
//    Console.WriteLine(element);

//#1
// var task1 = musicians.Where(x => !x.DateOfDeath.HasValue);
// foreach (var element in task1)
//     Console.WriteLine(element);

//Basic Linq features
//#8
// var task8 = musicians
//     .Count(x => DateTime.Today.Year - x.BirthDate.Year > 50);
// Console.WriteLine(task8);

//#6
//var task6 = musicians.Max(x => x.BirthDate);
//Console.WriteLine(task6);

//#3
//var task3 = musicians.Average(x => x.Height);
//Console.WriteLine(task3);

//#1
// var task1 = musicians.Count();
// Console.WriteLine(task1);

// foreach (var element in musicians)
//     Console.WriteLine(element);