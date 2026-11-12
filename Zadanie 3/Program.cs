Console.WriteLine("Podaj wysokość choinki od 2 do 10:");

int.TryParse(Console.ReadLine(), out int height);
if(height<2 || height > 10)
Console.WriteLine("Nieprawdiłowa wysokość.");

for(int i = 0; i < height; i++)
{
    for (int j = 0; j < (height - i - 1); j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < (2 * i + 1); k++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}

for (int j = 0; j < (height - 1); j++)
{
    Console.Write(" ");
}
Console.Write("*");