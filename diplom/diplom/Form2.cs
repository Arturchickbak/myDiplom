using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
    
{
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)

        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            int startReading = Convert.ToInt32(textBox1.Text);
            int endReading = Convert.ToInt32(textBox2.Text);

            // Вычисление разницы между начальными и конечными показаниями счетчика
            int consumption = endReading - startReading;

            // Тарифная ставка за единицу потребления (например, 1 кВт⋅ч)
            double tariffRate = 4.81; // Пример тарифа

            // Расчет суммы к оплате
            double totalPayment = consumption * tariffRate;

            // Вывод результата пользователю
            MessageBox.Show($"К оплате: {totalPayment} рублей");
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

