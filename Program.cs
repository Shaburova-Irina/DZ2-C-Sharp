﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%1000 == num)
// {
//   int result = (num%100 - (num%100)%10) / 10;
//   Console.Write(result);
// }
// else
// {
//   Console.WriteLine("Число не трёхзначное!");
// }

//========================================================================================================================

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%100 == num)
// {
//   Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//   int count = 1000;
  
//   while (num%count < num) //определяем сколько цифр в числе
//   {
//     int num2 = num%count;
//     count = count*10;
//   }
//   int count1 = count/100; //т.к. нам нужна 3-я цифра, отбрасываем первые 2 цифры
//   int count2 = count/1000; // определяем сколько цифр нужно отбросить с конца
//   int result = (num%count1 - num%count2)/count2; 
//   Console.WriteLine(result);
// }

//===========================================================================================================

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());

if ((day>=1) && (day<=5))
{
  Console.WriteLine("Будний день");
}
else if ((day == 6) || (day == 7))
{
  Console.WriteLine("Выходной день");
}
else
{
  Console.WriteLine("Некорректная цифра, попробуй еще раз позже");
}