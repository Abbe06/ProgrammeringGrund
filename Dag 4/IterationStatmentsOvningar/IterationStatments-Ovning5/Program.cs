Console.WriteLine("Ange numret som tillägget görs till:");
int n = int.Parse(Console.ReadLine());
int sum = 0, fact = 1;

for (int i = 1; i <= n; i++)
{
    sum += i;
    fact *= i;
}

Console.WriteLine($"Summan av talen från 1 till {n} är {sum}");
//Console.WriteLine("Summan av talen från 1 till {0} är {1}", n, sum);
Console.WriteLine($"Fakultet är {fact}");

