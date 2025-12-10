using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task5.V30.Lib
{
    public class DataService : ISprint6Task5V30
    {
        public int len;
        public double[] LoadFromDataFile(string path)
        {
            double[] mass;
            int len = 0;
            string str = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) > 2 | Convert.ToDouble(line) < 7)
                    { 
                        len++;
                    }
                }
            }
            mass = new double[len];
            using (StreamReader sr = new StreamReader(path))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) > 2 | Convert.ToDouble(line) < 7)
                    {
                        mass[i] = Convert.ToDouble(line);
                        i++;
                    }
                }
            }
            return mass;
        }
    }
}
