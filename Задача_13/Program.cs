// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear ();
Console.Write ("Введите число ");
int num = int.Parse (Console.ReadLine());
if (num > 99) 
{
string? str = Convert.ToString (num);
char[] arr = str.ToCharArray();
Console.WriteLine(arr[2]);
}
Console.WriteLine("Третьей цифры нет");