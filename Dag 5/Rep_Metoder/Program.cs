string[] land = new string[] { "Sverige", "Norge", "Danmark", "Finland" };

//Skriv ut alla länder i listan innan sortering
Console.WriteLine("Innan sort: ");
Utskrift();
//Sorterar med Sort method
Console.WriteLine();
Array.Sort(land);

//Skriver ut alla länder i listan efter sortering
Console.WriteLine("Efter sort: ");
Utskrift();

//Testa Reverse
Console.WriteLine();
Array.Reverse(land);
Console.WriteLine("Efter Reverse method:");
Utskrift();

Console.ReadKey();


void Utskrift()
{
    foreach (var l in land)
    {
        Console.WriteLine(l);
    }
}

//Övning 3
CountDown(10);

void CountDown(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    CountDown(number - 1);
}