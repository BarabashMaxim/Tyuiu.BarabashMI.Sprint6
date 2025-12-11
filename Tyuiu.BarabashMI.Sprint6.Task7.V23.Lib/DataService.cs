using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            int[,] matrix;
            int i = 0, j = 0;
            using (StreamReader reader = new StreamReader(path))
            { 
                string line = reader.ReadLine();
                while (line != null)
                {
                    i++;
                    j = line.Split(';').Length;
                }
            }
            matrix = new int[i,j];
            int l = 0;
            using (StreamReader reader = new StreamReader(path))
            { 
                string line = reader.ReadLine();
                while (line != null)
                { 
                    string[] parts = line.Split(";");
                    for (int u = 0; u < j; u++)
                    {
                        matrix[l, u] = Convert.ToInt32(parts[u]);
                    }
                    l++;
                }
            }
            return matrix;
        }
    }
}
