using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KadralinovaAT.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res1 = 1;
            double res2 = 1;

            string allText = File.ReadAllText(path);

            string[] numbers = allText.Split(' ');

            foreach (string value in numbers)
            {
                string formattedNum = value.Replace('.', ',');

                double num = Convert.ToDouble(formattedNum);

                if (num == Math.Truncate(num))
                {
                    if (num > 0)
                    {
                        res1 *= num;
                    }
                    if (num < 0)
                    {
                        res2 *= num;
                    }
                }
            }
            return Math.Round(res1-res2, 3);
        }
    }
}
