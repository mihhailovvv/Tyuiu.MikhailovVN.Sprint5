using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;
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
                    string[] nums = line.Split(new[] { ' ', '\t', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string num in nums)
                    {
                        // double x = Convert.ToDouble(line);
                        double x = double.Parse(num.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);

                        if (x < res)
                        {
                            res = x;
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
