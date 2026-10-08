//input ränta, insats, mål
double insats, ränta, mål;

Console.WriteLine("Hur stor är insats i banken?");
insats = double.Parse(Console.ReadLine());

Console.WriteLine("Vad är räntan (i %) ?");
ränta = 1 + double.Parse(Console.ReadLine()) / 100.0;

Console.WriteLine("Vilket insatsvärde vill du nå?");
mål = double.Parse(Console.ReadLine());

int år = 0;
//loopa och kontrollera har vi uppfyll mål
do
{
    insats *= ränta;
    ++år;
}
while (insats < mål);

//när vi har gjort det skriva ut antal år och insats värde
Console.WriteLine($"I {år} år insatsvärde kommer att vara {insats}.");
