using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Practika
{
    public partial class AbonentForm : Form
    {
        string login;
        Label currentSelectItem = null;

        ConnectionClass connectionClass = new ConnectionClass();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        int labelWidth = 200;
        int labelHeight = 20;
        int startX = 160;     
        int startY = 220;

        public AbonentForm(string Login)
        {
            InitializeComponent();

            this.login = Login;
        }

        private void AbonentForm_Load(object sender, EventArgs e)
        {
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT top 1 User_FIO FROM Contract_Data where User_Login = '{login}'", connectionClass.GetConnection());

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            FIOLabel.Text = Convert.ToString(dt.Rows[0][0]);

            connectionClass.closeConnection();

            connectionClass.openConnection();

            SqlCommand sqlcommand = new SqlCommand($"SELECT Services FROM Contract_Data where User_Login = '{login}'", connectionClass.GetConnection());


            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = sqlcommand;
            sqlDataAdapter.Fill(dataTable);

            for (int rowIndex = 0; rowIndex < dataTable.Rows.Count; rowIndex++)
            {
                Label label = new Label();

                label.Text = dataTable.Rows[rowIndex][0].ToString();

                label.Location = new Point(startX + 0 * labelWidth, startY + rowIndex * labelHeight);
                label.Size = new Size(labelWidth, labelHeight);
                Font = new Font("Montserrat", 11, FontStyle.Regular);

                if (Proverka(rowIndex))
                {
                    label.ForeColor = Color.Red;
                }
                else
                {
                    label.ForeColor = Color.Black;
                }

                label.Click += Label_Click;

                this.Controls.Add(label);
                Refresh();
            }

            connectionClass.closeConnection();
        }

        private void работаетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectItem == null)
            {
                MessageBox.Show("Выберите услугу", "Ошибка");
            }
            else
            {
                string commandString = $"update Contract_Data set Services_Status = 1 where User_Login = '{login}' and Services = '{currentSelectItem.Text.ToString()}'";

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

                currentSelectItem.ForeColor = Color.Black;

            }
        }

        private void неРаботаетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectItem == null)
            {
                MessageBox.Show("Выберите услугу", "Ошибка");
            }
            else
            {
                string commandString = $"update Contract_Data set Services_Status = 0 where User_Login = '{login}' and Services = '{currentSelectItem.Text}' ";

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

                currentSelectItem.ForeColor = Color.Red;
            }
        }

        private bool Proverka( int i)
        {
            connectionClass.openConnection();
            string commandString = $"select Services_Status from Contract_Data where User_Login ='{login}'";
            SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

            DataTable dt = new DataTable();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt);

            bool serviceStatusValue = (bool)dt.Rows[i][0];
            if (serviceStatusValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            currentSelectItem = clickedLabel;
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {

        }
    }
}
