using Tyuiu.KadralinovaAT.Sprint5.Task6.V30.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти количество слов длиной восемь символов в заданной строке.         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string file = "InPutDataFileTask6V30.txt";
string directory = @"C:\DataSprint5";
string path = Path.Combine(directory, file);

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();