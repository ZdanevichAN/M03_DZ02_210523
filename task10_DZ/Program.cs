// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// двумерный массив для хранения трехзначных чисел и их вторых цифр
int[,]  mas_decision= new int[3,3]{{1,0,0},{2,0,0},{3,0,0}};

//Вариант 01
    //_1_принимает на вход трёхзначное число
        int three_digit= new Random().Next(100,1000);
        Console.Write($"ВАРИАНТ №01__*__Иммитация ввода трехзначного числа пользователем: {three_digit}");
    //_2_вторую цифру этого числа
        int second_digit = (three_digit%100)/10;
    //_3_на выходе показывает
        Console.WriteLine($"    Вторая цифра числа {three_digit} равна {second_digit}");

mas_decision[0,1] = three_digit;
mas_decision[0,2] = second_digit; 


// // Вариант 02 - через метод
// void Second_Digit2(int three_digit2)
// {
//     if(three_digit2.ToString().Length==3) 
//         {
//             int sec_digit2=three_digit2%100/10;
//             Console.WriteLine($"ВАРИАНТ №02__*__Вторая цифра числа {three_digit2} равна {second_digit2}");
//         }
//     else{Console.WriteLine($"ВАРИАНТ №02__*__ Число {three_digit2} - не является трехзначным,введите следующее число");}
// }

// Second_Digit2(new Random().Next(100,1000));

// Вариант 03 - через метод с развратом
int Second_Digit3(int random_num)
{
    if (random_num.ToString().Length==3){random_num=random_num%100/10;}
    else{Console.WriteLine($"ВАРИАНТ №03__*__ Число {random_num} - не является трехзначным,введите следующее число");}
    return random_num;
}
int three_digit3 = new Random().Next(100,1000);
Console.WriteLine($"Вариант№03__*__Вторая цифра числа {three_digit3} равна {Second_Digit3(three_digit3)}");

mas_decision[2,1] = three_digit3;
mas_decision[2,2] = Second_Digit3(three_digit3); 

// //Вариант 02-метод + сокращения
//     void Second_digit (int three_digit_2 )
//     {
//         Console.Write($"Иммитация ввода трехзначного числа пользователем: {three_digit_2}")

//     }
//     Console.WriteLine($" Вторая цифра числа {three_digit} равна {Second_digit(new Random().Next(100,1000))}");  

// mas_decision[1,1] = three_digit;
// mas_decision[1,2] = second_digit; 





// честно скопированный из интернета ввывод данных многомерного массива
int rows = mas_decision.GetUpperBound(0) + 1;    // количество строк
int columns = mas_decision.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
Console.WriteLine("Массив решений__*__");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mas_decision[i, j]} \t");
    }
    Console.WriteLine();
}
// //Вариант 02-метод + сокращения
// void Third_digit (int thre_som_num2 )
// {
//     Console.Write("Иммитация ввода трехзначного числа")
// }



// //Вариант 02-метод + сокращения
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите трехзначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Вторая цифра числа {number} равна {number / 10 % 10}");
//     }
// }