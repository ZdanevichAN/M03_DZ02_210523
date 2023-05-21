// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// int user_digit = Console.ReadLine($"Введите число: {Convert.ToInt32(Console.ReadLine())}");
Console.Write("Input some number, please: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num<100)
{
    Console.Write("This numer is too small, please try again");
}
else if (user_num>1000)
{
    Console.Write("This numer is too big, please try again");
}
else
{
    Console.Write($"Third number is {user_num%10}");
}