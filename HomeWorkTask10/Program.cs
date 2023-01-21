/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

Console.Write(" Введите Имя   ");
string? username = Console.ReadLine();
Console.Write("Привет!");
Console.WriteLine(username);

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра "+stringNumber[1]);