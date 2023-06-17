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
