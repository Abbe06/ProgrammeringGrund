Console.WriteLine("Dett är ett omvandlingsprogram.");
string val = "";

while (val != "3")
{
    Console.WriteLine("Välj ett av följande alternativ:");
    Console.WriteLine("1.  Omvandla meter till kilometer");
    Console.WriteLine("2.  Omvandla kilometer till meter");
    Console.WriteLine("3.  Avsluta programmet");
    val = Console.ReadLine();
    switch (val)
    {
        case "1":
            Console.WriteLine("Skiv in en längd i meter");
            double antalMeter = double.Parse(Console.ReadLine());
            Console.WriteLine($"Längden du skrev in är detsamma som {antalMeter/1000} km");
            break;

        case "2":
            Console.WriteLine("Skiv in en längd i km");
            double antalKm = double.Parse(Console.ReadLine());
            Console.WriteLine($"Längden du skrev in är detsamma som {antalKm * 1000} m");
            break;

        case "3":
            Console.WriteLine("Programmet avslutas...");
            break;

        default:
            Console.WriteLine("Du valde inte ett giltigt alternativ!");
            break;
    }
}