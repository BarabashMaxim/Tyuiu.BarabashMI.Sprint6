using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int k = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) + i == 0)
                {
                    mass[k] = 0;
                    k++;
                    continue;
                }
                mass[k] = Math.Round(((2 * i + 6) / (Math.Cos(i) + i)) - 3, 2);
                k++;
            }
            return mass;
        }
    }
}
