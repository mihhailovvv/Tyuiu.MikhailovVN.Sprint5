using Tyuiu.MikhailovVN.Sprint5.Task1.V9.Lib;
namespace Tyuiu.MikhailovVN.Sprint5.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo filepath = new FileInfo(path);
            bool fileExists = filepath.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
