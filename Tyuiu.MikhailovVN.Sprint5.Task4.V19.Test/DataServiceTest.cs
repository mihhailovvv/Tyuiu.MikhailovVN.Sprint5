using Tyuiu.MikhailovVN.Sprint5.Task4.V19.Lib;
namespace Tyuiu.MikhailovVN.Sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool FileExist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(true, FileExist);
        }
    }
}
