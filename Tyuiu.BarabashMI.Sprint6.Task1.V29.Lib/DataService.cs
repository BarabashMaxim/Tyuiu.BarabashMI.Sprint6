using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int k = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                string str = "";
                if (i == -1)
                    str = "0";
                else
                    str = Convert.ToString(Math.Round((Math.Cos(i) / (i + 1)) - Math.Cos(i) * 1.3 + 3 * i, 2));
                mass[k] = Convert.ToDouble(str);
                k++;
            }
            return mass;
        }
    }
}
