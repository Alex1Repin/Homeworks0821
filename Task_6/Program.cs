Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine());

int rem = number % 2;

if (rem == 0)
{
    Console.WriteLine("Число четное");
}

else
{
    Console.WriteLine("Число не четное");
}    