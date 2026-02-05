using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppШ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            const double a = 1.7718;
            for (int d = 1; d <= 10; d++)
            {
                double grams = d * a;
                dataGridView1.Rows.Add(d, Math.Round(grams, 3));
            }
        }
    }
}