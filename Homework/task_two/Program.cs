// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = 0;
    if (numberOne > numberTwo && numberOne > numberThree)
    {
        // Console.WriteLine("Наибольшее число первое " + numberOne);
        max = numberOne;
        Console.WriteLine("Наибольшее число первое " + max);

    }
    else if (numberTwo > numberThree)
    {
        // Console.WriteLine("Наибольшее число второе " + numberTwo);
        max = numberTwo;
        Console.WriteLine("Наибольшее число второе " + max);
    }
    else
    {
        // Console.WriteLine("Наибольшее число третье " + numberThree);
        max = numberThree;
        Console.WriteLine("Наибольшее число третье " + max);
        
    }