//Input av antal sport
Console.WriteLine("Hur många sporter vill du skriva in?");
int antal = int.Parse(Console.ReadLine());

//Deklaration av array av storlek antal
string[] sporter = new string[antal];

//Input av olika sporter till arrayen
for (int i = 0; i < antal; i++)
{
    Console.WriteLine("Skriv in en sport:");
    sporter[i] = Console.ReadLine();
}

//Skriva ut elements i array
Console.WriteLine("Här är de sporter du skrev in:");
foreach (var item in sporter)
{
    Console.WriteLine(item);
}
//for (int i = 0; i < antal; i++)
//{
//    Console.WriteLine(i);
//    Console.WriteLine(sporter[i]);
//}