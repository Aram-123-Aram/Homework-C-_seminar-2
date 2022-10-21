/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет */

int day = new Random().Next(1, 8);
Console.WriteLine("Generating any number of week's day= " + day);
if (day == 6) {Console.WriteLine($"Yes, it is {day}th day- Saturday- Weekend!"); }
else if (day == 7) {Console.WriteLine($"Yes, it is {day}th day- Sunday- Weekend!"); }
     else {Console.WriteLine($"No, it isn't Weekend!"); }
