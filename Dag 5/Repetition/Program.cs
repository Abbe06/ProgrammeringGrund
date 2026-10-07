int[] numbers = { 5, 10, 15, 20, 25 };
int[] numbers2 = { 5, 10, 15 };
//Beräkna genomsnittet
double average = CalculateAverage(numbers);
Console.WriteLine(average);

Console.WriteLine(CalculateAverage(numbers2));
Console.ReadLine();
double CalculateAverage(int[] array)
{
        if (array == null || array.Length == 0)
        {
            // Om arrayen är tom eller null, returnera 0.
            return 0;
        }

    int sum = 0;

    // Loopa genom arrayen och summera värdena
    foreach (int number in array)
    {
        sum += number;
    }

    // Beräkna genomsnittet genom att dela summan med antalet element
    double average = (double)sum / array.Length;

    return average;

}