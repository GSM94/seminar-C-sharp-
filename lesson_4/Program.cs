// // Задача 1 Напишите программа, которая принимает на вход число и выдает количество цифр в числе.

// int NumOfDigits(int num)
// {
//     int count = 0;
//     if(num == 0) count = 1;
//     while(num != 0)
//     {
//         count++;
//         num /= 10;
//     }
//     return count;
// }
// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = NumOfDigits(number);
// Console.WriteLine($"Number of digits in {number} is {result}");

// for(int current = -number; current <= number; current ++)
// {
//     Console.Write(current + " ");
// }
// Задача 2 Напишите программу, которая принимает на вход (А) и выдает сумму чисел от 1 до А

// int Sum(int num)
// {
//     int sum = 0;
//     while(num > 0)
//     {
//         sum += num;
//         num--;
//     }
//     return sum;
// }

// Console.Write("Input an integer number N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = Sum(number);
// Console.WriteLine($"Sum of numbers from 1 to N is {result}");
// Задача 3 Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

// int Facrorial(int num)
// {
//     int fact = 1;
//     // while(num > 0)
//     // {
//     //     fact *= num;
//     //     num--;
//     // }
//     for (int i =2; i <= num; i++)
//     {
//         fact *= i;
//     }
//     return fact;
// }
// Console.Write("Input an integer number N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = Facrorial(number);
// Console.WriteLine($"Factorial of number from 1 to N is {result}");



                                                    //Массивы

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"array[{i+1}] is {array[i]}");
}
Console.Write("Iput a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Iput a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Iput a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);