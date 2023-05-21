// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


    Console.Write("Введите число дня недели(от 1 до 7): ");
    int user_num = Convert.ToInt32(Console.ReadLine());
    switch(user_num)
    {
        case<1: 
            Console.WriteLine($"Данное число {user_num} не подходит, оно меньше 1");
            break;
        case>7: 
            Console.WriteLine($"Данное число {user_num} не подходит, оно больше 7");
            break;
        case<6:
            Console.WriteLine($"Это номер {user_num} рабочего дня");
            break;
        case>=6:
            Console.WriteLine($"Это номер {user_num} выходного дня");
            break;
    }

