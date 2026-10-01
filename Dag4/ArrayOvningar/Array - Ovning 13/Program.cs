//Bygger karta med tvådimensionell array
string[,] karta = new string[4, 2];
karta[0, 0] = "Ö";
karta[1, 0] = "Hav";
karta[2, 0] = "Hav";
karta[3, 0] = "Skog";
karta[0, 1] = "Hav";
karta[1, 1] = "Hav";
karta[2, 1] = "Skog";
karta[3, 1] = "Skog";

//Fråga användare om position
Console.WriteLine("Skriv in en X-koordinat (0 - 3)");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in en Y-koordinat (0 - 1)");
int y = int.Parse(Console.ReadLine());

//Visa vad finns på den valda position
Console.WriteLine($"På denna ruta finns {karta[x,y]}");