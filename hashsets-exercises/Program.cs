// Hashset exercise
Console.WriteLine("---------------------------------------");
Console.WriteLine("Exercise 1");
Console.WriteLine("---------------------------------------\n");

var setA = new HashSet<int>() {  1, 3, 5, 6, 7};
var setB = new HashSet<int>() { 1, 4, 7, 6, 10, 12, 11, 15 };
var setC = new HashSet<int>() { 1, 4, 7, 10, 11, 15, 20 };
var setD = new HashSet<int>() { 15, 20 };

setA.Add(11);

Console.WriteLine("Added 11 to setA\n");
foreach (var i in setA)
{
    Console.WriteLine(i); // Just to show that 11 was indeed added to setA
}

Console.WriteLine("\n");

setA.UnionWith(setB);

Console.WriteLine("Union setA with setB\n");
foreach (var i in setA)
{
    Console.WriteLine(i); // There are no duplicated numbers!
}

Console.WriteLine("\n");

setC.ExceptWith(setA); // setC will only contain values that are not in setA

Console.WriteLine("setC ExeptWith setA\n");
foreach(var i in setC)
{
    Console.WriteLine(i);

}

    Console.WriteLine("\n");

setC.IntersectWith(setD); // Checks what value in setC matches with setD and only keeps duplicated values
Console.WriteLine("setC IntersectWith setD\n");
foreach (var i in setC)
{
    Console.WriteLine(i);
}

// Another exercise
Console.WriteLine("\n");
Console.WriteLine("---------------------------------------");
Console.WriteLine("Exercise 2");
Console.WriteLine("---------------------------------------\n");

var listOfStrings = new List<string>() { "Daniela", "Kevin", "Charlie", "Knut" };

HashSet<string> hSet = new HashSet<string>(listOfStrings);

hSet.Add("Pelle");

foreach (var i in hSet)
{
    Console.WriteLine(i);
}

if (hSet.Contains("Knut"))
{
    hSet.Remove("Knut");
}

//var removed = hSet.Remove("Knut"); // Another way of removing

Console.WriteLine("\nRemoved Knut from list\n");

foreach (var i in hSet)
{
    Console.WriteLine(i);
}

hSet.TryGetValue("Daniela", out var aString); // Used to reach a variable inside a hashset

Console.WriteLine("\n");
Console.WriteLine(aString);

// Another exercise
Console.WriteLine("\n");
Console.WriteLine("---------------------------------------");
Console.WriteLine("Exercise 3");
Console.WriteLine("---------------------------------------\n");

HashSet<string> setA2 = new HashSet<string>() { "A", "B", "C", "D" };
HashSet<string> setB2 = new HashSet<string>() { "A", "B", "C", "D", "E" };

Console.WriteLine("setB isProperSubsetOf setA?");
Console.WriteLine(setB2.IsProperSubsetOf(setA2)); // setA does not contain everything setB has
Console.WriteLine("\nsetB isProperSuperSetOf setA?");
Console.WriteLine(setB2.IsProperSupersetOf(setA2)); // setB contains everything setA has