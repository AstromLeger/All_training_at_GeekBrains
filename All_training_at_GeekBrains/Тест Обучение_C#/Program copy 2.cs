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

    








