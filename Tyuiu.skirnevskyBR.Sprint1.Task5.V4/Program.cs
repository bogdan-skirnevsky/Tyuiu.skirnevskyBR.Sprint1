using Tyuiu.skirnevskyBR.Sprint1.Task5.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("*****************************************************");
Console.WriteLine("* Спринт #1                                         *");
Console.WriteLine("* Тема: Преобразование типов и классов Convert      *");
Console.WriteLine("* Задание #5                                        *");
Console.WriteLine("* Вариант #4                                        *");
Console.WriteLine("* Выполнил: Скирневский Богдан                      *");
Console.WriteLine("* Романович | ИБКСб-25-1                            *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая решает       *");
Console.WriteLine("* следующую задачу: Идет k-я секунда суток.         *");
Console.WriteLine("* Определить, сколько полных часов прошло к этому   *");
Console.WriteLine("* моменту                                           *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
Console.WriteLine("*****************************************************");
int x;
Console.WriteLine("ВВедите значение X:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("*****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
Console.WriteLine("*****************************************************");
Console.WriteLine("Прошло " + ds.SecondsToHours(x) + " полных часа(ов)");


Console.ReadLine();
