using System.IO;
using Tyuiu.KadralinovaAT.Sprint5.Task4.V8.Lib;
namespace Tyuiu.KadralinovaAT.Sprint5.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string file = "InPutDataFileTask4V8.txt";
            string directory = @"D:\Sprint5Task4";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
