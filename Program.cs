// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Hello, 2 World!");

Console.WriteLine("Введите число: ");		// запрос числа
int num = Convert.ToInt32(Console.ReadLine());
int i;

for (i = 1; i <= num; i++)
{
    Console.Write($" {Math.Pow(i, 3)}");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
