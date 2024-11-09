using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Queue<string> customerQueue = new Queue<string>();
        private int customerCount = 0;

        public Form1()
        {
            InitializeComponent();
            LoadServices();
        }
        private void LoadServices()
        {
            // Добавляем услуги в ComboBox
            comboBoxServices.Items.Add("Касса");
            comboBoxServices.Items.Add("Консультация");
            comboBoxServices.Items.Add("Кредит");
            comboBoxServices.SelectedIndex = 0; // Выбираем первую услугу по умолчанию
        }

        private void btnGetTicket_Click(object sender, EventArgs e)
        {
            customerCount++;
            string customerName = "Клиент " + customerCount;
            customerQueue.Enqueue(customerName);
            listBoxCustomer.Items.Add(customerName);
            UpdateCustomerCount();
            MessageBox.Show(" талон получен.", "Обслуживание клиента");
        }

        private void btnServeCustomer_Click(object sender, EventArgs e)
        {
            if (customerQueue.Count > 0)
            {
                string servedCustomer = customerQueue.Dequeue();
                listBoxCustomer.Items.Remove(servedCustomer);
                UpdateCustomerCount();
                MessageBox.Show(servedCustomer + " был обслужен.", "Обслуживание клиента");
            }
            else
            {
                MessageBox.Show("Очередь пуста.", "Ошибка");
            }
        }

        private void UpdateCustomerCount()
        {
            lblCustomerCount.Text = "Количество клиентов в очереди: " + customerQueue.Count;
        }
    }
}
