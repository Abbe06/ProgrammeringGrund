//Ex1
using System.Collections.ObjectModel;

//Collection<int> myColl = [2,3,4,5];


//foreach (var i in myColl)
//{
//    Console.WriteLine(i);
//}

//Ex2
Collection<string> myColl = ["Apple","Banana","Fruit"];

// Copy to one-dimensional array
string[] arr = new string[myColl.Count];
myColl.CopyTo(arr, 0);

foreach (var item in arr)
{
    Console.WriteLine(item);
    
}
