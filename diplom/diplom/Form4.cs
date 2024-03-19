using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }

        private void Kabinet_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }
    }
}
