using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KadralinovaAT.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            foreach (char symb in strX)
            {

                strX = strX.Replace(".", ",");

            }

            double x = Convert.ToDouble(strX);
            double res = Math.Pow((x), 2) / Math.Sin(x) + 3;
            return Math.Round(res, 3);
        }
    }
}
