Console.WriteLine("Vilket är Europas folkrikaste land?");
string svar = Console.ReadLine().ToLower();
int antalGissningar = 1;

//Fel svar, ge feedback, ++antalgissnigar
while(svar !="tyskland")
{
    //Kontrollera antalgissningar och avsluta om det är lika med eller mer än 5
    if(antalGissningar >= 5)
    {
        Console.WriteLine("Dina gissningar är slut, programmet avslutas...");
        break;
    }
    //Om antal gissningar är under 5 visa att det är fel svar och låta användaren prova igen
    Console.WriteLine("Fel svar, försök igen!");
    svar = Console.ReadLine().ToLower();
    antalGissningar++; 
}

//Korrekt svar
if( svar == "tyskland" )
    Console.WriteLine("Ditt svar är rätt");

    


