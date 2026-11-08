Console.WriteLine("Podaj wysokość choinki od 2 do 10:");

int.TryParse(Console.ReadLine(), out int height);
if(height<2 || height > 10)
Console.WriteLine("Nieprawdiłowa wysokość.");

// for(int i = height; i>0; i--)
// {
//     Console.Write(space);
//     for(int k = 0; k<height; k++)
//     {
//     Console.Write(star);
//     }
//     Console.Write("\n");
// }

// for (int i=1; i<height*2; i+=2)
// {
//     int currentVal = i;
//     Console.Write(new string(' ', height-1));
//     for (int k = 1; k < currentVal; k+=2)
//     {
//         Console.Write(new string('*', k));
//     }
//     Console.Write("\n");
// }

for(int i=1; i<height; i+=2)
{
    
}