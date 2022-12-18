// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных элементов массива

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         // Console.WriteLine($"array[{i+1}] is {array[i]}");
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }


// int GetSumOfNegatives(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//             sum = sum + array[i];
//     }

//     return sum;
// }


// Console.Write("Iput a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a max possible value: ");
// int max= Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// int result = GetSumOfNegatives(myArray);
// Console.WriteLine("Sum of negatives" + result);


// Задача 2 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
//  void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// int[] rivers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = array[i] *-1;
//     return array;  // здесь можно было сделать через void(для этого array[i] умножить на -1)
// }

// Console.Write("Iput a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a max possible value: ");
// int max= Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// int[] result = rivers(myArray);
// ShowArray(result);


                                            //Задача 3
// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
//  void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int Abed(int[] array, int a, int b)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= a && array[i] <= b)
//             count ++;
//     }
//     return count;

// }


// Console.Write("Iput a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Iput number A possible value: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Iput number B possible value: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// int result = Abed(myArray,a,b);
// Console.WriteLine(result);

                                                     //Задача 4
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] MultPairs(int[] array)
{
    int size = array.Length/2;
    if(array.Length % 2 != 0)
        size++;
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = array[i] *array[array.Length-1-i];
    }
    return newArray;
}

Console.Write("Iput a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Iput a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Iput a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int[] result = MultPairs(myArray);
ShowArray(result);
