using Tyuiu.skirnevskyBR.sprint1.Task6.V2.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";


Console.WriteLine("*******************************************************");
Console.WriteLine("* Спринт #1                                           *");
Console.WriteLine("* Тема: Работа со строками класс String               *");
Console.WriteLine("* Задание #6                                          *");
Console.WriteLine("* Вариант #2                                          *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1 *");
Console.WriteLine("*******************************************************");
Console.WriteLine("* УСЛОВИЕ:                                            *");
Console.WriteLine("* Написать программу: пользователь вводит текст.      *");
Console.WriteLine("* Проверить, есть ли в строке слово Hello.            *");
Console.WriteLine("*                                                     *");
Console.WriteLine("*******************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                    *");
Console.WriteLine("*******************************************************");

Console.WriteLine("Введите строку:");
string str = Console.ReadLine();

Console.WriteLine("*******************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                          *");
Console.WriteLine("*******************************************************");


bool result = ds.CheckHello(str);

if (result)
{
    Console.WriteLine("В строке есть слово 'Hello'");
}
else
{
    Console.WriteLine("В строке нет слова 'Hello'");
}

Console.WriteLine();
Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();