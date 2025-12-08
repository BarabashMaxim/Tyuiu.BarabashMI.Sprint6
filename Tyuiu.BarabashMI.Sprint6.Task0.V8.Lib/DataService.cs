using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            return Math.Round((2 * x * x - 1) / Math.Sqrt(x * x - 2), 3);
        }
    }
}
