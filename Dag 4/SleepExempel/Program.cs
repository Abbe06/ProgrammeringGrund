string meddelande = "Hej. Detta är ett meddelande. Tack för att du läste denna meddelandet.";

for (int i = 0; i < meddelande.Length; i++ )
{
    Console.Write(meddelande[i]);
    //Tänk på att det är jämförelse mellan char, inte string
    if (meddelande[i] == '.')
        Thread.Sleep(1000);
    else
        Thread.Sleep(100);

}
Console.ReadKey();
