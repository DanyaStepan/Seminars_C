//СЕМИНАР 1.

// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("Введите первое число -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int b = Convert.ToInt32(Console.ReadLine());


// if (a > b)
// {
//     System.Console.Write($"Большее число: {a}, меньшее число: {b}");
// }
// else
// {
//     System.Console.Write($"Большее число: {b}, меньшее число: {a}");
// }


// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите третье число -> ");
// int num3 = Convert.ToInt32(Console.ReadLine());


// if ((num1 > num2) & (num1 > num3))
// {
//     System.Console.Write($"Максимальным числом является {num1} ");
// }
// else if (num2 > num3)
// {
//     System.Console.Write($"Максимальным числом является {num2} ");
// }
// else 
// {
//    System.Console.Write($"Максимальным числом является {num3} "); 
// }

// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     System.Console.Write($"Число {num } является чётным "); 
// }
// else 
// {
//     System.Console.Write($"Число {num } является нечётным ");
// }


// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.Write("Введите любое число начинающее от 1 -> "); 
// int num = Convert.ToInt32(Console.ReadLine()); 
// String num1 = ""; 

// if ( num < 1) 
// { 
//     System.Console.Write($"Оштбочка вышла "); 
//     num = Convert.ToInt32(Console.ReadLine()); 
// } 
// for ( int i = 1; i <= num; i ++) 
// { 
//     if ( i % 2 == 0 ) 
//     num1 = num1 + ($" {i } "); 
// } 
// System.Console.Write($"{num} -> {num1}");


//СЕМИНАР 2.

// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Promt (string messege)
// {
//     System.Console.Write(messege);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Promt("Введите трёхзначное число -> ");
// if(number < 100 || number >= 1000)
// {
//     System.Console.Write("Вы ввели не трёхзначное число, повторите попытку ");
//     return;
// }
// System.Console.Write($"Заданное число {number} ");
// int secondRank = number / 10 % 10;
// System.Console.Write($"Вторая цифра {secondRank} ");

// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Prompt(string messege)
// {
//     System.Console.Write(messege);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         System.Console.Write("Третьей цифры нет ");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число -> ");
// if (ValidateNumber(number))
// {
//     System.Console.Write(GetThirdRank(number));
// }

// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int Prompt(string messege)
// {
//     System.Console.Write(messege);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// bool IsWeekend(int weekDay)
// {
//     if (weekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidateWeekday(int number)
// {
//     if (number > 0 && number <= 7)
//     {
//         return true;
//     }
//     System.Console.Write("Это не день недели!");
//     return false;
// }

// int weekDay = Prompt("Введите день недели -> ");
// if (ValidateWeekday(weekDay))
// {
//     if (IsWeekend(weekDay))
//     {
//         System.Console.Write("Ура! Выходной!");
//     }
//     else
//     {
//         System.Console.Write("Придётся поработать :( Досадно, но ладно... ");
//     }
// }


//СЕМИНАР 3.

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Main(string[] args)
{
    Console.Write("Введите число -> ");
    string name = Console.ReadLine();
    string reverse = string.Empty;

    for (int i = name.Length - 1; i >= 0; i--)
    {
        reverse += name[i];
    }

    if (name == reverse)
    {
        Console.WriteLine($"{name} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"{name} не является палиндромом.");
    }

    Console.ReadKey();
}



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int InputN(string msg)
// {
//     System.Console.Write($"{msg} -> ");
// int value;
// if (int.TryParse(Console.ReadLine(), out value))
// {
//     return value;
// }
// System.Console.WriteLine("Вы ввели не число");
// Environment.Exit(1);
// return 0;

// }

// int x1 = InputN("Введите координату X точки A");
// int y1 = InputN("Введите координату Y точки A");
// int z1 = InputN("Введите координату Z точки A");
// int x2 = InputN("Введите координату X точки B");
// int y2 = InputN("Введите координату Y точки B");
// int z2 = InputN("Введите координату Z точки B");

// double dis(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     int num1 = x2 - x1;
//     int num2 = y2 - y1;
//     int num3 = z2 - z1;
//     return Math.Sqrt(num1 * num1 + num2 * num2 + num3 * num3);
// }
// System.Console.Write($"Растояние между точками A и B равно { dis(x1, y1, z1, x2, y2, z2):F2} ");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Quad (int x) 
// { 
//     int count = 1; 
//     while ( count <= x) 
//     { 
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}"); 
//         count ++; 
//     } 
// } 
// System.Console.WriteLine("Введите число"); 
// int x = Convert.ToInt32(Console.ReadLine()); 
// Quad(x);