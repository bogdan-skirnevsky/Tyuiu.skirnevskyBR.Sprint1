using Tyuiu.skirnevskyBR.Sprint1.Task4.V12.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #1                                               *");
Console.WriteLine("* Тема: Class Math                                        *");
Console.WriteLine("* Задание #4                                              *");
Console.WriteLine("* Вариант #12                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя  *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле и       *");
Console.WriteLine("* печатает его на экране. Ответ округлите до 3 знаков.    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* sin ( p * x ) / ( x + sqrt(|y|) =                       *");
Console.WriteLine("***********************************************************");

double x, y;

Console.WriteLine("Введите значение x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("sin ( p * x ) / ( x + sqrt(|y|) = " + ds.Calculate(x, y));
Console.ReadLine();