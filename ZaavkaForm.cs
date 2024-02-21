using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Practika
{
    public partial class ZaavkaForm : Form
    {
        string Personal_Account;
        string Services;
        ConnectionClass connectionClass = new ConnectionClass();

        public ZaavkaForm(string Personal_Account, string Services)
        {
            InitializeComponent();

            this.Personal_Account = Personal_Account;
            this.Services = Services;
        }

        private void ZaavkaForm_Load(object sender, EventArgs e)
        {
            Personal_AccountTextBox.Text = Personal_Account;
            ServicesTextBox.Text = Services;
            comboBox1.SelectedItem = "Новый";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (FIOIngenerTextBox.Text == null)
            {
                MessageBox.Show("Введите ФИО Инженера", "Ошибка");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Вы уверены что хотите назначить этого инженера", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    if (comboBox1.SelectedItem.ToString() == "Новый") {
                        string commandString = $"update Contract_Data set Support = 0, Services_Status = 1, FIO_Ingener = '{FIOIngenerTextBox.Text}' where Personal_Account = '{Personal_Account}' and Services = '{Services}'";

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
                    }

                    if (comboBox1.SelectedItem.ToString() == "Закрытый")
                    {
                        string commandString = $"update Contract_Data set Support = 1, Services_Status = 1, FIO_Ingener = '{FIOIngenerTextBox.Text}' where Personal_Account = '{Personal_Account}' and Services = '{Services}'";

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
                    }
                }

            }
        }
    }
}
