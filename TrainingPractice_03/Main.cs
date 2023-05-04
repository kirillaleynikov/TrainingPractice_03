using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory directory = new Directory();
            directory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remains remains = new Remains();
            remains.Show();
        }
    }
}
