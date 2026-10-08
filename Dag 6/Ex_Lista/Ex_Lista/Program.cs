//Skapar list objekt med List class konstruktör 
List<int> my_list =
[
    //Adda elements to list
    1,
    10,
];
my_list.AddRange(100, 1000,10000,100000,1000000);
List<int> my_list2 = [];
my_list2.AddRange(496,1000,10,10000,100,193);

foreach (var item in my_list)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Intial count: {my_list.Count}");

//Remove() metod
my_list.Remove(10);
Console.WriteLine($"2nd count: {my_list.Count}");
foreach (var item in my_list)
{
    Console.WriteLine(item);
}

//RemoveAt()
my_list.RemoveAt(4);
Console.WriteLine($"3nd count: {my_list.Count}");

foreach (var item in my_list)
{
    Console.WriteLine(item);
}

//RemoveRange()
my_list.RemoveRange(0,2);
Console.WriteLine($"4nd count: {my_list.Count}");

foreach (var item in my_list)
{
    Console.WriteLine(item);
}

//Skriv ut Innan sortering
Console.WriteLine($"Intial count: {my_list2.Count}");

foreach (var item in my_list2)
{
    Console.WriteLine(item);
}

//Skriv ut efter sortering
my_list2.Sort();
Console.WriteLine($"Intial count: {my_list2.Count}");

foreach (var item in my_list2)
{
    Console.WriteLine(item);
}