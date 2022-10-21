/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа. 456 -> 5, 782 -> 8, 918 -> 1 */

int a = new Random().Next(100, 1000);
Console.WriteLine("Generating 3-digit number: a= " + a);

int sec_num = a / 10 % 10;
Console.WriteLine("The second number of 3-digit number is: sec_num= " + sec_num);