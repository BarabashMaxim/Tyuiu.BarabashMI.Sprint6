using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int k = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                string str = "";
                str = Convert.ToString(Math.Round((5 * i + 2.5) / (Math.Sin(i) - 2) + 2, 2));
                mass[k] = Convert.ToDouble(str);
                k++;
            }
            return mass;
        }
    }
}
