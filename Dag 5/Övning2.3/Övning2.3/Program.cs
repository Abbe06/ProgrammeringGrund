void CountDown(int number)
{
    Console.WriteLine(number);

    if (number > 1)
    {
        CountDown(number - 1);
    }
}

CountDown(10);
Console.ReadKey();
