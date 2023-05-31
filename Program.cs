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

//Задание2

//  Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число.");
int num = Convert.ToInt32(Console.ReadLine());


