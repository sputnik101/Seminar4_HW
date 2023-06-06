//Задача1

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSumNumber()
// {
//     int sum=0;
//     int count = 1;

//     while (count<=num)
//     {
//         sum=sum+count;
//         count= count+1;
//     }
//     return sum;
// }

// int result = GetSumNumber();

// Console.WriteLine(result);

//Задача2

// Console.WriteLine("Введите число");
// string A = Console.ReadLine();
// Console.WriteLine(Length());

// int Length () {
//     int length = A.Length;
//     return length;
// }

//Задача3

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int x()
// {
//     int result = 1;
//     int count = 1;
//     while (count <= num)
//     {
//         result = result * count;
//         count = count + 1;
//     }
//     return result;
// }
// Console.WriteLine(x());

//Задача4

// void CreateArray()
// {
//     int[] arr = new int[8];
//     int count = 0;
//     while(count < arr.Length)
//     {
//         arr [count] = new Random().Next(0,2);
//         Console.Write($"{arr[count]} ");
//         count++;
//     }
    
// }
// CreateArray();

//__________ДОМАШНЕЕ ЗАДАНИЕ_________________

//_Задача1

// Напишите цикл, который принимает
// на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число.");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень числа.");
// int num2 = Convert.ToInt32(Console.ReadLine());

// double Exponentiation()
// {
//    double result = Math.Pow (num,num2);
//    return result;
// }
// Console.WriteLine($"Число {num}, возведенное в степень {num2} равно {Exponentiation()}.");

// Console.Write("Введите A: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Power(int arg1, int exponent)
// {
//     return arg1 = Convert.ToInt32(Math.Pow(arg1, exponent));
// }

// bool Valid(int exponent)
// {
//     if (exponent < 0)
//     {
//         Console.Write("Число В должно быть больше 0!");
//         return false;
//     }
//     else
//     {
//         return true;
//     }
// }
// if (Valid(num2) == true)
// {
//     Console.Write($"Число {num1} в степени {num2} равно {Power(num1, num2)}.");
// }

//Задание2

//  Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumAllDigit(int arg)
// {
//     int result = 0;
//     while (arg > 0)
//     {
//         result += arg % 10;
//         arg = arg / 10;
//     }
//     return result;
// }
// Console.Write($"Сумма все цифр числа {num} равна {SumAllDigit(num)}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// System.Console.Write("Введите длинну массива: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите начальное значение массива: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите конечное значение массива: ");
// int num3 = Convert.ToInt32(Console.ReadLine());


// int[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
// {
//     int[] RandomArray = new int[Lenght];
//     Random rand = new Random();
//     for (int i = 0; i < Lenght; i++)
//     {
//         RandomArray[i] = rand.Next(MinValue, MaxValue + 1);
//     }
//     return RandomArray;
// }


// void PrintRandomArray(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write($"{array[array.Length - 1]}");
//     System.Console.Write("]");
// }