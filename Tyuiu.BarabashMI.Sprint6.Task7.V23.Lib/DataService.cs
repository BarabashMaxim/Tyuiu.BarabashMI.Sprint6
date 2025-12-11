using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            int[,] matrix;
            int i = 1, j = 0;
            using (StreamReader reader = new StreamReader(path))
            { 
                string line = reader.ReadLine();
                if (i == 1)
                {
                    foreach (char m in line)
                    {
                        if (m == ';')
                            i++;
                    }
                }
                while (line != null)
                    j++;
            }
            matrix = new int[j, i];
            int l = 0;
            using (StreamReader reader = new StreamReader(path))
            { 
                string line = reader.ReadLine();
                while (line != null)
                { 
                    int[] mass = new int[i];
                    string str = "";
                    int k = 0;
                    for (int u = 0; u < line.Length; u++)
                    {
                        if (line[u] != ';')
                            str += line[u];
                        else
                        {
                            mass[k] = Convert.ToInt32(str);
                            k++;
                            str = "";
                        }
                    }

                    for (int y = 0; y < mass.Length; y++)
                    { 
                        matrix[l, y] = mass[y];
                    }
                }
            }
            return matrix;
        }
    }
}
