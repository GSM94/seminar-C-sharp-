//*  Задача 1.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// int CutNumber(int num)
// {
//     int ed = num % 10; // 123 % 10 = 3 - остаток (выделяем последнюю цифру)
//     int sot = num / 100; // 123 / 100 = 1 - (оставляем первую цифру)

//     int result = sot *10 + ed; // здесь 1*10 и получаем 10 + 3 = 13
//     return result; // возращает 
// }


// int randNum = new Random().Next(100, 1000);
// int newNum = CutNumber(randNum);

// Console.WriteLine($"New version of a number {randNum} is {newNum}");

// Задача 2 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int Max(int num)
// {
//     int ed1 = num % 10;
//     int ed2 = num / 10;
//     if(ed1 > ed2)
//     {
//         return ed1;
//     }   
//     else
//     {
//         return ed2;
//     }
// }
// int randNum = new Random().Next(10,100);
// int newNum = Max(randNum);
// Console.WriteLine($"This number is {randNum} Max number is {newNum}");

// Задача 3 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 1 number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 2 number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// void Rand(int num, int a, int b)
// {
//     if(num % a == 0 && num % b == 0)
//     {
//         Console.WriteLine("True");
//     }
    

//     else
//             Console.WriteLine("False");
// }

// Rand(num,a,b);
// Задача 4 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool cvadro(int num1, int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1)
        return true;
    else
        return false;
}

Console.WriteLine("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 1 number: ");
int num2 = Convert.ToInt32(Console.ReadLine());


bool result = cvadro(num1, num2);

Console.WriteLine($"Result: {result}");
