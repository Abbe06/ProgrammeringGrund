// Läs in input - användarens namn och ålder
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine().ToLower();
Console.WriteLine("Hur gammal är du? Svara i hela antal år");
int ålder = int.Parse(Console.ReadLine());

//kontrollera användarens grupp
if(namn == "felicia" || namn == "felix" )
    Console.WriteLine("Du har namnsdag idag, idag får du gå ombord först!");
else if (ålder > 75)
    Console.WriteLine("På grund av din ålder får du ombord i grupp två.");
else if (ålder >= 18 && ålder <= 25)
    Console.WriteLine("Unga vuxna får ombord i grupp tre.");
else
    Console.WriteLine("Du är välkommen ombord i grupp fyra.");

Console.ReadKey();