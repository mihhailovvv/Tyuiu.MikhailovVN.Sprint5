using Tyuiu.MikhailovVN.Sprint5.Task2.V11.Lib;
namespace Tyuiu.MikhailovVN.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 4, 9, 3 },
                { 5, 8, 8 },
                { 5, 7, 5 }
            };
            
            string path = ds.SaveToFileTextData(matrix);
            FileInfo filepath = new FileInfo(path);
            bool fileExists = filepath.Exists;
            bool wait = true;

            Assert.AreEqual(true, fileExists);
        }
    }
}
