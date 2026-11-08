Console.WriteLine("Ile dni trwa wyprawa: ");
string daysString = Console.ReadLine();
int.TryParse(daysString, out int days);
if(days>7)
{
    Console.WriteLine("Nieprawdiłowa liczba dni.");
}
else
{    
    int aboveTen = 0;
    int sum = 0;
    for (int i=1; i<=days; i++)
    {
        Console.WriteLine($"Aktualny dzień {i} \n Podaj liczbę znalezionego złota w dniu {i}. :");
        int.TryParse(Console.ReadLine(), out int input);
        sum+=input;
        if(input>10)
        {
            aboveTen++;
        }
    }
    Console.WriteLine($"Łącznie znaleziono: {sum} sztuk złota");
    Console.WriteLine($"Liczba dni z wynikiem powyżej 10: {aboveTen}");
}