using Tyuiu.KadralinovaAT.Sprint5.Task3.V2.Lib;
int x = 3;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение, вычислить его значение при x = 3                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("x = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();