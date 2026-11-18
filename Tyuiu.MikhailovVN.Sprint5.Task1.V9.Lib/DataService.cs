using System.Reflection.Metadata;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MikhailovVN.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x  = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x, 2);
                strY = Convert.ToString(y);

                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
