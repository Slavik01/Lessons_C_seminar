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
//int count = 10;
//while (max < count)
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



///////////////////////////////////////////////////////////////////////////////////////////////////////
// if (numberOne > numberTwo)
//     if (numberOne > numberThree)
//     {
//         numberOne = max;
//     }
// Console.WriteLine(max);
// if (numberTwo > numberOne)
//     if (numberTwo > numberThree)
//     {
//         numberTwo = max;
//     }
// Console.WriteLine(max);
// if (numberThree > numberOne)
//     if (numberThree > numberTwo)
//     {
//         numberThree = max;
//     }
// Console.WriteLine(max);
// if (numberTwo > numberThree)
// {
//     numberTwo = max;
// }
// else
// {
//     numberThree = max;
// }
// Console.Write(max);

/////////////////////////////////////////////////////////////////////////////////////////////////////////

// if (numberOne > numberTwo)
// {
//     numberOne = max;
// }
// else if (numberOne > numberThree)
// {
//     numberOne = max;
// }
// else if (numberTwo > numberOne)
// {
//     numberTwo = max;
// }
// else if (numberTwo > numberThree)
// {
//     numberTwo = max;
// }
// else if (numberThree > numberOne)
// {
//     numberThree = max;
// }
// else if (numberThree > numberTwo)
// {
//     numberThree = max;
// }
// else if (numberTwo > numberThree)
// {
//     numberTwo = max;
// }
// else
// {
//     numberThree = max;
// }

// Console.Write(max);

//////////////////////////////////////////////////////////////////////////////////////////////////////////

// if (number > numberTwo)
// {
//     max = number;
// }
//     if (number > numberThree)
//     {
//         max = number;
//     }
// if (numberTwo > number)
// {
//     max = numberTwo;
// }
//     if (numberTwo > numberThree)
//     {
//         max = numberTwo;
//     }
// if (numberThree > number)
// {
//     max = numberThree;
// }
//     if (numberThree > numberTwo)
//     {
//         max = numberThree;
//     }
//     Console.Write("Наибольшее число" + max);


