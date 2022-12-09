// Задача 1. напишите программу, которая принимает на вход координаты точки (X и Y)б причем Х=!0 и Y=!0 и выдает номер четверти плоскости, в которой находится эта точка.

// int FindQuadrant(double x, double y)
// {
//     if(x>0 && y>0) return 1;
//     if(x<0 && y>0) return 2;
//     if(x<0 && y<0) return 3;
//     if(x>0 && y<0) return 4;
//     return 0;
// }
// Console.Write("Input an x-coordinate: ");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input an y-coordinate: ");
// double yA = Convert.ToDouble(Console.ReadLine());

// int quadNum = FindQuadrant(xA, yA);

// Console.WriteLine($"The point A({xA}, {yA}) is on the {quadNum} quadrant");

// задача 2 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(х и у)

// void ShowDiap(int a)
// {
//     if(a>0 && a<5)
//     {
//         if(a==1)
//             Console.WriteLine("x(0, +), y(0,+)"); 
//         if(a==2)
//             Console.WriteLine("x(0, +), y(-, 0)"); 
//         if(a==3)
//             Console.WriteLine("x(-, 0), y(-, 0)");
//         if(a==4)
//             Console.WriteLine("x(-, 0), y(0,+)");       
//     }
//     else
//         Console.WriteLine("Заданной четверти не существует");
// }
// Console.WriteLine("Задайте значение четверти координатной сетки");
// int diap =Convert.ToInt32(Console.ReadLine());
// ShowDiap(diap);

// Задача Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

// double Distance(double xa, double ya, double xb, double yb)
// {
//     double x = xb - xa;
//     double y = yb - ya;
//     double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
//     return result;
// }

// Console.Write("Input xA: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input yA: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input xB: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input yB: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// double Distanceresult = Distance(xa, ya, xb, yb);

// Console.WriteLine("Расстояние между точками" + Distanceresult);

// Напишите программу, которая принимает на вход число (N) и выдает ряд квадратов чисел от 1 до N 

// void Squares(int number)
// {
//     int counter = 1;
//     while(counter <= number)
//     {
//         Console.Write($"{Math.Pow(counter, 2)}");
//         if(counter != number) Console.Write(", "); // нужно while(counter <= number), если будет <, то в конце запятая тоже будет
//         counter++;
//     }
// }
// Console.Write("Введите число: ");
// int usernum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Серия квадратов:");
// Squares(usernum);