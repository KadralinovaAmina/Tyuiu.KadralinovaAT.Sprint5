using Tyuiu.KadralinovaAT.Sprint5.Task1.V22.Lib;
int startValue = -5;
int stopValue = 5;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция, произвести табулирование                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();