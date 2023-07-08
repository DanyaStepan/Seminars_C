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


// void Palindrom(int number)
// {
//     if (number >= 10000 && number < 100000)
//     {
//         int num1 = number % 10;
//         int num2 = (number / 10000) % 10;
//         if (num1 == num2)
//         {
//             int num3 = (number / 10) % 10;
//             int num4 = (number / 1000) % 10;
//             if (num3 == num4)
//             {
//                 System.Console.WriteLine($"Число {number} является палиндромом");
//             }
//             else
//             {
//                 System.Console.WriteLine($"Число {number} не является палиндромом");
//             }
//         }
//         else
//         {
//             System.Console.WriteLine($"Число {number} не является палиндромом");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine($"Попробуйте ещё раз. Число {number} не является пятизначным.");
//     }
// }

// System.Console.Write("Введите пятизначное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrom(number);



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

//СЕМИНАР 4.

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// bool ValidPower(int b)
// {
//     if (b < 0)
//     {
//         System.Console.Write("Число B не должно быть < 0");
//         return false;
//     }
//     return true;
// }

// int FindPower(int a, int b)
// {
//     int power = 1;
//     for (int i = 0; i < b; i++)
//     {
//         power *= a;
//     }
//     return power;
// }
// System.Console.Write("Введите число A -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число B -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (ValidPower(b))
// {
//     System.Console.Write($"{a} в степени {b} -> {FindPower(a, b)}");
// }   


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FindSumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; num > 0; i++)
//     {
//         sum = sum + (num % 10);
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"Число {num}. Сумма цифр этого числа даёт число -> {FindSumNumbers(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal elements of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal elements of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// PrintArray(CreateRandomArray(size, minValue, maxValue));


//СЕМИНАР 5.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// System.Console.Write("Введите колличество элементов массива -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] randomArray = new int[size];

// void arr(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i]=new Random().Next(100, 1000);
//         System.Console.Write(randomArray[i] + " ");
//     }
// }


// int ColVo(int[] randomArray)
// {
//     int ColVo = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if(randomArray[i] % 2==0)
//         ColVo = ColVo + 1;
//     }
//     System.Console.WriteLine();
//     return ColVo;
// }

// arr(size);
// System.Console.Write($"Количество чётных чисел в массиве {ColVo(randomArray)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите размер массива -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.Write("Вот наш массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int a = 0; a < numbers.Length; a+=2)
//     sum = sum + numbers[a];

//     Console.Write($"Всего {numbers.Length} чисел(а), сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,100);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.WriteLine();
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }




//СЕМИНАР 6.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int Promt(string message) 
// { 
//     System.Console.Write(message); 
//     string value = Console.ReadLine(); 
//     int result = Convert.ToInt32(value); 
//     return result; 
// } 

// int[] inputArray(int length) 
// { 
//     int[] array = new int[length]; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         array[i] = Promt($"Введите {i + 1} -й элемент "); 
//     } 
//     return array; 
// } 

// void PrintArray(int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         Console.WriteLine($"a[{i}] = {array[i]}"); 
//     } 
// } 

// int CountPositiveNumbers(int[] array) 
// { 
//     int count = 0; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         if (array[i] > 0) 
//         { 
//             count++; 
//         } 
//     } 
//     return count; 
// } 


// int length = Promt("Введите количество элементов -> "); 
// int[] array; 
// array = inputArray(length); 
// PrintArray(array); 
// Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($"\n Точка пересечения двух прямых: [{ x},{ y}]");


//СЕМИНАР 7.

/*Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// double[,] Create2DArray (int rows, int columns) 
// { 
//     double[,] array = new double[rows,columns]; 
//     for (int i = 0; i < rows; i++) 
//     { 
//         for (int j = 0; j < columns; j++) 
//         { 
//             array[i, j] = new Random().Next(-99, 99) / 10.0 ; 
//         } 
//     } 
//     return array; 
// } 
 
// void Print2DArray(double[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for( int j = 0 ; j < array.GetLength(1); j++) 
//         { 
//             System.Console.Write(array[i,j] + " "); 
//         } 
//         System.Console.WriteLine(); 
//     } 
//     System.Console.WriteLine(); 
// } 
 
// System.Console.WriteLine("Input number of rows: "); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Input number of columns: "); 
// int columns = Convert.ToInt32(Console.ReadLine()); 
 
// Print2DArray(Create2DArray(rows, columns));


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] ElementPosition(int[,] array, int posX, int posY)
// {
//     if (posX < array.GetLength(0) && posY < array.GetLength(1))
//     {
//         Console.WriteLine(array[posX, posY]);
//     }
    
//     else 
//     Console.Write($"{posX},{posY} -> числа с такими координатами НЕТ в массиве!!!");
    
//     return array;
// }

// System.Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите минимальное значение массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальное значение массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите первый элемент массива: ");
// int posX = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второй элемент массива: ");
// int posY = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// ElementPosition(myArray, posX, posY);



/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int MeanSum(int[,] array)
// {
//     int numRows = array.GetLength(0);
//     double meanSum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             if (i < array.GetLength(0))
//             {
//                 meanSum = meanSum + array[i, j];
//             }
//         }
//         meanSum = meanSum / numRows;
//         System.Console.Write($"{meanSum}; ");
//         meanSum = 0;
//     }
//     return (int)meanSum;
// }

// System.Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите миниальное значение элемента массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальное значение элемента массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// MeanSum(myArray);
