namespace сидоров
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                int inches = Convert.ToInt32(textBox1.Text);

                double cm = inches * 2.5;

                string result = $"{inches} дюймов = {cm:F2} см";
                label1.Text = result;
            }
            catch 
            {
                MessageBox.Show("Введите корректное число!");
            }

        }
    }
}
