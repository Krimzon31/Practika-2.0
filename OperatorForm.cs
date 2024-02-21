using System;
using SD = System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Practika
{
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        ConnectionClass connectionClass = new ConnectionClass();
        int Index;

        private void AbonentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EventLabel.Text = "";

                SD.DataTable dt = new SD.DataTable();
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AbonentDataGridView.Rows[rowIndex];
                Index = row.Index;

                string User_FIO = row.Cells["ФИО"].Value.ToString();
                string Personal_Account = row.Cells["Лицевой_счёт"].Value.ToString();
                string Services = row.Cells["Услуги"].Value.ToString();

                connectionClass.openConnection();
                string commandString = $"select User_Login from Contract_Data where User_FIO ='{User_FIO}' and Personal_Account='{Personal_Account}'";
                SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);

                string Login = Convert.ToString(dt.Rows[0][0]);
                DialogResult dr = MessageBox.Show("Открыть подробную информацию? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    ContractDataForm contractDataForm = new ContractDataForm(Login);
                    contractDataForm.Show();
                }

                if (row.DefaultCellStyle.BackColor == Color.Red)
                {
                    EventLabel.Text = $"У пользователя: {User_FIO}, не работает: {Services} ";
                    EventLabel.ForeColor = Color.Red;
                }

                connectionClass.closeConnection();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT User_FIO as ФИО, Contract_Number as Номер_абонента ,Personal_Account as Лицевой_счёт, Services as Услуги FROM Contract_Data", connectionClass.GetConnection());

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            AbonentDataGridView.DataSource = db.Tables[0];

            connectionClass.closeConnection();

            Pokraska();
        }

        private void CRMButton_Click(object sender, EventArgs e)
        {
            CRMForm crmForm = new CRMForm();
            crmForm.Show();
        }
        private void Pokraska()
        {
            connectionClass.openConnection();
            string commandString = $"select Services_Status from Contract_Data";
            SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

            DataTable dt = new DataTable();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool serviceStatusValue = Convert.ToBoolean(dt.Rows[i]["Services_Status"]);
                if (!serviceStatusValue)
                { 
                    DataGridViewRow row = AbonentDataGridView.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }

            connectionClass.closeConnection();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            SD.DataTable dt = new SD.DataTable();
            DataGridViewRow row = AbonentDataGridView.Rows[Index];

            string UserFIO = row.Cells["ФИО"].Value.ToString();

            connectionClass.openConnection();
            string commandString = $"select User_Login from Contract_Data WHERE User_FIO = '{UserFIO}'";
            SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            string Login = dataTable.Rows[0][0].ToString();

            OperatorBillingForm operatorBillingForm = new OperatorBillingForm(Login);
            operatorBillingForm.Show();
        }
    }
}
