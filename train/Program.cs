/*
Витя сел в i-й вагон от головы поезда и обнаружил, что его вагон имеет 
номер j. Он хочет определить, сколько вагонов в электричке.
*/

Console.Write("Введите номер вагона в который сел Витя: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер вагона: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i >= 1 && i <= 1000 && j >= 1 && j <= 1000)
{
    if (i != j)
    {
        int n = i + (j - 1);
        Console.Write("Количество вагонов в электричке: " + n);
    }
    else
    {
        Console.Write("Однозначно определить количество вагонов непльзя.");
    }
}
else
    Console.Write("Введены не верные значения");