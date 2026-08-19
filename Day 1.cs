using System.Runtime.Intrinsics.Wasm;
List<string> names = new List<string>
{ 
    "Arun","Kavi","Rahul","Anu","Aisha"
};

var Result = names.Where(name => name.StartsWith("A"));

foreach (var res in Result)
{
   Console.WriteLine(res);
}
Console.ReadLine();

//select method

List<int> num = new List<int>
{
   3,5,7,9
    };

var Out = num.Select(n => n + 10);

foreach(var ouput in Out)
{
    Console.WriteLine(ouput);
}
Console.ReadLine();


List<int> numbers = new List<int>
{
    25,5,40,15,30
};

var result = numbers.OrderByDescending(n => n);

foreach(var number in result)
{
    Console.WriteLine(number);
}
Console.ReadLine();

List<string> Fruits = new List<string>
{
    "Apple","Orange","Grapes","Watermelon"
};

var Return = Fruits.First();
Console.WriteLine(Return);