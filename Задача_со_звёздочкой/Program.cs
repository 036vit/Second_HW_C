// Напишите программу, которая на вход принмает 3 трехзначных числа 
Console.Clear ();
Console.Write ("Введите трёхзначное число ");
int num1 = int.Parse (Console.ReadLine());
Console.Write ("Введите трёхзначное число ");
int num2 = int.Parse (Console.ReadLine());
Console.Write ("Введите трёхзначное число ");
int num3 = int.Parse (Console.ReadLine());
// Находит среднее арифметическое, 
int num4 = ((num1 + num2 + num3) / 3);
// Чем первая цифра минимума вводимых чисел
int minimum;
if (num2<num1)
{
minimum = num2;
}
else
{
minimum = num1;
}
if (minimum>num3)
{
minimum = num3;
}
else
{
minimum = minimum;
}
int count1 = (minimum/100);
//последняя цифра среднего арифметического
int cont2 = (num4%100);
int cont3 = (num4%10);
// Далее проверяет больше ли 
if (cont3<count1)
{
Console.WriteLine ("Нет");
}
else if (cont3>count1)
{
Console.WriteLine ("Да");
}
else
{
Console.WriteLine ("Равны");
}
// 111, 222, 333 - да
// 532, 164, 114 - нет
// 551, 235, 631 - цифры равны