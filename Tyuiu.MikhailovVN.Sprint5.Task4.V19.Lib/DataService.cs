using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MikhailovVN.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            // double x = Convert.ToDouble(strX);
            strX = strX.Trim().Replace(',', '.');
            double x = double.Parse(strX, System.Globalization.CultureInfo.InvariantCulture);

            double res = Math.Round(Math.Pow(x / Math.Cos(x), 2), 3);
            return res;
        }
    }
}
