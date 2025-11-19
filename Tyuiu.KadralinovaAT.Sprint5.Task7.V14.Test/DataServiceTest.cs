using System.IO;
using Tyuiu.KadralinovaAT.Sprint5.Task7.V14.Lib;
namespace Tyuiu.KadralinovaAT.Sprint5.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            string file = "InPutDataFileTask7V14.txt";
            string directory = @"C:\DataSprint5";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
