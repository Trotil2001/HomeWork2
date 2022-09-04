/*
Задача 13: Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int find(int k)
{
    int res = k;
    if (res < -0) res = res * (-1);
    while (res > 1000)
    {
        res = res / 10;
    }
    res = res % 10;
    return res;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ввели число: {n}");
int m = n;
if (n < 100 && n > -100)
    Console.WriteLine($"Третьей цифры в числе {n} - нет!");
else
{
    m = find(n);
    Console.WriteLine($"Третья цифра {m} введенного числа {n}");
}