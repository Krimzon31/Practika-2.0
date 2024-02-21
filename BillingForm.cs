using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;

namespace Practika
{
    public partial class BillingForm : Form
    {
        string login;
        int index;
        public BillingForm(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        ConnectionClass connectionClass = new ConnectionClass();

        private void BillingForm_Load(object sender, EventArgs e)
        {
            Replace();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            (ChecksDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Тариф LIKE '%{SearchTextBox.Text}%'";
        }

        private void NewCheckButton_Click(object sender, EventArgs e)
        {
            NewCheckForm newCheckForm = new NewCheckForm(login);
            newCheckForm.Show();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application exApp = new Excel.Application();

                exApp.Workbooks.Add();
                Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
                int j;
                
                for (j = 0; j <= ChecksDataGridView.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = ChecksDataGridView.Columns[j].HeaderText.ToString();
                    wsh.Cells[2, j + 1] = ChecksDataGridView[j, index].Value.ToString();
                }
                exApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Replace()
        {
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT N, Services as Услуга, Rate as Тариф, Price as Стоимость FROM Billing WHERE User_Login = '{login}'", connectionClass.GetConnection());

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            ChecksDataGridView.DataSource = db.Tables[0];

            connectionClass.closeConnection();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            Replace();
        }

        private void ChecksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0)
            {
                MessageBox.Show("Ввыберите строчку", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                index = e.RowIndex;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
