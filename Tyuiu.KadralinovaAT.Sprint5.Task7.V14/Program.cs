using Tyuiu.KadralinovaAT.Sprint5.Task7.V14.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению                                              *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Заменить все строчные латинские буквы на заглавные.                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string file = "InPutDataFileTask7V14.txt";
string directory = @"C:\DataSprint5";
string path = Path.Combine(directory, file);

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.LoadDataAndSave(path);
Console.WriteLine(res);
Console.ReadKey();