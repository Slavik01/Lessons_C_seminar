// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number > numberTwo)
{
    max = number;
}
    if (number > numberThree)
    {
        max = number;
    }
if (numberTwo > number)
{
    max = numberTwo;
}
    if (numberTwo > numberThree)
    {
        max = numberTwo;
    }
if (numberThree > number)
{
    max = numberThree;
}
    if (numberThree > numberTwo)
    {
        max = numberThree;
    }
    Console.Write("Наибольшее число" + max);