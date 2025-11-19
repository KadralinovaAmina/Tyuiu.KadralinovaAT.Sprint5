using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KadralinovaAT.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string file = "OutPutDataFileTask7V14.txt";
            string directory = Path.GetTempPath();
            string pathSave = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSave);
            }

            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string converted = line.ToUpper();
                    sb.AppendLine(converted);
                }
            }

            File.WriteAllText(pathSave, sb.ToString());

            return pathSave;
        }
    }
}
