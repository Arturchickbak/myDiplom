using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace diplom
{
    public partial class Form5 : Form
    {
        private Dictionary <string, double> tariffRates = new Dictionary<string, double>();

        public Form5()
        {
            InitializeComponent();
            InitializeTariffRates();
        }
        private void InitializeTariffRates()
        {
            // Добавьте тарифные ставки для разных видов услуг
            tariffRates.Add("Электричество", 4.35);
            tariffRates.Add("Газ", 3.15);
            tariffRates.Add("Вода", 2.45
                );
            // и т.д.
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение выбранного вида услуги
string selectedService = comboBox1.SelectedItem?.ToString();

            if (selectedService != null && tariffRates.ContainsKey(selectedService))
            {
                // Получение начальных и конечных показаний счетчика от пользователя
                int startReading = Convert.ToInt32(textBox1.Text);
                int endReading = Convert.ToInt32(textBox2.Text);

                // Вычисление разницы между начальными и конечными показаниями счетчика
                int consumption = endReading - startReading;  

                // Получение тарифной ставки для выбранного вида услуги
                double tariffRate = tariffRates[selectedService];

                // Расчет суммы к оплате
                double totalPayment = consumption * tariffRate;

                // Вывод результата пользователю
                MessageBox.Show($"К оплате за {selectedService}: {totalPayment} рублей");
            }
            else
            {
                MessageBox.Show("Выберите вид услуги и укажите корректные показания счетчика.");
            }
        }
        // Обработчик события изменения выбранного вида услуги
        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь можно реализовать логику для дополнительных действий при изменении выбранного вида услуги
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
