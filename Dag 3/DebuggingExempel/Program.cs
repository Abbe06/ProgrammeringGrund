Console.WriteLine("This program has a loop");
Console.WriteLine("The loop calculates the sum of the numbers 0 to 4");
int sum = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(" Now the value of i is printed");
    Console.WriteLine($"i= {i}");
    sum += i; // sum = sum + i;
}

Console.WriteLine($" The sum of the numbers is {sum}");