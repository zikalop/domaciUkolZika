//první program
for(int i=0;i<101;i++)
{
    if(i==40)
    {
        continue;
    }
    if(i==60)
    {
        continue;
    }
    Console.WriteLine(i);
}
//druhej program
Console.WriteLine("Zadej šířku a výšku (10x50)");
string input = Console.ReadLine(); 
string[] _size = input.Split("x"); 
int[] size = new int[_size.Length];
for (int i = 0; i < _size.Length; i++)
{
    size[i] = int.Parse(_size[i]);
}
for (int i = 0; i < size[0]; i++)
{ 
    for (int j = 0; j < size[1]; j++) Console.Write("* "); 
    Console.Write("\n");
}
//třetí program
Console.WriteLine("napiš čísla které program následně vypíše(odděl čárkou nebo tečkou)");
string input=Console.ReadLine() ?? "";
string[] array = input.Split(",");
Console.WriteLine($"Počet čísel je: {array.Length}");
