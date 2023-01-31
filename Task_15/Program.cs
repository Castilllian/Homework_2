// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num > 5 && num <= 7)
{
    Console.WriteLine($"да");
}
if(num >= 1 && num == 5)
{
    Console.WriteLine($"нет");
}