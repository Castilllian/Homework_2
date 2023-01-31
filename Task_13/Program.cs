// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();
int count = num.Length;
if(count >= 3)
{
    string num1 = Convert.ToString(num[2]);
    Console.WriteLine($"{num} -> {num1}");
}
if(count <= 2)
{
    Console.WriteLine($"третьей цифры нет");
}