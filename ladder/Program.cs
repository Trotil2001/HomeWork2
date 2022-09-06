/*
По данному натуральному n<=9 выведите лесенку из n ступенек,
i-я ступенька состоить из чисел от 1 до i без пробелов.
*/
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 9)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
            Console.Write(j);
        Console.WriteLine();
    }
}