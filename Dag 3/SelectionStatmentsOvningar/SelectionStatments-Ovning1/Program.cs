Console.WriteLine("Vilket land vann fotbolls-VM för damer år 2015?");
string svar = Console.ReadLine().ToLower();
if (svar != "usa")
    Console.WriteLine("Fel svar!");
else
    Console.WriteLine("Rätt svar!");

Console.ReadKey();