Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int num = 2;

if (num > numberN)
{
    Console.WriteLine("Здесь нет четных чисел");
}

while (num <= numberN)
{
    Console.WriteLine(num);
    num +=2;
}




    
