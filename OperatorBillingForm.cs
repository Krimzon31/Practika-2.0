using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Practika
{
    public partial class OperatorBillingForm : Form
    {
        string login;
        int rowIndex;
        public OperatorBillingForm(string Login)
        {
            InitializeComponent();
            this.login = Login;
        }

        ConnectionClass connectionClass = new ConnectionClass();

        private void OperatorBillingForm_Load(object sender, EventArgs e)
        {
            Replace();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            Replace();
        }
        private void Replace()
        {
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT N, Payment_Date as Дата_платежа, Price as Сумма, Balance as Баланс, Duty as Долг, Comment as Комментарий, User_Login as Логин FROM Billing WHERE User_Login = '{login}'", connectionClass.GetConnection());

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            ChecksDataGridView.DataSource = db.Tables[0];

            connectionClass.closeConnection();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            (ChecksDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"CONVERT(Долг, 'System.String') LIKE '%{SearchTextBox.Text}%'";
        }

        private void InsertButton_Click(object sender, EventArgs e)
        { 

            DataTable changes = ((DataTable)ChecksDataGridView.DataSource).GetChanges();

            if (changes == null || changes.Rows.Count == 0)
            {
                MessageBox.Show("Нет изменений для сохранения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tableName = "Billing";

            using (var adapter = new SqlDataAdapter($"SELECT N, Payment_Date as Дата_платежа, Price as Сумма, Balance as Баланс, Duty as Долг, Comment as Комментарий, User_Login as Логин FROM {tableName}", connectionClass.GetConnection()))
            using (var commandBuilder = new SqlCommandBuilder(adapter))
            {
                adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                adapter.InsertCommand = commandBuilder.GetInsertCommand();

                try
                {
                    connectionClass.openConnection();
                    adapter.Update(changes);
                    ((DataTable)ChecksDataGridView.DataSource).AcceptChanges();
                    MessageBox.Show("Изменения сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChecksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
