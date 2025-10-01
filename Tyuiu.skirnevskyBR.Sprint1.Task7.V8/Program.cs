using Tyuiu.skirnevskyBR.Sprint1.V8.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #1                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спирнту *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #8                                              *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое    *");
Console.WriteLine("* выражение по исходным значениям данных, вводимых        *");
Console.WriteLine("* пользователем. Ответ округлите до 3 знаков.             *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* z = x ln(x) + y / (cos(x) - x/3)                        *");
Console.WriteLine("***********************************************************");

double x, y;

Console.WriteLine("Введите значение x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("z = " + ds.Calculate(x, y));
Console.ReadLine();