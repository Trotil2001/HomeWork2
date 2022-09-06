/*
В кафе мороженное продают по три шарика и по пять шариков.
Можно ли купить ровно k шариков мороженого?
*/

Console.Write("Введите число шариков мороженого: ");
int k = Convert.ToInt32(Console.ReadLine());
int a = 3;
int b = 5;
if (k > 0 )
{
    if (k % a == 0 || k % b == 0)
        Console.Write("YES");
    else
        Console.Write("NO");
}
else
    Console.Write("Введено не допустимое число!");