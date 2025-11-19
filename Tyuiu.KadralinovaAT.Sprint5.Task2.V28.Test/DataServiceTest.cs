using System.IO;
using Tyuiu.KadralinovaAT.Sprint5.Task2.V28.Lib;
namespace Tyuiu.KadralinovaAT.Sprint5.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3];
            string path = ds.SaveToFileTextData(mtrx);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
