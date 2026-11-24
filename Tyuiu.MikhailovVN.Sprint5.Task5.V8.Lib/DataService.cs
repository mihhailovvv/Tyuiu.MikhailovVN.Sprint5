using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MikhailovVN.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MaxValue;
            using (StreamReader sr = new StreamReader(path))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                 // double x = Convert.ToDouble(line);
                    double x = Convert.ToDouble(line.Replace('.', ','));
                    if (x < res)
                    {
                        res = x;
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
