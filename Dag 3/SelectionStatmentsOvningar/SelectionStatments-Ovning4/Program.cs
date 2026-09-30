Console.WriteLine("Hur gammal är du?");
int ålder = int.Parse(Console.ReadLine());

if(ålder > 65 || (ålder >= 10 && ålder <= 18))
    Console.WriteLine("Du får köpa kaffe till ett billigt pris");
else
    Console.WriteLine("Du får köpa kaffe till vårt normala pris");