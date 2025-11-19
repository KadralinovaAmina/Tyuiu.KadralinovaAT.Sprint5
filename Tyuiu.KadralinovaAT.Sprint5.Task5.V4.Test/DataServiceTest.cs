using System.IO;
using Tyuiu.KadralinovaAT.Sprint5.Task5.V4.Lib;
namespace Tyuiu.KadralinovaAT.Sprint5.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string file = "InPutDataFileTask5V4.txt";
            string directory = @"C:\DataSprint5";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
