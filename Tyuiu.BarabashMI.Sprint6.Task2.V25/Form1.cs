using Tyuiu.BarabashMI.Sprint6.Task2.V25.Lib;
namespace Tyuiu.BarabashMI.Sprint6.Task2.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int stop = Convert.ToInt32(textBox2.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] array = new double[len];
                array = ds.GetMassFunction(start, stop);

                this.chartFunction
            }
            catch
            { 
            
            }
        }
    }
}
