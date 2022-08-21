Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberB > max)
{
    max = numberB;
    min = numberA;
}

else
{
    min = numberB;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
  
