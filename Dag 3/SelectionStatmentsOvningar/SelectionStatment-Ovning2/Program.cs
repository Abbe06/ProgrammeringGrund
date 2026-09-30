Console.WriteLine("Hur gammal är du? Svara i år.");
int ålder = int.Parse(Console.ReadLine());
Console.WriteLine("Hur mycket tjänar du per månad? Svara i kronor.");
int inkomst = int.Parse(Console.ReadLine());

if(ålder == 39)
    Console.WriteLine("Du är lika gammal som medelpersonen i Göteborg");
else if (ålder > 39)
    Console.WriteLine("Du är äldre än medelpersonen i Göteborg");
else
    Console.WriteLine("Du är yngre än medelpersonen i Göteborg");

if(inkomst == 36100)
    Console.WriteLine("Du tjänar lika mycket som medellönen är i Sverige");
else if (inkomst > 36100)
    Console.WriteLine("Du tjänar mer i lön än medellönen är i Sverige");
else
    Console.WriteLine("Du tjänar mindre i lön än medellönen är i Sverige");