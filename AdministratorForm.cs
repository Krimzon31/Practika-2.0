using System;
using SD =System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Aspose.Cells;
using Worksheet = Aspose.Cells.Worksheet;
using Workbook = Aspose.Cells.Workbook;
using System.Data;
using System.IO;
using ExcelDataReader;

namespace Practika
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        ConnectionClass connectionClass = new ConnectionClass();
        int currentRowIndex;

        private void ArhivButton_Click(object sender, EventArgs e)
        {
            ArhivForm arhivForm = new ArhivForm();
            arhivForm.Show();
        }

        private void AdministratotForm_Load(object sender, EventArgs e)
        {
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT User_FIO as ФИО, Contract_Number as Номер_абонента ,Personal_Account as Лицевой_счёт, Services as Услуги FROM Contract_Data", connectionClass.GetConnection());

            SD.DataSet db = new SD.DataSet();

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
            string commandString = $"select Services_Status, Support from Contract_Data";
            SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

            SD.DataTable dt = new SD.DataTable();

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

                bool SupprtValue = Convert.ToBoolean(dt.Rows[i]["Support"]);
                if (!SupprtValue)
                {
                    DataGridViewRow row = AbonentDataGridView.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }

            connectionClass.closeConnection();
        }

        private void AbonentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EventLabel.Text = "";

                SD.DataTable dt = new SD.DataTable();
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AbonentDataGridView.Rows[rowIndex];
                currentRowIndex = e.RowIndex;

                string User_FIO = row.Cells["ФИО"].Value.ToString();
                string Personal_Account = row.Cells["Лицевой_счёт"].Value.ToString();
                string Services = row.Cells["Услуги"].Value.ToString();

                connectionClass.openConnection();
                string commandString = $"select User_Login from Contract_Data where User_FIO ='{User_FIO}' and Personal_Account='{Personal_Account}'";
                SqlCommand sqlCommand = new SqlCommand(commandString, connectionClass.GetConnection());

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);

                string Login = Convert.ToString(dt.Rows[0][0]);

                if (row.DefaultCellStyle.BackColor == Color.Red)
                {
                    EventLabel.Text = $"У пользователя: {User_FIO}, не работает: {Services} ";
                    EventLabel.ForeColor = Color.Red;
                }

                connectionClass.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EventLabel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = AbonentDataGridView.Rows[currentRowIndex];

            string Personal_Account = row.Cells["Лицевой_счёт"].Value.ToString();
            string Services = row.Cells["Услуги"].Value.ToString();

            if (row.DefaultCellStyle.BackColor == Color.Red)
            {
                ZaavkaForm zaavkaForm = new ZaavkaForm(Personal_Account, Services);
                zaavkaForm.Show();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Krimzon;Initial Catalog=TestDB;Integrated Security=True";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var excelReader = ExcelReaderFactory.CreateReader(File.Open("D:\\DataTableImported.xlsx", FileMode.Open)))
                {
                    var dataSet = excelReader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    });

                    foreach (DataTable table in dataSet.Tables)
                    {
                        using (var bulkCopy = new SqlBulkCopy(connection))
                        {
                            bulkCopy.DestinationTableName = table.TableName;
                            bulkCopy.WriteToServer(table);
                        }
                    }
                }
            }
            MessageBox.Show("Импорт завершён", "Успеш:", MessageBoxButtons.OK);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            try
            {
                connectionClass.openConnection();

                SqlDataAdapter dataAdapterUser_Table = new SqlDataAdapter("SELECT * FROM Autorization_data", connectionClass.GetConnection());
                SqlDataAdapter dataAdapterContract_Table = new SqlDataAdapter("SELECT * FROM Contract_Data", connectionClass.GetConnection());
                SqlDataAdapter dataAdapterArchiv_Table = new SqlDataAdapter("SELECT * FROM Arhiv", connectionClass.GetConnection());
                SqlDataAdapter dataAdapterBilling_Table = new SqlDataAdapter("SELECT * FROM Billing", connectionClass.GetConnection());
                SqlDataAdapter dataAdapterAplication_Table = new SqlDataAdapter("SELECT * FROM Applications_for_the_operator", connectionClass.GetConnection());

                SD.DataTable User_Table = new SD.DataTable();
                SD.DataTable Contract_Table = new SD.DataTable();
                SD.DataTable Archiv_Table = new SD.DataTable();
                SD.DataTable Billing_Table = new SD.DataTable();
                SD.DataTable Aplication_Table = new SD.DataTable();

                dataAdapterUser_Table.Fill(User_Table);
                dataAdapterContract_Table.Fill(Contract_Table);
                dataAdapterArchiv_Table.Fill(Archiv_Table);
                dataAdapterBilling_Table.Fill(Billing_Table);
                dataAdapterAplication_Table.Fill(Aplication_Table);

                connectionClass.closeConnection();

                Workbook workbookForDataTable = new Workbook();
                workbookForDataTable.Worksheets[0].Name = "Autorization_data";
                workbookForDataTable.Worksheets.Add("Contract_Data");
                workbookForDataTable.Worksheets.Add("Arhiv");
                workbookForDataTable.Worksheets.Add("Billing");
                workbookForDataTable.Worksheets.Add("Applications_for_the_operator");

                ImportTableOptions importOptions = new ImportTableOptions();

                Worksheet dataTableWorksheet1 = workbookForDataTable.Worksheets[0];
                Worksheet dataTableWorksheet2 = workbookForDataTable.Worksheets[1];
                Worksheet dataTableWorksheet3 = workbookForDataTable.Worksheets[2];
                Worksheet dataTableWorksheet4 = workbookForDataTable.Worksheets[3];
                Worksheet dataTableWorksheet5 = workbookForDataTable.Worksheets[4];

                dataTableWorksheet1.Cells.ImportData(User_Table, 0, 0, importOptions);
                dataTableWorksheet2.Cells.ImportData(Contract_Table, 0, 0, importOptions);
                dataTableWorksheet3.Cells.ImportData(Archiv_Table, 0, 0, importOptions);
                dataTableWorksheet4.Cells.ImportData(Billing_Table, 0, 0, importOptions);
                dataTableWorksheet5.Cells.ImportData(Aplication_Table, 0, 0, importOptions);

                dataTableWorksheet1.AutoFitColumns();
                dataTableWorksheet2.AutoFitColumns();
                dataTableWorksheet3.AutoFitColumns();
                dataTableWorksheet4.AutoFitColumns();
                dataTableWorksheet5.AutoFitColumns();

                workbookForDataTable.Save("D:\\DataTableImported.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Экспорт завершён", "Успеш:", MessageBoxButtons.OK);
        }
    }
}
