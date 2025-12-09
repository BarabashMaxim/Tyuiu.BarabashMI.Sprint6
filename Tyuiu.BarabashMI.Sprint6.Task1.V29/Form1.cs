using Tyuiu.BarabashMI.Sprint6.Task1.V29.Lib;
namespace Tyuiu.BarabashMI.Sprint6.Task1.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void PressDone(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int stop = Convert.ToInt32(textBox2.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                string str;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBox3.Text = "";
                textBox3.AppendText("+----------+----------+" + Environment.NewLine);
                textBox3.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBox3.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,5:d}     | {1,5:f2}    |", start, value[i]);
                    textBox3.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBox3.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("ѕу-пу-пу, что-то не то", "попробуй ещЄ раз", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
