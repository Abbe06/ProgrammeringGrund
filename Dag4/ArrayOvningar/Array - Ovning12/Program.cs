int[] talLista = { 432, 231, 32, -123, 20 };
int summa = 0;

foreach (var tal in talLista)
{
     summa += tal;
}

Console.WriteLine($"Summan av talen är {summa}");
