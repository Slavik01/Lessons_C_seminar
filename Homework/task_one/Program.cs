// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (number > numberTwo)
{
    max = number;
    min = numberTwo;
}
else if (number < numberTwo)
{
    min = number;
    max = numberTwo;
}
Console.WriteLine("Максимальное число: " + max);
Console.Write("Минимальное число: " + min);