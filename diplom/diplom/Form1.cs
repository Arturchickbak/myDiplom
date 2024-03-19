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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")

            {
                if (textBox2.Text == "admin")

                {
                    Form4 f4 = new Form4();

                    f4.ShowDialog();
                }

            }

            else

            {
                Console.WriteLine("Пароль введен неправильно");
               
            }

            { 
                this.Close(); 
            }
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





