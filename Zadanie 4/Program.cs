int outsideScope = 0;
do
{
    Console.WriteLine("Podaj liczbę tur do 1 do 10:");
    if(!int.TryParse(Console.ReadLine(), out int input))
    {
        Console.WriteLine("Podaj liczbę całkowitą.");
        continue;
    }
    else if(input <= 10 && input >= 1)
    {
        outsideScope = input;
        break;
    }
    else
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1-10.");
    }
}
while(true);
Console.WriteLine($"Rozpoczynam grę na {outsideScope} tur");

for(int i = outsideScope; i>0; i--)
{
    Console.WriteLine($"Tura {i}");
}