using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KadralinovaAT.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            string allText = File.ReadAllText(path);
            string[] numbers = allText.Split(' ');

            foreach (string value in numbers)
            {
                string formattedNum = value.Replace('.', ',');
                double numb = Convert.ToDouble(formattedNum);

                if (formattedNum.Contains(','))
                {
                    res = res * numb;
                }
            }

            return Math.Round(res, 3);
        }
    }
}
