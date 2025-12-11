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
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                    j = line.Split(';').Length;
                }
            }
            matrix = new int[i,j];
            int l = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                { 
                    string[] parts = line.Split(";");
                    int LastI = parts.Length - 1;
                    if (Convert.ToInt32(parts[LastI]) < 2)
                        parts[LastI] = "2";
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
