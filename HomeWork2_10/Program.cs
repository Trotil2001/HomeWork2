/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int inputNRandom()
{
    int result = new Random().Next(100, 1000);
    return result;
}

int inputN()
{
    Console.Write("Введите трехзначное число: ");
    int result = Convert.ToInt32(Console.ReadLine());
    while (((result > -100) && (result < 100)) || (result < -999) || (result > 999))
    {
        Console.Write($"Ввели {result}. Введите трехзначное число: ");
        result = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}
int n = 0;
int m = 0;
while ((m != 1) || (m != 2))
{
    Console.WriteLine("Введите 1 или 2");
    Console.WriteLine("1. Ввести число случайным образом.");
    Console.WriteLine("2. Ввести число вручную.");
    m = Convert.ToInt32(Console.ReadLine());
    if (m == 1)
    {
        n = inputNRandom();
        break;
    }
    if (m == 2)
    {
        n = inputN();
        break;
    }
}

int a = n / 10;
a = a % 10;
if (a < 0)
    a = a * (-1);
Console.Write($"Вы ввели число: {n}, вторая цифра этого числа: {a}");

