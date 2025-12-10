using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BarabashMI.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader sr = new StreamReader(path))
            { 
                string line = sr.ReadLine();
                while (line != null)
                {
                    string str = "";
                    foreach (char c in line)
                    {
                        if (c != ' ')
                            str += c;
                        else
                            break;
                    }
                    res += str; 
                }
            }
            return res;

        }
    }
}
