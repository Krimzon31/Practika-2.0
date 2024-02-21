using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practika
{
    public partial class NewCheckForm : Form
    {
        string login;
        public NewCheckForm( string login)
        {
            InitializeComponent();
            this.login = login;
        }
        ConnectionClass connectionClass = new ConnectionClass();

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ServiceTextBox.Text == "" | RateTextBox.Text == "" | PriceTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
            }
            else
            {
                string Service = ServiceTextBox.Text;
                string Rate = RateTextBox.Text;
                string Price = PriceTextBox.Text;

                string commandString = $"insert Billing(Service, Rate, Price, Duty) values('{Service}', '{Rate}', {Price}, {100}, '{login}')";

                SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

                connectionClass.openConnection();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
                connectionClass.closeConnection();

                this.Close();
            }

        }

        private void NewCheckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
