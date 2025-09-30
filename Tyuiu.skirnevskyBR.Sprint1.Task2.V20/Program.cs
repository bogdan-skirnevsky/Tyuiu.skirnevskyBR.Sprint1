using Tyuiu.skirnevskyBR.Sprint1.Task2.V20.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("*****************************************************");
Console.WriteLine("* Спринт #1                                         *");
Console.WriteLine("* Тема: Базовые навыки в С#                         *");
Console.WriteLine("* Задание #2                                        *");
Console.WriteLine("* Вариант #20                                       *");
Console.WriteLine("* Выполнил: Скирневский Богдан                      *");
Console.WriteLine("* Романович | ИБКСб-25-1                            *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                          *");
Console.WriteLine("*  Заданы два числа. Вычислить сумму их квадратов.  *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
Console.WriteLine("*****************************************************");
Console.WriteLine("                                                    *");

int x, y;
Console.WriteLine("ВВедите значение X:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите значение Y:");
y = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("*****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
Console.WriteLine("*****************************************************");
Console.WriteLine("Сумма квадратов X и Y равна " + ds.CalculateSquaresSumm(x, y));

Console.ReadLine();
