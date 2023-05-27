// // это коментарий, пишу код

// Console.WriteLine("Введите целое число");//приглашаем пользователя ввести информацию
// int x = Convert.ToInt32( Console.ReadLine());//перевели данные от пользователя в целочисленное число

// int y = x*x;
// Console.WriteLine ("квадрат введеного числа равен "+y);
// //сделаем проверку на двузначность число
// if (x>9 && x<100) //если х больше 9 и при этом меньше 100 то делаем следующее:
// {
// Console.WriteLine ("Вы ввели двузначное число");
// }


// // программа проверки квадрата
// Console.WriteLine("Введите цисло 1"); //здесь квадрат числа
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите цисло 2"); //здесь само число

// int y = Convert.ToInt32(Console.ReadLine());

// if (x == y * y)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("Первыое число не является квадратом втрого");
// }


// // Программа которая будет выдавать название дня недели по цифре от 1 до 7
// Console.WriteLine ("Введите число от 1 до 7");
// int x = Convert.ToInt32 (Console.ReadLine());
// if (x == 1) Console.WriteLine("Понедельник");
// else if (x == 2) Console.WriteLine("Вторник");
// else if (x == 3) Console.WriteLine("Среда");
// else if (x == 4) Console.WriteLine("Четверг");
// else if (x == 5) Console.WriteLine("Пятница");
// else if (x == 6) Console.WriteLine("Суббота");
// else if (x == 7) Console.WriteLine("Воскресение");
// else Console.WriteLine("Неккоректное число");


// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= x)
// {    
//         Console.Write(i + " ");
// i = i + 1;
// }


// int x = new Random().Next(10,100);
// Console.WriteLine("Там было сгенерировано число "+x);
// Console.WriteLine($"Там было сгенерировано число {x}");
// // оба варианта выводят результат
// int x1 = x / 10;


// Console.WriteLine("Ведите координату Х");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x,y);
// Console.WriteLine(CheckKoord2(x,y));
// // if (x > 0 && y > 0) Console.WriteLine("Это четверть 1");
// // else if (x > 0 && y < 0) Console.WriteLine("Это четверть 4");
// // else if (x < 0 && y < 0) Console.WriteLine("Это четверть 3");
// // else if (x < 0 && y > 0) Console.WriteLine("Это четверть 2");
// // else Console.WriteLine("Точка лежит на оси");

// // сделаем метод который ничего не возвращает но что то делает
// void CheckKoord(int x, int y)
// {
// if (x > 0 && y > 0) Console.WriteLine("Это четверть 1");
// else if (x > 0 && y < 0) Console.WriteLine("Это четверть 4");
// else if (x < 0 && y < 0) Console.WriteLine("Это четверть 3");
// else if (x < 0 && y > 0) Console.WriteLine("Это четверть 2");
// else Console.WriteLine("Точка лежит на оси");
// }

// // сделаем метод который что то возвращает что то делает
// string CheckKoord2( int x, int y)
// {
//     string res = "";
//     if (x > 0 && y > 0) res = ("Это четверть 1");
// else if (x > 0 && y < 0) res = ("Это четверть 4");
// else if (x < 0 && y < 0) res = ("Это четверть 3");
// else if (x < 0 && y > 0) res = ("Это четверть 2");
// else Console.WriteLine("Точка лежит на оси");
// return res;
// }

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("Введите номер четверти от 1 до 4");
// int x = Convert.ToInt32(Console.ReadLine());
// Chetvert (x);
// // if (x > 0 && y > 0) Console.WriteLine("Это четверть 1");
// // else if (x > 0 && y < 0) Console.WriteLine("Это четверть 4");
// // else if (x < 0 && y < 0) Console.WriteLine("Это четверть 3");
// // else if (x < 0 && y > 0) Console.WriteLine("Это четверть 2");
// // else Console.WriteLine("Точка лежит на оси");

// if (x == 1) Console.WriteLine ("x > 0, y>0 ");
// else if (x == 2) Console.WriteLine ("x < 0, y>0 ");
// else if (x == 3) Console.WriteLine ("x > 0, y<0 ");
// else if (x == 4) Console.WriteLine ("x < 0, y>0 ");

// void Chetvert (int x)
// {
//     if (x == 1) Console.WriteLine ("x > 0, y>0 ");
// else if (x == 2) Console.WriteLine ("x < 0, y>0 ");
// else if (x == 3) Console.WriteLine ("x > 0, y<0 ");
// else if (x == 4) Console.WriteLine ("x < 0, y>0 ");
// }


// Console.WriteLine("Ведите координату Х1");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите координату Y1");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите координату Х2");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите координату Y2");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Distance(x1, y1, x2, y2);


// void Distance(double x1, double y1, double x2, double y2)
// {
//  double temp = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))); 
//  Console.WriteLine("Расстояние между точками 1 и 2 = " + temp);
// }





// Console.WriteLine("Ведите целое число!");
// int x = Convert.ToInt32(Console.ReadLine());


// for (int i = 1; i <= x; i++)
// {
//   Console.Write($"{Math.Pow(i, 2)} ");
// }

    
// void FillArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-9,10);
// }


// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     Console.Wtrite($"{array[i]}");
//     Console.WriteLine();
// }

// void FindSums(int [] array)
// {
//     int sump = 0;
//     int sumn = 0;
//     for (int i=0; i < array.Length; i++)
//     {
//         if (array[i]>0) sump += array[i];
//         else sumn +=array[i];
//     }
// }
// void FindSums2(int [] array)
// {
//     int sump = 0;
//     int sumn = 0;
//     for (int i=0; i < array.Length; i++)
//     {
//         if (array[i]>0) sump += array[i];
//         else sumn +=array[i];
//     }
//     int[] results = {sump, sumn};
//     return results;
// }

// int [] array = new int[32];
// FillArray(array);
// PrintArray(array);
// FindSums2(array);
// int [] result = FindSums2(array);
// Console.WriteLine($"сумма положительных элементов равна {sump}");
// Console.WriteLine($"сумма положительных элементов равна {sump}");


// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// // сумма отрицательных равна -20.

// void FillArray(int [] array)
// {
//     for (int i=0;i<array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] array)
// {
//     for (int i=0;i<array.Length; i++)
//         Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }

// void FindSums(int [] array)  //int [] FindSums
// {
//     int sump=0; //сумма положительных
//     int sumn=0; //сумма отрицательных
//     for (int i=0;i<array.Length; i++)
//     {
//         if (array[i]>0) sump+=array[i];
//         else sumn+=array[i];
//     }
//     Console.WriteLine($"сумма положительных элементов равна {sump}");
//     Console.WriteLine($"сумма отрицательных элементов равна {sumn}");
// }

// int[] FindSums2(int [] array)  
// {
//     int sump=0; //сумма положительных
//     int sumn=0; //сумма отрицательных
//     for (int i=0;i<array.Length; i++)
//     {
//         if (array[i]>0) sump+=array[i];
//         else sumn+=array[i];
//     }
//     int[] results = {sump, sumn};
//     return results;
// }

// int [] array = new int[12];
// FillArray(array);
// PrintArray(array);
// FindSums(array);
// int[] results = FindSums2(array);
// Console.WriteLine($"сумма положительных элементов равна {results[0]}");
// Console.WriteLine($"сумма отрицательных элементов равна {results[1]}");



// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 ->  0 1 1 2 3 5 8

// Console.WriteLine("Введите число фибоначчи");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[] array)
// {
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < N; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
// }
// void PrintArray(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//         Console.Write($"{mas[i]} ");
//     Console.WriteLine();
// }


// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-10,11);
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//     }
// }



// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = i+j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3}");
//         Console.WriteLine();
//     }
// }


// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// // Например, изначально массив
// //  выглядел вот так:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// double [,] array = new double[rows,cols ];
// FillArray(array);
// PrintArray(array);
// PowArray(array);
// Console.WriteLine("Массив после квадрата");
// PrintArray(array);



// void PowArray(double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0)  array[i,j] = Math.Pow(array[i,j],2);
//         }
            
// }

// void FillArray(double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-10,11);
// }


// void PrintArray(double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//     }
// }



// // посчитать сумму всех чисел от 1 до введенного N

// Console.WriteLine("Введите натуральное  число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summa(N));
// Console.WriteLine(SummaRec(N));

// int Summa(int N)
// {
//     int sum=0;
//     while (true)
//     {
//         if (N==0) break;
//         sum=sum+N;
//         N--;
//     }
//     return sum;
// }

// int SummaRec(int N)
// {
//     if (N==0) return 0;
//     return N + SummaRec(N-1);
// }

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6" 
 
 
 
// Console.WriteLine("Введите натуральное  число"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(AllNumber(N)); 
 
 
// string AllNumber(int N) 
// { 
//     if (N==1) return $"1"; 
//     return AllNumber(N-1) + $" {N}" ; 
// }

// // или

// Console.WriteLine("Введите натуральное  число");
// int N = Convert.ToInt32(Console.ReadLine());
// // string N = String.Empty;
// Console.WriteLine(Rec(N));



// // int Rec(int N)
// // {
// //     if (N==1) return 1;
// //     Console.Write(N);

// //     return Rec(N-1);  
// // }

// string Rec(int N)
// {
//     if (N==1) return "1";
//     return Rec(N-1) + " " + Convert.ToString(N) + " ";
    
// }


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8" 
 
// Console.WriteLine("Введите натуральное число N"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите натуральное число M"); 
// int M = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(AllNumber(N, M)); 
 
// string AllNumber(int min, int max) 
// { 
//     if (min==max) return $"{min}"; 
//     return   $"{max} " + AllNumber(min, max-1); 
// }

























































































































