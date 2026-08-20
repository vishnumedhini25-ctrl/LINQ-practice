List<string> names = new List<string>
{
    "Tom",
    "Teddy",
    "Kaviya",
    "Ravi"
};

var Result = names.FirstOrDefault(n => n.StartsWith("Z"));
Console.WriteLine(Result == null);
Console.ReadLine();

var LAST = names.Last();
Console.WriteLine(LAST);
Console.ReadLine();

List<string> Sports = new List<string>
{
    "Table Tennis",
    "Basketball",
    "Football",
    "Tennis","valleyball","Basketball","Hockey"
};
bool result = Sports.Any(s => s.StartsWith("B"));

Console.WriteLine(result);
Console.ReadLine();

var Dup = Sports.Distinct();

foreach (var name in Dup)
{
    Console.WriteLine(name);
}
Console.ReadLine();

int count = Sports.Count();

Console.WriteLine(count);
Console.ReadLine();

List<int> marks = new List<int>
{
    10, 20, 30, 40
};

int add = marks.Sum();

Console.WriteLine(add);
Console.ReadLine();

double average = marks.Average();
Console.WriteLine(average);
Console.ReadLine();

int max = marks.Max();
Console.WriteLine(max);
Console.ReadLine();

int min = marks.Min();
Console.WriteLine(min); 
Console.ReadLine();