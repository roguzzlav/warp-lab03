Console.WriteLine("Pętla for");
for (int j=1; j<11; j++)
Console.Write($"{j} ");

Console.WriteLine("\n Pętla while");
int i = 1;
while(i<11)
{
    Console.Write($"{i} ");
    i++;
}

Console.WriteLine("\n Pętla do while");
int k = 1;
do
{
    Console.Write($"{k} ");
    k++;
}
while (k<11);

Console.Write("\n Malejąco: ");
for(int l=10; l>0; l--)
{
    Console.Write($"{l }");
}

Console.WriteLine("Parzyste: ");
for(int l=0; l<21; l++)
{
    if(l%2==0)
    Console.Write($"{l} ");
}

Console.WriteLine("\n Start!");