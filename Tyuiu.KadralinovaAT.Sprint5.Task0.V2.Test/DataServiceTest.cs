using System.IO;
using Tyuiu.KadralinovaAT.Sprint5.Task0.V2.Lib;
namespace Tyuiu.KadralinovaAT.Sprint5.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(5);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
