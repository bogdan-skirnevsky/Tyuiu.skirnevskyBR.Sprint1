﻿using Tuyuiu.skirnevskyBR.Sprint1.Task1.V17.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("*****************************************************");
Console.WriteLine("* Спринт #1                                         *");
Console.WriteLine("* Тема: Базовые навыки в С#                         *");
Console.WriteLine("* Задание #1                                        *");
Console.WriteLine("* Вариант #17                                       *");
Console.WriteLine("* Выполнил: Скирневский Богдан                      *");
Console.WriteLine("* Романович | ИБКСб-25-1                            *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                          *");
Console.WriteLine("* Написать программу, которая запрашивает у         *");
Console.WriteLine("* пользователя исходные                             *");
Console.WriteLine("* данные, вычисляет результат по формуле x*y*(5-x)  *");
Console.WriteLine("* и печатает его на экране.                         *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
Console.WriteLine("*****************************************************");
Console.WriteLine("                                                    *");

double x, y;
Console.WriteLine("ВВедите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ВВедите значение Y:");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("*****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
Console.WriteLine("*****************************************************");
Console.WriteLine(ds.Calculate(x, y));
Console.ReadLine();
