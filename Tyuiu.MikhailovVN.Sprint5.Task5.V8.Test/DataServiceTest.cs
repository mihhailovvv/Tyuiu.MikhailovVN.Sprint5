using Tyuiu.MikhailovVN.Sprint5.Task5.V8.Lib;
namespace Tyuiu.MikhailovVN.Sprint5.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFile1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";

            FileInfo file = new FileInfo(path);
            bool Exist = file.Exists;
            bool wait = true;

            Assert.AreEqual(true, Exist);
        }
    }
}
